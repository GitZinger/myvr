using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseFigure : MonoBehaviour
{
    Texture2D mytexture;
    // Start is called before the first frame update
    void Start()
    {
        mytexture = new Texture2D(128, 128);
        GetComponent<Renderer>().material.mainTexture = mytexture;

         
        
      
    }

    // Update is called once per frame
    void Update()
    {

        for(int i=0; i<mytexture.height; i++)
        {
            for(int j=0; j < mytexture.width; j++)
            {
                Color mycolor = Random.ColorHSV();

                mytexture.SetPixel(i, j, mycolor);

            }
        }

        mytexture.Apply();
    }
}
