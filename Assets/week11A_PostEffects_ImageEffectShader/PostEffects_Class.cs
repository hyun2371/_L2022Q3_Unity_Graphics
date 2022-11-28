using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode] //show effect in edit mode
public class PostEffects_Class : MonoBehaviour
{
    Shader myShader;
    Material myMaterial;

    // Start is called before the first frame update
    void Start()
    {
        myShader = Shader.Find("My/PostEffects/Class");
        myMaterial = new Material(myShader);

    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        //copy pixel array source to destination   
        Graphics.Blit(source, destination, myMaterial, 0); //0 -> select path
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }
}
