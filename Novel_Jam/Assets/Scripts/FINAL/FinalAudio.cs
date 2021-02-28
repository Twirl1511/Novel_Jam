using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalAudio : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip Ringing;
    public AudioClip EndCall;
    public AudioClip KeySound;
    void Start()
    {
        StartCoroutine(DelayStart(9));
        StartCoroutine(Delay(EndCall, 37));
        StartCoroutine(Delay(KeySound, 40));
    }

    IEnumerator DelayStart(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        PlayRinging();
    }

    public void PlayRinging()
    {
        StartCoroutine(Delay(Ringing, 0));
    }

    IEnumerator Delay(AudioClip audioClip, float time)
    {
        
        yield return new WaitForSeconds(time);
        AudioSource.clip = audioClip;
        AudioSource.Play();
        

    }
}
