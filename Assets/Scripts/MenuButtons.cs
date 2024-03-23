using UnityEngine;
using UnityEngine.SceneManagement;

//This script controls the buttons on the main menu

public class MenuButtons : MonoBehaviour
{

    public AudioSource ButtonClick;
    public GameObject ButtonSource;

    public void Start()
    {
        ButtonSource = GameObject.FindWithTag("ButtonSound");
        ButtonClick = ButtonSource.GetComponent<AudioSource>();
    }

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
        ButtonClick.Play();
    }
    public void ToSetup2() //if the player clicks the start game button
    {
        SceneManager.LoadScene("PlayerSetup"); //open the playersetup scene
        ButtonClick.Play();

    }

    public void StartGame() //if the player clicks the start game button
    {
        SceneManager.LoadScene("Tutorial"); //open the playersetup scene
        ButtonClick.Play();

    }
    public void OptionsMenu() //if the player clicks the options menu button
    {
        SceneManager.LoadScene("OptionsMenu"); //open the options menu scene
        ButtonClick.Play();

    }
    public void AboutMenu() //if the player clicks the options menu button
    {
        SceneManager.LoadScene("AboutMenu"); //open the options menu scene
        ButtonClick.Play();

    }
    public void Close() //if the player clicks the close button
    {
        Application.Quit(); //close the game
        ButtonClick.Play();

    }

    public void Day1Begin()
    {
        SceneManager.LoadScene("Day1");
        ButtonClick.Play();

    }

    public void ButtonNoise()
    {
        ButtonClick.Play();

    }

    public void BacktoMain()
    {
        SceneManager.LoadScene("MainMenu");
        ButtonClick.Play();

    }
}
