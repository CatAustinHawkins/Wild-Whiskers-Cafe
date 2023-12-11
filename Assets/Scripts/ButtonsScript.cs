using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{

    public GameObject StartDayWindow;

    public GameObject Tutorials;

    public void StartGame()
    {
        StartDayWindow.SetActive(false);
        Tutorials.SetActive(true);
    }

    public void FinishedDay1()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
