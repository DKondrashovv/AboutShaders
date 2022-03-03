Shader "Unlit/Lambert"
{
    SubShader
    {
            Tags { "RenderType" = "Opaque" }
            LOD 100
            
            Pass
            {
                CGPROGRAM
                #pragma vertex vert
                #pragma fragment frag
                

                #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
               
            };

            struct v2f
            {
                float4 color : COLOR;
                float4 vertex : SV_POSITION;
            };
                
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.color.rgba = dot(v.normal,_WorldSpaceLightPos0);
              
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                return i.color;
            }
            ENDCG
            }
    }
}
