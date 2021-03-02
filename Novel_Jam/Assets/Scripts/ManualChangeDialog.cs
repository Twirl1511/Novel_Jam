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
    public GameObject Exit;
    public Image Background;
    private int number;
    private void Start()
    {
        number = 0;
        NewPhrase(); 
    }
   

    private void Update()
    {
        
        if (number<1)
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
