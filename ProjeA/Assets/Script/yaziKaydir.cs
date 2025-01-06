using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class yaziKaydir : MonoBehaviour
{
    public TMP_Text text;
    public float hiz=3f,hiz1=0.01f,hiz3=2f;
    void Update()
    {
        text.ForceMeshUpdate();
        var textinfo = text.textInfo;
        

        for (int i = 0; i < textinfo.characterCount; i++)
        {
            var charinfo = textinfo.characterInfo[i];

            if (!charinfo.isVisible)
            {
                continue;
            }
            var verts = textinfo.meshInfo[charinfo.materialReferenceIndex].vertices;
            for (int j = 0; j < 4; j++)
            {
                var orig = verts[charinfo.vertexIndex + j];
                verts[charinfo.vertexIndex + j] = orig + new Vector3(0, Mathf.Sin(Time.time * hiz + orig.x * hiz1) * hiz3, 0);
            }
            
        }

        for (int i = 0; i < textinfo.meshInfo.Length; i++)
        {

            var meshinfo = textinfo.meshInfo[i];
            meshinfo.mesh.vertices = meshinfo.vertices;

            text.UpdateGeometry(meshinfo.mesh, i);
        }


        
    }
}
