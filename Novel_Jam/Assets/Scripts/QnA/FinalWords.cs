using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalWords : MonoBehaviour
{
 
    [SerializeField] private GameObject[] HecksYES;
    [SerializeField] private GameObject FinalWord;
    [SerializeField] private GameObject FinalTRUE;


    private int counter = 0;

   

    IEnumerator DelayFinalScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("EndGame");
    }
    private void Start()
    {
        StartCoroutine(DelayFinelWord());
    }
    IEnumerator DelayFinelWord()
    {
        yield return new WaitForSeconds(16);
        FinalWord.SetActive(true);
    }
    public void AnswerButton()
    {
        counter++;
        try
        {
            HecksYES[counter - 1].SetActive(true);
        }
        catch
        {

        }
        
        if (counter >= 4)
        {
            FinalTRUE.SetActive(true);
            StartCoroutine(DelayFinalScene());
        }
    }

    
}
