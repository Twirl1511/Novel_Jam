using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public GameObject mask;
    private bool _pressed;
    public List<GameObject> masks;

    private void Start()
    {
        masks = new List<GameObject>(300);
    }
    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;

        if (_pressed)
        {
            GameObject newMask = Instantiate(mask, pos, Quaternion.identity);
            newMask.transform.parent = GameObject.Find("MASK").transform;
            masks.Add(newMask);
        }
        if (Input.GetMouseButtonDown(0))
        {
            _pressed = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _pressed = false;
        }



        
    }
    public void DeleteAllMasks()
    {
        foreach(var e in masks)
        {
            GameObject.Destroy(e);
        }
        masks.Clear();
    }
}
