using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClockHands : MonoBehaviour
{
    [SerializeField] private GameObject AnswerTrue;
    [SerializeField] private GameObject AnswerFalse;


    [SerializeField] private GameObject CurrentScene;
    [SerializeField] private GameObject NextScene;

    [SerializeField] private Button[] digits;
    [SerializeField] private GameObject hourHand;
    private bool flag = false;

    IEnumerator SceneSwitcher()
    {
        yield return new WaitForSeconds(4);
        NextScene.SetActive(true);
        CurrentScene.SetActive(false);
    }

    public void CheckAnswer()
    {
        if (flag)
        {
            AnswerTrue.SetActive(true);
        }
        else
        {
            AnswerFalse.SetActive(true);
        }
        StartCoroutine(SceneSwitcher());
    }

    public void click_1()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -32);
        flag = false;
    }
    public void click_2()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -65);
        flag = false;
    }
    public void click_3()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -92);
        flag = false;
    }
    public void click_4()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -118);
        flag = false;
    }
    public void click_5()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -151);
        flag = false;
    }
    public void click_6()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -181);
        flag = false;
    }
    public void click_7()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -209);
        flag = false;
    }
    public void click_8()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -245);
        flag = true;
        Debug.Log("true answer");
    }
    public void click_9()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -274);
        flag = false;
    }
    public void click_10()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -300);
        flag = false;
    }
    public void click_11()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -332);
        flag = false;
    }
    public void click_12()
    {
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -4);
        flag = false;
    }
}
