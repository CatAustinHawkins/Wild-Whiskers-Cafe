using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuSave : MonoBehaviour
{
    public int Testing = 0;

    public int PlayerLevel;

    public GameObject StartButton;
    public GameObject ContinueButton;

    // Start is called before the first frame update
    void Start()
    {
        if(Testing == 0)
        {
            Screen.SetResolution(1600, 900, false);
            Testing++;
        }

        Load();


        if(PlayerLevel > 0 || PlayerLevel == 1)
        {
            StartButton.SetActive(false);
            ContinueButton.SetActive(true);
        }

        if(PlayerLevel > 5 || PlayerLevel == 6)
        {
            StartButton.SetActive(true);
            ContinueButton.SetActive(false);
        }

    }

    public void Update()
    {
        if (Testing == 0)
        {
            Screen.SetResolution(1600, 900, false);
            Testing++;
        }
    }

    public void ContinueGame()
    {
        if(PlayerLevel == 1)
        {
            SceneManager.LoadScene("Day1");
        }

        if (PlayerLevel == 2)
        {
            SceneManager.LoadScene("Day2");
        }

        if (PlayerLevel == 3)
        {
            SceneManager.LoadScene("Day3");
        }

        if (PlayerLevel == 4)
        {
            SceneManager.LoadScene("Day4");
        }

        if (PlayerLevel == 5)
        {
            SceneManager.LoadScene("Day5");
        }

        if(PlayerLevel > 6)
        {
            SceneManager.LoadScene("PlayerSetup");
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("PlayerLevel", PlayerLevel);
    }

    public void Load()
    {
        PlayerLevel = PlayerPrefs.GetInt("PlayerLevel");
    }

}
