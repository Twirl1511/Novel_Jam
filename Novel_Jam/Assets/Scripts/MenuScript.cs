using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private GameObject CreatorsPanel;
    [SerializeField] private Button StartButton;
    [SerializeField] private GameObject HeckAndPaper;
    [SerializeField] private float seconds = 3f;

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
        StartButton.GetComponent<Button>().enabled = false;
        HeckAndPaper.SetActive(true);
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
