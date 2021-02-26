using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeScreenLeftRight : MonoBehaviour
{
    public GameObject[] sprites;
    private Transform _backgroundTransform;
    [SerializeField] private float _speed;
    void Start()
    {
        
        _backgroundTransform = GetComponent<Transform>();
    }

    
    void Update()
    {
        float offsetX =+ _speed * Time.deltaTime;
        Vector3 newPosition = new Vector3(offsetX, _backgroundTransform.position.y, _backgroundTransform.position.z);
        _backgroundTransform.position = newPosition;
    }



}
