using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionA : MonoBehaviour
{
    [SerializeField] private GameObject CurrentScene;
    [SerializeField] private GameObject NextScene;

    [SerializeField] private GameObject Heck;
    [SerializeField] private GameObject HeckFalse;

    [SerializeField] private InputField inputFied;
    [SerializeField] private Text text;
    [SerializeField] private Text fake;
    [SerializeField] private GameObject InputField;
    //[SerializeField] private GameObject MainDialogue;
    [SerializeField] private GameObject ReactionRUS;
    [SerializeField] private GameObject ReactionENG;
    [SerializeField] private GameObject ReactionOTHER;
    private Color defaultColor;
    private Color transperentColor;
    void Start()
    {
        defaultColor = new Color(text.color.r, text.color.g, text.color.b, text.color.a);
        transperentColor = new Color(text.color.r, text.color.g, text.color.b, 0);
        StartCoroutine(InputFieldON());
    }

    IEnumerator InputFieldON()
    {
        yield return new WaitForSeconds(32);
        InputField.SetActive(true);
    }

    void Update()
    {
        
        /// eng
        if (text.text == "a")
        {
            fake.text = "ф";
            text.color = transperentColor;
        } 
        if (text.text == "A")
        {
            fake.text = "Ф";
            text.color = transperentColor;
        }


        // rus
        if (text.text == "а")
        {
            fake.text = "f";
            text.color = transperentColor;
        }
        if (text.text == "А")
        {
            fake.text = "F";
            text.color = transperentColor;
        }



        if (text.text == "")
        {
            fake.text = "";
            text.color = defaultColor;
        }
        else
        {
            inputFied.enabled = false;
            if (_answerFlag)
            {
                Answer();
                StartCoroutine(SceneSwitcher());
            }
            
        }

    }

    IEnumerator SceneSwitcher()
    {
        yield return new WaitForSeconds(8);
        NextScene.SetActive(true);
        CurrentScene.SetActive(false);
    }



    private bool _answerFlag = true;
    public void Answer()
    {
        
        if (text.text.ToLower() == "a" || text.text.ToLower() == "ф")
        {
            Debug.Log(" eng A");
            
            ReactionENG.SetActive(true);
            StaticResults.KeyboardAnswer = "eng";
        }
        else if (text.text.ToLower() == "а" || text.text.ToLower() == "f")
        {
            Debug.Log(" рус A");
            
            ReactionRUS.SetActive(true);
            StaticResults.KeyboardAnswer = "rus";
        }
        else
        {
            Debug.Log(" вообще другая буква");
            
            ReactionOTHER.SetActive(true);
            StaticResults.KeyboardAnswer = "other";
        }

        _answerFlag = false;
        Heck.SetActive(false);
        HeckFalse.SetActive(true);
    }
}
