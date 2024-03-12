#version 100
precision mediump float;
#define UNIFORMARRAY_SIZE 11

varying vec2 texCoord;

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

float strokeMask() {
	return min(1.0, (1.0 - abs(texCoord.x * 2.0 - 1.0)) * strokeMult) * min(1.0, texCoord.y);
}

void main()
{
	if (type == 0) {
		vec4 tex = texture2D(aTexture, texCoord);
		gl_FragColor = tex;
	}
	else if (type == 1) {
		vec4 c = innerCol * strokeMask();
		gl_FragColor = c;
	}
	else if (type == 9) {
		gl_FragColor = innerCol;
	}
}