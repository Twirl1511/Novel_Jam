using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private GameObject CreatorsPanel;
    [SerializeField] private Button StartButton;
    [SerializeField] private GameObject HeckAndPaper;
    [SerializeField] private float seconds = 1.5f;
    public AudioSource HechAppearSound;
    public AudioSource MainSound;

    void Start()
    {
        
    }

    IEnumerator DelayStart(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("GameScene");
    }

    public void StartButtonClic()
    {
        HechAppearSound.Play();
        StartButton.GetComponent<Button>().enabled = false;
        HeckAndPaper.SetActive(true);
        MainSound.Stop();
        StartCoroutine(DelayStart(seconds));
    }

    public void ExittButtonClic()
    {
        Application.Quit();
    }

    public void CreatorsButtOnClic()
    {
        CreatorsPanel.SetActive(true);
    }
    public void BACKButtOnClic()
    {
        CreatorsPanel.SetActive(false);
    }
}
