using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxScript : MonoBehaviour
{
    public RawImage img;

    public float speed;

    // Update is called once per frame
    void Update()
    {
        Rect rect = img.uvRect;
        rect.x += speed;
        img.uvRect = rect;
    }
}
