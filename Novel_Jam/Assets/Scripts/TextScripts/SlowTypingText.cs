using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowTypingText : MonoBehaviour
{
    public string fullText;
    [SerializeField] private Text text;
    [SerializeField] private float delay = .1f;
    // Start is called before the first frame update
    void Start()
    {
        fullText = text.text;
        StartCoroutine(TypeTexrWithDelay());
    }

    IEnumerator TypeTexrWithDelay()
    {
        float timeDelay;
        for(int i = 0; i < fullText.Length; i++)
        {
            int randomDelay = Random.Range(3,6);
            int randomModifier = Random.Range(2,5);
            
            if (i % randomDelay == 0)
            {
                timeDelay = delay * randomModifier;
            }
            else
            {
                timeDelay = delay;
            }
            yield return new WaitForSeconds(timeDelay);
            text.text = fullText.Substring(0, i + 1);
        }
    }
}
