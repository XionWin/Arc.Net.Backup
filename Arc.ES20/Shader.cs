﻿#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using OpenTK.Graphics.ES20;
#endif
using Extension;
using OpenTK.Mathematics;
using static Extension.SemanticExtension;


namespace Arc.ES20;

public class Shader
{
    public int ProgramHandle { get; init; }

    public readonly Dictionary<string, int> UniformLocations = new Dictionary<string, int>();

    public Shader(string vertexPath, string fragmentPath)
    {
        if (File.ReadAllText(vertexPath) is string vertexSource && File.ReadAllText(fragmentPath) is string fragmentSource)
        {
            var vertexShader = vertexSource.CompileShader(ShaderType.VertexShader);
            var fragmentShader = fragmentSource.CompileShader(ShaderType.FragmentShader);
            // Next, allocate the dictionary to hold the locations.
            this.ProgramHandle = GL.CreateProgram();
            this.LinkProgram(vertexShader, fragmentShader);
        }
        else
            throw new Exception($"Create shader failed");
    }

    public void Use()
    {
        GL.UseProgram(ProgramHandle);
    }

    public void Uniform1(string locationName, int v)
    {
        GL.UseProgram(ProgramHandle);
        GL.Uniform1(this.UniformLocations[locationName], v);
    }
    public void Uniform1(string locationName, float v)
    {
        GL.UseProgram(ProgramHandle);
        GL.Uniform1(this.UniformLocations[locationName], v);
    }
    public void Uniform2(string locationName, Vector2 v)
    {
        GL.UseProgram(ProgramHandle);
        GL.Uniform2(this.UniformLocations[locationName], v.X, v.Y);
    }
    public void Uniform2(string locationName, float v0, float v1)
    {
        GL.UseProgram(ProgramHandle);
        GL.Uniform2(this.UniformLocations[locationName], v0, v1);
    }
    public void Uniform2(string locationName, float[] vs)
    {
        GL.UseProgram(ProgramHandle);
        if(vs.Length % 2 == 0)
        {
            var dLen = vs.Length / 2;
            GL.Uniform2(this.UniformLocations[locationName], dLen, vs);
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    public void Uniform4(string locationName, Color4 data)
    {
        GL.UseProgram(ProgramHandle);
        GL.Uniform4(this.UniformLocations[locationName], data.R, data.G, data.B, data.A);
    }
    public void Uniform4(string locationName, float v0, float v1, float v2, float v3)
    {
        GL.UseProgram(ProgramHandle);
        GL.Uniform4(this.UniformLocations[locationName], v0, v1, v2, v3);
    }
    public void Uniform4(string locationName, float[] vs)
    {
        GL.UseProgram(ProgramHandle);
        if(vs.Length % 4 == 0)
        {
            var dLen = vs.Length / 4;
            GL.Uniform4(this.UniformLocations[locationName], dLen, vs);
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    public void UniformMatrix2(string locationName, float[] vs)
    {
        GL.UseProgram(ProgramHandle);
        if(vs.Length % 4 == 0)
        {
            var dLen = vs.Length / 4;
            GL.UniformMatrix2(this.UniformLocations[locationName], dLen, false, vs);
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }

    public int GetAttribLocation(string attribName)
    {
        return GL.GetAttribLocation(ProgramHandle, attribName);
    }

    public void EnableAttribs(IEnumerable<AttribLocation> attribLocations) => this.EnableAttribLocations(attribLocations);
}

static class ShaderExtension
{
    public static void EnableAttribLocations(this Shader shader, IEnumerable<AttribLocation> attribLocations)
    {
        var totalLen = attribLocations.Sum(x => x.Length);
        foreach (var attribLocation in attribLocations)
        {
            var texCoordLocation = shader.GetAttribLocation(attribLocation.Name);
            GL.EnableVertexAttribArray(texCoordLocation);
            GL.VertexAttribPointer(texCoordLocation, attribLocation.Length, VertexAttribPointerType.Float, false, totalLen * sizeof(float), attribLocation.Start * sizeof(float));
        }
    }

    public static int CompileShader(this string shaderSource, ShaderType shaderType) =>
        GL.CreateShader(shaderType) is var shader
        && shaderSource
        .With(x => GL.ShaderSource(shader, shaderSource))
        .Then(x => CompileShader(shader)) is var code
        && code is (int)All.True ?
            shader :
            throw new Exception($"Error occurred whilst compiling Shader({shader}).\n\n{GL.GetShaderInfoLog(shader)}");

    private static int CompileShader(int shader)
    {
        // Try to compile the shader
        GL.CompileShader(shader);

        // Check for compilation errors
        GL.GetShader(shader, ShaderParameter.CompileStatus, out var code);
        return code;
    }

    public static void LinkProgram(this Shader shader, int vertexShader, int fragmentShader)
    {
        // Attach both shaders...
        GL.AttachShader(shader.ProgramHandle, vertexShader);
        GL.AttachShader(shader.ProgramHandle, fragmentShader);

        // And then link them together.
        var code = LinkProgram(shader.ProgramHandle);
        if (code is not (int)All.True)
        {
            // We can use `GL.GetProgramInfoLog(program)` to get information about the error.
            throw new Exception($"Error occurred whilst linking Program({shader.ProgramHandle})");
        }

        // When the shader program is linked, it no longer needs the individual shaders attached to it; the compiled code is copied into the shader program.
        // Detach them, and then delete them.
        GL.DetachShader(shader.ProgramHandle, vertexShader);
        GL.DetachShader(shader.ProgramHandle, fragmentShader);
        GL.DeleteShader(fragmentShader);
        GL.DeleteShader(vertexShader);

        // The shader is now ready to go, but first, we're going to cache all the shader uniform locations.
        // Querying this from the shader is very slow, so we do it once on initialization and reuse those values
        // later.

        // First, we have to get the number of active uniforms in the shader.
        GL.GetProgram(shader.ProgramHandle, GetProgramParameterName.ActiveUniforms, out var numberOfUniforms);

        // Loop over all the uniforms,
        for (var i = 0; i < numberOfUniforms; i++)
        {
            // get the name of this uniform,
            var key = GL.GetActiveUniform(shader.ProgramHandle, i, out var size, out var uniformType);

            // get the location,
            var location = GL.GetUniformLocation(shader.ProgramHandle, key);

            if(size > 1)
            {
                key = key.Substring(0, key.IndexOf('[') is var index && index > 0 ? index : key.Length );
            }
            // and then add it to the dictionary.
            shader.UniformLocations.Add(key, location);
        }
    }

    private static int LinkProgram(int program)
    {
        // We link the program
        GL.LinkProgram(program);

        // Check for linking errors
        GL.GetProgram(program, GetProgramParameterName.LinkStatus, out var code);
        return code;
    }
}

