﻿using Extension;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace Arc.ES20;
public class GLWindow : GameWindow
{
    public GLWindow(string title, int? width = null, int? height = null, string? iconPath = null)
    : this(title, width ?? 720, height ?? 720, iconPath ?? "Resources/Images/icon.png")
    { }

    public Shader Shader { get; init; }

    private GLWindow(string title, int width, int height, string? iconPath = null) :
        base(
            new GameWindowSettings()
            {
                UpdateFrequency = 10,
                RenderFrequency = 30 
            },
            new NativeWindowSettings()
            {
                Title = title,
                Size = new Vector2i(width, height),
                WindowBorder = WindowBorder.Fixed,
                API = ContextAPI.OpenGLES,
                APIVersion = new Version(2, 0),
                Icon = iconPath?.Then(x => ImageExtension.CreateWindowIcon(x))
            }
        )
    {
        this.CenterWindow();
        this.Title = this.Title + $" | {this.API} {this.APIVersion.Major}.{this.APIVersion.Minor}";
        this.Shader = new Shader($"Shaders/{title}.vert", $"Shaders/{title}.frag");
    }

    protected override void OnLoad()
    {
        base.OnLoad();
        this.Shader.Use();
    }
}
