using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalManager : MonoBehaviour
{
    [SerializeField] private GameObject[] backgrounds;
    [SerializeField] private GameObject END;
    void Start()
    {
        backgrounds[0].SetActive(true);
        StartCoroutine(DelayNextBG(backgrounds[1],5));
        StartCoroutine(DelayNextBG(backgrounds[2], 9));
        StartCoroutine(DelayNextBG(backgrounds[3], 37));
        StartCoroutine(DelayNextBG(backgrounds[4], 40));
        StartCoroutine(DelayNextBG(END, 47));
    }

    IEnumerator DelayNextBG(GameObject bg, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        bg.SetActive(true);
    }
    void Update()
    {
        
    }
}
