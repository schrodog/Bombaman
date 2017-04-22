using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class canvasItem : MonoBehaviour {
    
    Texture2D[] thisTexture;
    public GameObject[] ImageHolder = new GameObject[3];        //max number of items can be held at a time
    int ct = 0;

    void Start()
    {
        string[] ImageNames = { "item0.jpg", "item1.png" };     //list of item sprite names
        thisTexture = new Texture2D[ImageNames.Length];
        for (int i = 0; i < ImageNames.Length; i++)
        {
            thisTexture[i] = new Texture2D(100, 100);
            byte[] bytes = File.ReadAllBytes(Application.dataPath + "/Resources/Sprites/" + ImageNames[i]);
            thisTexture[i].LoadImage(bytes);
            thisTexture[i].name = ImageNames[i];
        }
    }
    
    void Update () {
        bool[] hasItem = new bool[ImageHolder.Length];      //TRUE if player has an item in slot i
        hasItem[0] = true;
        hasItem[1] = true;
        hasItem[2] = false;

        //print item based on what the player has
        for (int i = 0; i < ImageHolder.Length; i++)
        {
            if (hasItem[i])
                ImageHolder[i].GetComponent<RawImage>().texture = thisTexture[ct];
            else
                ImageHolder[i].GetComponent<RawImage>().texture = null;
        }

        if (ct == 1)
            ct = 0;
        else
            ct++;
    }
}
