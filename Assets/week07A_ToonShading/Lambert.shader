Shader "My/Lambert/Starter2"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}  
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        #pragma surface surf MyFunction noambient
        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }

        float4 LightingMyFunction(SurfaceOutput s, float3 lightDir, float atten){ //lighting 키워드 적어서 인식하도록	

            //float result = dot(s.Normal, lightDir) * 0.5 + 0.5; 
            //result = saturate(result) + 0.5; //saturate -> 0이하 자름  +0.5-> 밝은 부분만 처리하는 것 막/

            float result = saturate(dot(s.Normal, lightDir));

            float4 final;

            final.rgb = s.Albedo * result;
            final.a = s.Alpha;

            return final;
        }

        ENDCG
    }
    FallBack "Diffuse"
}
