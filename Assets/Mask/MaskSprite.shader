Shader "Custom/MaskSprite" {
	Properties {
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
	}
	SubShader {
		Pass
		{
			Stencil
            {
                Ref 5
                Comp Never
				Fail Replace
            }

			AlphaTest Greater 0.1
            SetTexture [_MainTex] {
                combine texture * primary, texture
            }
		}
	}
}
