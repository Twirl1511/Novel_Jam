using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManualChangeDialog : MonoBehaviour
{
    public PhraseAndTimeFinal[] DialogueArray;
    [Header("Atributes")]
    public Text DialogueText;
    public Text NameText;
    public AudioSource audioSource;
    public GameObject BackButton;
    
    
    public GameObject ForwardButton;
    public GameObject Exit;
    public Image Background;
    private int number;
   
    private void Start()
    {
        
        number = -1;
        ForwardButton.SetActive(false);
        BackButton.SetActive(false);

        StartCoroutine(FirstSteps());
        
        StartCoroutine(StartmanualScene());
    }
   

    IEnumerator FirstSteps()
    {
        for(int i = 0; i < 5; i++)
        {
            Forward();
            yield return new WaitForSeconds(2);
        }
    }
    

    IEnumerator StartmanualScene()
    {
        yield return new WaitForSeconds(8);
        NewPhrase();
        ForwardButton.SetActive(true);
    }


    private void Update()
    {
        
        if (number<5)
        {
            BackButton.SetActive(false);
        }
        else
        {
            BackButton.SetActive(true);
        }
    }
    

    
    public void Forward()
    {
        number++;
        if (number >= DialogueArray.Length)
        {
            Exit.SetActive(true);
            number--;
        }
        NewPhrase();
        
    }

    public void Back()
    {
        Exit.SetActive(false);
        number--;
        if (number < 0) number = 0;
        NewPhrase();
    }

    public void NewPhrase()
    {
        DialogueText.text = DialogueArray[number].textDialogue;
        NameText.text = DialogueArray[number].textName;
        audioSource.clip = DialogueArray[number].audioClip;
        audioSource.Play();
        Background.sprite = DialogueArray[number].backgroundSprite;
    }
}
