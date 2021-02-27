using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalWords : MonoBehaviour
{
    [SerializeField] private GameObject AnswerTRUE;
    [SerializeField] private GameObject AnswerFALSE;
    [SerializeField] private InputField firstWord;
    [SerializeField] private InputField secondWord;
    [SerializeField] private InputField thirdWord;
    public string[] firstWordsArray;
    public string[] secondWordsArray;
    public string[] thirdWordsArray;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnswerButton()
    {
        if (IsAnswerCorrect())
        {
            Debug.Log("Nice answer");
            StaticResults.FinalWordsAnswer = true;
            AnswerTRUE.SetActive(true);
        }
        else
        {
            Debug.Log("Bad answer");
            StaticResults.FinalWordsAnswer = false;
            AnswerFALSE.SetActive(true);
        }
    }

    private bool FirstWordContained()
    {
        foreach(var e in firstWordsArray)
        {
            if(e == firstWord.text.ToLower().Trim() && e != "")
            {
                return true;
            }
        }
        return false;
    }

    private bool SecondWordContained()
    {
        foreach (var e in secondWordsArray)
        {
            if (e == secondWord.text.ToLower() && e != "")
            {
                return true;
            }
        }
        return false;
    }

    private bool ThirdWordContained()
    {
        foreach (var e in thirdWordsArray)
        {
            if (e == thirdWord.text.ToLower() && e != "")
            {
                return true;
            }
        }
        return false;
    }

    private bool IsAnswerCorrect()
    {
        if(FirstWordContained() && SecondWordContained() && ThirdWordContained())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
