using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalAudio : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip Ringing;
    void Start()
    {
        StartCoroutine(DelayStart(9));
    }

    IEnumerator DelayStart(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        PlayRinging();
    }

    public void PlayRinging()
    {
        StartCoroutine(Delay(Ringing, Ringing.length));
    }
    IEnumerator Delay(AudioClip audioClip, float time)
    {
        AudioSource.clip = audioClip;
           
        AudioSource.Play();
        yield return new WaitForSeconds(time);

    }
}
