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


    public void ToSetup1() //if the player clicks the start game button
    {
        SceneManager.LoadScene("Setup"); //open the playersetup scene
    }
    public void ToSetup2() //if the player clicks the start game button
    {
        SceneManager.LoadScene("PlayerSetup"); //open the playersetup scene
    }

    public void StartGame() //if the player clicks the start game button
    {
        SceneManager.LoadScene("Tutorial"); //open the playersetup scene
    }
    public void OptionsMenu() //if the player clicks the options menu button
    {
        SceneManager.LoadScene("OptionsMenu"); //open the options menu scene
    }
    public void AboutMenu() //if the player clicks the options menu button
    {
        SceneManager.LoadScene("AboutMenu"); //open the options menu scene
    }
    public void Close() //if the player clicks the close button
    {
        Application.Quit(); //close the game
    }

    public void BacktoMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
