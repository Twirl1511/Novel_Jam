using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoButtons : MonoBehaviour
{

    [SerializeField] private GameObject Heck;
    [SerializeField] private GameObject HeckTrue;
    [SerializeField] private GameObject HeckFalse;


    [SerializeField] private GameObject FullPiano;
    [SerializeField] private GameObject PartPiano;

    [SerializeField] private GameObject TrueAnswer;
    [SerializeField] private GameObject FalseAnswer;



    public AudioClip SolAudio;
    public AudioClip SolDiezAudio;
    public AudioClip LyaAudio;
    public AudioClip LyaDiezAudio;
    public AudioClip SiAudio;
    public AudioClip DoAudio;
    public AudioSource audioSource;


    public void Sol()
    {
        Debug.Log("Sol");
        FullPiano.SetActive(true);
        PartPiano.SetActive(false);
        FalseAnswer.SetActive(true);
        audioSource.clip = SolAudio;
        audioSource.Play();
        StaticResults.PianoAnswer = false;
        HeckFalse.SetActive(true);
        Heck.SetActive(false);
    }
    public void SolDiez()
    {
        Debug.Log("SolDiez");
        FullPiano.SetActive(true);
        PartPiano.SetActive(false);
        FalseAnswer.SetActive(true);
        audioSource.clip = SolDiezAudio;
        audioSource.Play();
        StaticResults.PianoAnswer = false;
        HeckFalse.SetActive(true);
        Heck.SetActive(false);
    }
    public void Lya()
    {
        Debug.Log("Lya");
        FullPiano.SetActive(true);
        PartPiano.SetActive(false);
        FalseAnswer.SetActive(true);
        audioSource.clip = LyaAudio;
        audioSource.Play();
        StaticResults.PianoAnswer = false;
        HeckFalse.SetActive(true);
        Heck.SetActive(false);
    }
    public void LyaDiez()
    {
        Debug.Log("LyaDiez");
        FullPiano.SetActive(true);
        PartPiano.SetActive(false);
        FalseAnswer.SetActive(true);
        audioSource.clip = LyaDiezAudio;
        audioSource.Play();
        StaticResults.PianoAnswer = false;
        HeckFalse.SetActive(true);
        Heck.SetActive(false);
    }
    public void Si()
    {
        Debug.Log("Si");
        FullPiano.SetActive(true);
        PartPiano.SetActive(false);
        FalseAnswer.SetActive(true);
        audioSource.clip = SiAudio;
        audioSource.Play();
        StaticResults.PianoAnswer = false;
        HeckFalse.SetActive(true);
        Heck.SetActive(false);
    }
    public void Do()
    {
        Debug.Log("Do");
        FullPiano.SetActive(true);
        PartPiano.SetActive(false);
        TrueAnswer.SetActive(true);
        audioSource.clip = DoAudio;
        audioSource.Play();
        StaticResults.PianoAnswer = true;
        HeckTrue.SetActive(true);
        Heck.SetActive(false);
    }
}
