using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    public void Start()
    {
        Screen.SetResolution(1600, 900, false);

    }
    public void StartGame()
    {
        SceneManager.LoadScene("PlayerSetup");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void Close()
    {
        Application.Quit();
    }
    // - Tom
}
