using UnityEngine;
using UnityEngine.SceneManagement;

//This script is used on buttons that take the player to a different scene


public class ButtonsScript : MonoBehaviour
{

    public void MainMenuOpen() //When Day 1 is finished
    {
        SceneManager.LoadScene("MainMenu"); //Player can return to the main menu
    }

    public void FoodTruckOpen()
    {
        SceneManager.LoadScene("LoadingMenu_FT");
    }

    public void StoryModeOpen()
    {
        SceneManager.LoadScene("LoadingMenu_ST");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
