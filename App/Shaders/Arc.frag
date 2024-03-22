#version 100
precision highp float;
#define UNIFORMARRAY_SIZE 11

varying vec2 texCoord;
varying vec2 pos;

uniform sampler2D aTexture;
uniform vec4 aFrag[UNIFORMARRAY_SIZE];

#define type int(aFrag[0].x)
#define texType int(aFrag[0].y)
#define radius aFrag[0].z
#define feather aFrag[0].w

#define strokeMult aFrag[1].x
#define strokeThr aFrag[1].y
#define extent aFrag[1].zw

#define scissorMat mat3(aFrag[2].xyz, aFrag[3].xyz, aFrag[4].xyz)
#define scissorExt aFrag[5].xy
#define scissorScale aFrag[5].zw

#define paintMat mat3(aFrag[6].xyz, aFrag[7].xyz, aFrag[8].xyz)

#define innerCol aFrag[9]
#define outerCol aFrag[10]


float scissorMask(vec2 p) {
	vec2 sc = (abs((scissorMat * vec3(p, 1.0)).xy) - scissorExt);
	sc = vec2(0.5,0.5) - sc * scissorScale;
	return clamp(sc.x,0.0,1.0) * clamp(sc.y,0.0,1.0);
}

float strokeMask() {
	return min(1.0, (1.0 - abs(texCoord.x * 2.0 - 1.0)) * strokeMult) * min(1.0, texCoord.y);
}

void main()
{
	float strokeAlpha = strokeMask();
	float scissor = scissorMask(pos);

	if (type == 0) {		//FillGradient
		vec4 c = innerCol;
		gl_FragColor = c;
	}
	else if (type == 1) {	//FillTexture
		vec2 pt = (paintMat * vec3(pos.x - 0.5, pos.y - 0.5, 1.0)).xy / extent;
		vec4 color = texture2D(aTexture, pt);
		if (texType == 1) color = vec4(color.xyz*color.w,color.w);
		if (texType == 2) color = vec4(color.x);
		// Apply color tint and alpha.
		color *= innerCol;
		// Combine alpha
		color *= strokeAlpha * scissor;
		gl_FragColor = color;

		//vec4 tex = texture2D(aTexture, texCoord);
		//gl_FragColor = tex;

		//vec2 pt = (paintMat * vec3(pos, 1.0)).xy / extent;
		//vec4 color = texture2D(aTexture, pt);
		//gl_FragColor = color;
	}
	else if (type == 2) {	// StencilFill
		gl_FragColor = vec4(1,1,1,1);
	}
	else if (type == 3) {	//Image
		gl_FragColor = innerCol;
	}
}