using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueScriptFinal : MonoBehaviour
{
    [SerializeField] private Text textDiagloge;
    [SerializeField] private Text textName;
    public PhraseAndTimeFinal[] HecksPhrases;
    
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
            textDiagloge.text = e.textDialogue;
            textName.text = e.textName;
            yield return new WaitForSeconds(e.time);
            
        }

        

    }

    
}
