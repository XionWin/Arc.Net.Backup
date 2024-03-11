#version 100
precision mediump float;

varying vec2 texCoord;
varying vec4 color;

uniform sampler2D aTexture;
uniform int aMode;

float strokeMask() {
	return min(1.0, (1.0-abs(texCoord.x*2.0-1.0))*2.0) * min(1.0, texCoord.y);
	// return min(1.0, (1.0-abs(texCoord.x*2.0-1.0))*16.0) * min(1.0, (1.0-abs(1.0-texCoord.y*2.0))*16.0);
}

void main()
{
	// float alpha = texture2D(aTexture, texCoord).w * color.w;
	// gl_FragColor = vec4(color.xyz, alpha <=0.3 ? 0.2 : alpha);

	if (aMode == 0) {
		vec4 tex = texture2D(aTexture, texCoord);
		gl_FragColor = tex;
	}
	else if (aMode == 1) {
		vec4 c = color * strokeMask();
		gl_FragColor = c;
	}
	else if (aMode == 9) {
		gl_FragColor = color;
	}

}