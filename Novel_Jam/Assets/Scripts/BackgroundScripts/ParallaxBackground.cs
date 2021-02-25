using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public float scrollX = .5f;
    public float scrollY = .5f;
    // Update is called once per frame
    void Update()
    {
        float OffsetX = scrollX * Time.deltaTime;
        float OffsetY = scrollY * Time.deltaTime;
    }
}
