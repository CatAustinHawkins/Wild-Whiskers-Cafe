using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

//This script is for the options menu

public class Options : MonoBehaviour
{

    public TMP_Dropdown DropdownMenu; //the resolution drop down menu
    public TMP_Dropdown DropdownMenuQuality; //the resolution drop down menu

    public bool EasyModeOn; //easy mode bool

    public bool FullScreenOn; //fullscreen bool

    public Slider VolumeSlider; //volume slider 

    public int width = 1600; //default resolution width
    public int height = 900; //default resolution height

    public Sprite Tick;
    public Sprite Cross;

    public Image FullScreenButtonImage;
    public Image EasyModeButtonImage;


    public void DropdownMenuChanged()
    {
        //how the dropdown menu works
        if(DropdownMenu.value == 0)
        {
            Screen.SetResolution(1600, 900, FullScreenOn);
            width = 1600;
            height = 900;
        }

        if (DropdownMenu.value == 1)
        {
            Screen.SetResolution(3840, 2160, FullScreenOn);
            width = 3840;
            height = 2160;
        }

        if (DropdownMenu.value == 2)
        {
            Screen.SetResolution(2560, 1440, FullScreenOn);
            width = 1440;
            height = 2560;
        }

        if (DropdownMenu.value == 3)
        {
            Screen.SetResolution(1920, 1080, FullScreenOn);
            width = 1920;
            height = 1080;
        }

        if (DropdownMenu.value == 4)
        {
            Screen.SetResolution(1280, 720, FullScreenOn);
            width = 1280;
            height = 720;
        }
    }

    public void FullScreenButton() //turn fullscreen mode on and off
    {

        if (!FullScreenOn)
        {
            FullScreenOn = true;
            Screen.SetResolution(width, height, true);
            FullScreenButtonImage.sprite = Tick;

        }
        else
        {
            FullScreenOn = false;
            Screen.SetResolution(width, height, false);
            FullScreenButtonImage.sprite = Cross;
        }

    }

    public void EasyMode() //turn easy mode on and off (currently doesn't do anything)
    {
        if(!EasyModeOn)
        {
            EasyModeOn = true;
            EasyModeButtonImage.sprite = Tick;
        }
        else
        {
            EasyModeOn = false;
            EasyModeButtonImage.sprite = Cross;
        }
    }

    //On the Volume Slider 
    public void ChangeVolume()
    {
        AudioListener.volume = VolumeSlider.value; //change the volume of the overall audio
    }

    public void Finished()
    {
        SceneManager.LoadScene("MainMenu"); //load the main menu
    }

    public void SetQuality()
    {
        QualitySettings.SetQualityLevel(DropdownMenuQuality.value);
    }
}
