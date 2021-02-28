using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoButtons : MonoBehaviour
{
    [SerializeField] private GameObject CurrentScene;
    [SerializeField] private GameObject NextScene;

    [SerializeField] private GameObject Heck;
    [SerializeField] private GameObject HeckTrue;
    [SerializeField] private GameObject HeckFalse;

    [SerializeField] private GameObject PianoButtonsFULL;

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

    
    IEnumerator DelayShowPiano()
    {
        yield return new WaitForSeconds(14);
        PianoButtonsFULL.SetActive(true);
    }

    IEnumerator SceneSwitcher()
    {
        yield return new WaitForSeconds(5);
        NextScene.SetActive(true);
        CurrentScene.SetActive(false); 
    }
    private void Start()
    {
        StartCoroutine(DelayShowPiano());
    }

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
        StartCoroutine(SceneSwitcher());
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
        StartCoroutine(SceneSwitcher());
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
        StartCoroutine(SceneSwitcher());
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
        StartCoroutine(SceneSwitcher());
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
        StartCoroutine(SceneSwitcher());
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
        StartCoroutine(SceneSwitcher());
    }
}
