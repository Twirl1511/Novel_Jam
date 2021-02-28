using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    [SerializeField] private GameObject CurrentScene;
    [SerializeField] private GameObject NextScene;

    public AudioSource PizzaAudioSource;
    [SerializeField] private GameObject PizzaBox;


    public int pieces;
    void Start()
    {
        pieces = 8;
        StartCoroutine(DelayStartShowBoard());
    }


    void Update()
    {

        

    }
    IEnumerator DelayStartShowBoard()
    {
        yield return new WaitForSeconds(4);
        PizzaBox.SetActive(true);
        
    }

    IEnumerator SceneSwitcher()
    {
        yield return new WaitForSeconds(2);
        PizzaBox.SetActive(false);
        NextScene.SetActive(true);
        CurrentScene.SetActive(false);
    }

    
    public void EatPizza()
    {
        PizzaAudioSource.Play();
        pieces--;
        if (pieces <= 0)
        {
            StartCoroutine(SceneSwitcher());
        }
        
    }
}
