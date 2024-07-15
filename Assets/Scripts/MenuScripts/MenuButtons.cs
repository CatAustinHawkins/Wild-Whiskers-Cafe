using UnityEngine;
using UnityEngine.SceneManagement;

//This script controls the buttons on the main menu
public class MenuButtons : MonoBehaviour
{
    public AudioSource ButtonClick; //button click audio
    public GameObject ButtonSource; //gameobject with the button click audio attached

    public void Start()
    {
        ButtonSource = GameObject.FindWithTag("ButtonSound"); //locate buttonsource gameobject
        ButtonClick = ButtonSource.GetComponent<AudioSource>(); //locate audio source component 
    }

    public void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Escape)) //if the player presses escape
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void ToSetup1() //if the player clicks the start game button
    {
        SceneManager.LoadScene("Setup"); //open the playersetup scene
        ButtonClick.Play(); //play button click noise
    }
    public void ToSetup2() //if the player clicks the start game button
    {
        SceneManager.LoadScene("PlayerSetup"); //open the playersetup scene
        ButtonClick.Play(); //play button click noise
    }

    public void StartGame() //if the player clicks the start game button
    {
        SceneManager.LoadScene("LoadingMenu"); //open the playersetup scene
        ButtonClick.Play(); //play button click noise
    }
    public void OptionsMenu() //if the player clicks the options menu button
    {
        SceneManager.LoadScene("OptionsMenu"); //open the options menu scene
        ButtonClick.Play(); //play button click noise
    }
    public void AboutMenu() //if the player clicks the options menu button
    {
        SceneManager.LoadScene("AboutMenu"); //open the options menu scene
        ButtonClick.Play(); //play button click noise
    }
    public void Close() //if the player clicks the close button
    {
        Application.Quit(); //close the game
        ButtonClick.Play(); //play button click noise
    }

    public void BacktoMain() //back to main menu
    {
        SceneManager.LoadScene("MainMenu"); //load main menu scene
        ButtonClick.Play(); //play button click noise
    }
}
