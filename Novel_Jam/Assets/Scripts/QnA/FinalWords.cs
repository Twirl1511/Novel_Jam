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
    public Text text;


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

    private string da = "!";
    public void AnswerButton()
    {
        Debug.Log(counter);
        counter++;
        try
        {
            for(int i = 0; i< counter; i++)
            {
                da += "!";
            }
            HecksYES[counter - 1].SetActive(true);
            text.text = "ДА"+da;
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
