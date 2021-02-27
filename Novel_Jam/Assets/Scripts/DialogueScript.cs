using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueScript : MonoBehaviour
{
    [SerializeField] private Text text;
    public PhraseAndTime[] HecksPhrases;
    
    private float timer;





    void Start()
    {
        timer = 0;
        StartCoroutine(DelayBtwPhrases());
    }

    private void Update()
    {
        
        
    }

    IEnumerator DelayBtwPhrases()
    {

        foreach(var e in HecksPhrases)
        {
            text.text = e.text;
            e.heckSprite.SetActive(true);
            yield return new WaitForSeconds(e.time);
            e.heckSprite.SetActive(false);
        }

        

    }

    
}
