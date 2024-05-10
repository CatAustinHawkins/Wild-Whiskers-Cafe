using UnityEngine;
using UnityEngine.SceneManagement;

//Unused Script
//Would have been used on the main menu, to change which day gets opened.
public class MainMenuSave : MonoBehaviour
{
    public int PlayerLevel; //the day the player has gotten to
    //PlayerLevel 0 = Tutorial
    //PlayerLevel 1 = Day 1
    //PlayerLevel 2 = Day 2
    //PlayerLevel 3 = Day 3
    //PlayerLevel 4 = Day 4
    //PlayerLevel 5 = Day 5

    public GameObject StartButton; //the Start button on the Main Menu
    public GameObject ContinueButton; //the Continue button on the Main Menu

    // Start is called before the first frame update
    public void Start()
    {
        StartButton = GameObject.FindWithTag("StartButton"); //find the start button via a tag
        ContinueButton = GameObject.FindWithTag("ContinueButton"); //find the continue button via a tag


        Load(); //load any save data


        if(PlayerLevel > 0 || PlayerLevel == 1) //if the player has passed the tutorial
        {
            StartButton.SetActive(false); //disable the start button
            ContinueButton.SetActive(true); //enable the continue button
        }

        if(PlayerLevel > 5 || PlayerLevel == 6) //if the player has passed Day 5
        {
            StartButton.SetActive(true); //enable the start button
            ContinueButton.SetActive(false); //disable the continue button
        }
    }

    public void ContinueGame() //on the continue button
    {
        if(PlayerLevel == 1)
        {
            SceneManager.LoadScene("Day1"); //load Day 1
        }

        if (PlayerLevel == 2)
        {
            SceneManager.LoadScene("Day2"); //load Day 2
        }

        if (PlayerLevel == 3)
        {
            SceneManager.LoadScene("Day3"); //load Day 3
        }

        if (PlayerLevel == 4)
        {
            SceneManager.LoadScene("Day4"); //load Day 4
        }

        if (PlayerLevel == 5)
        {
            SceneManager.LoadScene("Day5"); //load Day 5
        }

        if(PlayerLevel > 6)
        {
            SceneManager.LoadScene("PlayerSetup"); //load Player Setup - going back to the tutorial
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("PlayerLevel", PlayerLevel); //save the player's current level
    }

    public void Load()
    {
        PlayerLevel = PlayerPrefs.GetInt("PlayerLevel"); //load the players current level
    }
}
