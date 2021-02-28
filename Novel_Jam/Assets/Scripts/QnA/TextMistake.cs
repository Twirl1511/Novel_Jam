using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMistake : MonoBehaviour
{
    [SerializeField] private GameObject CurrentScene;
    [SerializeField] private GameObject NextScene;


    [SerializeField] private GameObject AnswerTrue;
    [SerializeField] private GameObject AnswerFalse;
    [SerializeField] private GameObject Board;
    [SerializeField] private Text TimerText;
    private int timerInt = 5;
    public float time;
    

    void Start()
    {
        StartCoroutine(DelayStartShowBoard());
    }

    IEnumerator DelayStartShowBoard()
    {
        yield return new WaitForSeconds(time);
        Board.SetActive(true);
        StartCoroutine(Timer());
    }

    IEnumerator SceneSwitcher()
    {
        yield return new WaitForSeconds(4);
        NextScene.SetActive(true);
        CurrentScene.SetActive(false);
    }

    IEnumerator Timer()
    {
        for(int i = 0; i < 10; i++)
        {
            
            yield return new WaitForSeconds(1);
            if (timerInt <= 0)
            {
                if (!AnswerTrue.activeSelf)
                {
                    FalseAnswerClick();
                }
                
            }
                
            timerInt--;
            TimerText.text = (timerInt).ToString();
            if (timerInt <= 0)
            {
                TimerText.text = "Не успеееел!";
            }
        }

        
    }


    public void RightAnswerClick()
    {
        AnswerTrue.SetActive(true);
        Board.SetActive(false);
        StartCoroutine(SceneSwitcher());
    }
    public void FalseAnswerClick()
    {
        AnswerFalse.SetActive(true);
        Board.SetActive(false);
        StartCoroutine(SceneSwitcher());
    }
}
