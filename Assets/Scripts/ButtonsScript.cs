using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{

    public CustomerTest customertestscript;
    public GameObject StartDayWindow;

    public void StartGame()
    {
        customertestscript.DayBegin = true;
        StartDayWindow.SetActive(false);
    }

    public void FinishedDay1()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
