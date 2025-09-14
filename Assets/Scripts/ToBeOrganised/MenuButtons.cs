using UnityEngine;
using UnityEngine.SceneManagement;

//This script controls the buttons on the main menu
public class MenuButtons : MonoBehaviour
{
    public AudioSource ButtonClick; //button click audio

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape)) //if the player presses escape, when on Options, Controls, Player Setup or Select Screen
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void MainMenuOpen() //Pressing Back on Controls or Options Menu takes player to main menu
    {
        SceneManager.LoadScene("MainMenu"); //Player can return to the main menu
        ButtonClick.Play();
    }

    public void OptionsMenuOpen()
    {
        SceneManager.LoadScene("OptionsMenu");
        ButtonClick.Play();
    }

    public void ControlsMenuOpen()
    {
        SceneManager.LoadScene("ControlsMenu");
        ButtonClick.Play();
    }

    public void SelectScreenOpen()
    {
        SceneManager.LoadScene("SelectScreen");
        ButtonClick.Play();
    }

    public void PlayerSetupOpen()
    {
        SceneManager.LoadScene("PlayerSetup");
        ButtonClick.Play();
    }

    public void FoodTruckOpen()
    {
        SceneManager.LoadScene("LoadingMenu_FT");
        ButtonClick.Play();
    }

    public void StoryModeOpen()
    {
        SceneManager.LoadScene("LoadingMenu_ST");
        ButtonClick.Play();
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
