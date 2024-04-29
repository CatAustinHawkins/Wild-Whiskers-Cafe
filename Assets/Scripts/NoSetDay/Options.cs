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
    public Slider MusicSlider;

    public int width = 1600; //default resolution width
    public int height = 900; //default resolution height

    public Sprite Tick;
    public Sprite Cross;

    public Image FullScreenButtonImage;
    public Image EasyModeButtonImage;

    public GameObject BackgroundMusicGO;
    public AudioSource BackgroundMusic;

    public int FullScreenValue;

    public void Start()
    {
        BackgroundMusicGO = GameObject.FindWithTag("BackgroundMusic");
        BackgroundMusic = BackgroundMusicGO.GetComponent<AudioSource>();

        Load();
    }

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
        Save();
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
        Save();
    }

    public void MusicVolume()
    {
        BackgroundMusic.volume = MusicSlider.value;
        Save();
    }

    //On the Volume Slider 
    public void ChangeVolume()
    {
        AudioListener.volume = VolumeSlider.value; //change the volume of the overall audio
        Save();
    }

    public void Finished()
    {
        SceneManager.LoadScene("MainMenu"); //load the main menu
        Screen.SetResolution(width, height, FullScreenOn);
        Save();
    }

    public void SetQuality()
    {
        QualitySettings.SetQualityLevel(DropdownMenuQuality.value);
        Save();
    }


    public void Save()
    {
        PlayerPrefs.SetFloat("OverallVolume", VolumeSlider.value);
        //PlayerPrefs.SetFloat("MusicVolume", MusicSlider.value);
        PlayerPrefs.SetInt("ScreenWidth", width);
        PlayerPrefs.SetInt("ScreenHeight", height);
        PlayerPrefs.SetInt("FullScreen", FullScreenValue);
        PlayerPrefs.SetInt("GraphicsSetting", DropdownMenu.value);
    }

    public void Load()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("OverallVolume");
        //MusicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        width = PlayerPrefs.GetInt("ScreenWidth");
        height = PlayerPrefs.GetInt("ScreenHeight");
        FullScreenValue = PlayerPrefs.GetInt("FullScreen");
        DropdownMenu.value = PlayerPrefs.GetInt("GraphicsSetting");
    }
}
