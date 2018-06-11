using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cintanimation : MonoBehaviour
{

    public int uvTileY = 1;
    public int uvTileX = 5;

    public int fps = 30;

    private int index;



    // Update is called once per frame
    void Update()
    {

        index = (int)(Time.time * fps);
        index = index % (uvTileY * uvTileX);
        Vector2 size = new Vector2(1.0f / uvTileY, 1.0f / uvTileX);

        var uIndex = index % uvTileX;
        var vIndex = index / uvTileX;

        Vector2 offset = new Vector2(uIndex * size.x, 1.0f - size.y - vIndex * size.y);

        GetComponent<Renderer>().material.SetTextureOffset("_MainText", offset);
        GetComponent<Renderer>().material.SetTextureScale("_MainText", size);
    }
}
