using UnityEngine;
using UnityEngine.SceneManagement;

//This script controls the buttons on the main menu

public class MenuButtons : MonoBehaviour
{

    public void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Escape)) //if the player presses escape
        {
            Application.Quit(); //close the game
        }
    }

    public void Start() //when the game starts
    {
        Screen.SetResolution(1600, 900, false); //set the games resolution to 1600,900 and the fullscreen value to false

    }
    public void StartGame() //if the player clicks the start game button
    {
        SceneManager.LoadScene("PlayerSetup"); //open the playersetup scene
    }

    public void OptionsMenu() //if the player clicks the options menu button
    {
        SceneManager.LoadScene("OptionsMenu"); //open the options menu scene
    }

    public void Close() //if the player clicks the close button
    {
        Application.Quit(); //close the game
    }
}
