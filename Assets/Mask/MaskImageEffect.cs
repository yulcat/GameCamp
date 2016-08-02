using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class MaskImageEffect : MonoBehaviour {
	public Shader maskShader;
	private Material maskMaterial;
    void Awake() {
		if (!maskShader)
            Debug.LogError("Shader missing, assign them.");
		maskMaterial = new Material(maskShader);
    }
    void OnRenderImage (RenderTexture source, RenderTexture destination) {
        Graphics.Blit(source, destination, maskMaterial);
    }

}
