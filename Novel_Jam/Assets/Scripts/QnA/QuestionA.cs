using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionA : MonoBehaviour
{
    [SerializeField] private InputField inputFied;
    [SerializeField] private Text text;
    [SerializeField] private Text fake;
    [SerializeField] private GameObject ReactionRUS;
    [SerializeField] private GameObject ReactionENG;
    [SerializeField] private GameObject ReactionOTHER;
    private Color defaultColor;
    private Color transperentColor;
    void Start()
    {
        defaultColor = new Color(text.color.r, text.color.g, text.color.b, text.color.a);
        transperentColor = new Color(text.color.r, text.color.g, text.color.b, 0);
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
            }
            
        }

        

    }


    private bool _answerFlag = true;
    public void Answer()
    {
        
        if (text.text.ToLower() == "a")
        {
            Debug.Log(" eng A");
            StaticResults.KeyboardAnswer = "eng";
        }
        else if (text.text.ToLower() == "а")
        {
            Debug.Log(" рус A");
            StaticResults.KeyboardAnswer = "rus";
        }
        else
        {
            Debug.Log(" вообще другая буква");
            StaticResults.KeyboardAnswer = "other";
        }

        _answerFlag = false;
    }
}
