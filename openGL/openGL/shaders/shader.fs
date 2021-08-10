#version 330 core

out vec4 FragColor;

in  vec2 TexCoord;

uniform sampler2D ourTexture1;
uniform sampler2D ourTexture2;
uniform float scale;

void main()
{
              //texture(sampler , texture coordinates)
    //FragColor = texture(ourTexture1, TexCoord);
    FragColor =  mix(texture(ourTexture1, TexCoord ) , texture(ourTexture2 , TexCoord) , scale );
}
