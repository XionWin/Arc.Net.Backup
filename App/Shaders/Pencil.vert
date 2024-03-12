#version 100

attribute vec2 aPos;
attribute vec2 aTexCoord;

uniform int aPointSize;
uniform vec2 aViewport;

varying vec2 texCoord;

void main(void)
{
    gl_Position = vec4(aPos.x / aViewport.x * 2.0 - 1.0, 1.0 - aPos.y / aViewport.y * 2.0, 0.0, 1.0);
	texCoord = aTexCoord;
	gl_PointSize  = float(aPointSize);
}