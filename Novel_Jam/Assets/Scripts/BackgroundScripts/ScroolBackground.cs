using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScroolBackground : MonoBehaviour
{
    public GameObject[] sprites;
    private Transform _backgroundTransform;
    [SerializeField] private float _speed;
    float offsetX = 0;
    void Start()
    {
        
        _backgroundTransform = GetComponent<Transform>();
    }

    
    void Update()
    {
        
        offsetX += Time.deltaTime;
        Vector3 newPosition = new Vector3(offsetX, _backgroundTransform.position.y, _backgroundTransform.position.z);
        _backgroundTransform.position = newPosition;


        
    }

    public void Switch(string way)
    {
        if(way == "left")
        {
            GameObject buffer = sprites[0];
            
        }
        
    }




}
