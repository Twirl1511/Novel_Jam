using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockQuestion : MonoBehaviour
{
    [SerializeField] private GameObject CurrentScene;
    [SerializeField] private GameObject NextScene;
    [SerializeField] private GameObject ClockPanel;



    void Start()
    {
        StartCoroutine(DelayStartShowClock());
    }

    IEnumerator DelayStartShowClock()
    {
        yield return new WaitForSeconds(13);
        ClockPanel.SetActive(true);
        
    }

    
}
