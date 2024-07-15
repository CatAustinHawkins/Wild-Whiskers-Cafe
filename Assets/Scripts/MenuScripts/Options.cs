using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

//This script is for the options menu

public class Options : MonoBehaviour
{

    public TMP_Dropdown DropdownMenu; //the resolution drop down menu
    public TMP_Dropdown DropdownMenuQuality; //the resolution drop down menu

    public bool FullScreenOn; //fullscreen bool

    public Slider VolumeSlider; //volume slider 

    public int width = 1600; //default resolution width
    public int height = 900; //default resolution height

    public Sprite Tick; //tick sprite
    public Sprite Cross; //cross sprite

    public Image FullScreenButtonImage; //fullscreen button background

    public int FullScreenValue; 
    //whether the full screen is enabled or not, an int instead of a bool for saving

    public void Start()
    {
      //  Load(); //load any save data
    }

    public void DropdownMenuChanged() //Screen resolution dropdown
    {
        //how the dropdown menu works
        if(DropdownMenu.value == 0) //1600x900
        {
            Screen.SetResolution(1600, 900, FullScreenOn); 
            width = 1600;
            height = 900;
        }

        if (DropdownMenu.value == 1) //3840x1440
        {
            Screen.SetResolution(3840, 2160, FullScreenOn);
            width = 3840;
            height = 2160;
        }

        if (DropdownMenu.value == 2) //2560x1440
        {
            Screen.SetResolution(2560, 1440, FullScreenOn);
            width = 1440;
            height = 2560;
        }

        if (DropdownMenu.value == 3) //1920x1080
        {
            Screen.SetResolution(1920, 1080, FullScreenOn);
            width = 1920;
            height = 1080;
        }

        if (DropdownMenu.value == 4) //1280x720
        {
            Screen.SetResolution(1280, 720, FullScreenOn); //set the resolution
            width = 1280; 
            height = 720; 
        }

        Save(); //save the resolution settings
    }

    public void FullScreenButton() //turn fullscreen mode on and off
    {

        if (!FullScreenOn) //if full screen isnt on
        {
            FullScreenOn = true; //set it to true
            Screen.SetResolution(width, height, true); //enable fullscreen
            FullScreenButtonImage.sprite = Tick; //set the button image to the tick

        }
        else
        {
            FullScreenOn = false; //set it to false
            Screen.SetResolution(width, height, false); //enable fullscreen
            FullScreenButtonImage.sprite = Cross; //set the button image to the cross
        }
        Save(); //save the fullscreen settings
    }


    //On the Volume Slider 
    public void ChangeVolume()
    {
        AudioListener.volume = VolumeSlider.value; //change the volume of the overall audio
        Save(); //save the volume settings
    }

    public void Finished() //on the finished button
    {
        SceneManager.LoadScene("MainMenu"); //load the main menu
        Save(); //save all the settings
    }

    public void SetQuality() //set the quality of the game based on what the player chooses
    {
        QualitySettings.SetQualityLevel(DropdownMenuQuality.value);
        //value 0 = very low
        //value 1 = low
        //value 2 = medium
        //value 3 = high
        //value 4 = very high
        //value 5 = ultra
        Save(); //save the quality settings
    }

    public void Save() //save the options data
    {
        PlayerPrefs.SetFloat("OverallVolume", VolumeSlider.value); //save the overall volume value
        PlayerPrefs.SetInt("ScreenWidth", width); //save the screen width value
        PlayerPrefs.SetInt("ScreenHeight", height); //save the screen height value
        PlayerPrefs.SetInt("FullScreen", FullScreenValue); //save the fullscreen value
        PlayerPrefs.SetInt("GraphicsSetting", DropdownMenu.value); //save the graphics setting value
    }
    /*
    public void Load() //load the options data
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("OverallVolume"); //load the overall volume value
        width = PlayerPrefs.GetInt("ScreenWidth"); //load the screen width value
        height = PlayerPrefs.GetInt("ScreenHeight"); //load the screen height value
        FullScreenValue = PlayerPrefs.GetInt("FullScreen"); //load the fullscreen value
        DropdownMenu.value = PlayerPrefs.GetInt("GraphicsSetting"); //load the graphics setting value
    }
    */
}
