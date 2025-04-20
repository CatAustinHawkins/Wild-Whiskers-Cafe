using UnityEngine;
using UnityEngine.SceneManagement;

//This script is used for the Start Game and Finish Day 1 buttons

public class ButtonsScript : MonoBehaviour
{

    public GameObject StartDayWindow; //The UI screen that appears when the player starts the game

    public GameObject Tutorials; //The tutorial UI screen

    public void StartGame() //The Start Game button
    {
        StartDayWindow.SetActive(false); //Disable the UI screen
        Tutorials.SetActive(true); //Enable the UI screen, starting the tutorial
    }

    public void MainMenuOpen() //When Day 1 is finished
    {
        SceneManager.LoadScene("MainMenu"); //Player can return to the main menu
    }

    public void Testing()
    {
        Debug.Log("Test");
    }
}
