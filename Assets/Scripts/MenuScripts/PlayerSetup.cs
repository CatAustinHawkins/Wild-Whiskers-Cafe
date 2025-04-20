using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This script controls the player setup
public class PlayerSetup : MonoBehaviour
{
    public TMP_InputField NameEntry; //the input field the player can put their name into

    public string PlayerName = "Player"; //default name is Player

    //Different player images
    public Image AvatarSelectImage; //AvatarSelectImage
    public Sprite[] ChoiceSelected; //Animal
    public int CurrentChoice; //the current choice

    public int OutfitChoice;

    public Sprite[] Cat1OutfitSelected; //Outfit

    public Sprite[] Cat2OutfitSelected; //Outfit

    public Sprite[] Cat3OutfitSelected; //Outfit

    public Sprite[] Cat4OutfitSelected; //Outfit

    public Sprite[] Dog1OutfitSelected; //Outfit

    public Sprite[] Dog2OutfitSelected; //Outfit

    public Sprite[] Dog3OutfitSelected; //Outfit

    public Sprite[] Dog4OutfitSelected; //Outfit


    //which choice the player chooses
    public bool Choice1Selected; //Cat Avatar 1
    public bool Choice2Selected; //Cat Avatar 2
    public bool Choice3Selected; //Cat Avatar 3
    public bool Choice4Selected; //Cat Avatar 4
    public bool Choice5Selected; //Dog Avatar 1
    public bool Choice6Selected; //Dog Avatar 2
    public bool Choice7Selected; //Dog Avatar 3
    public bool Choice8Selected; //Dog Avatar 4
    public bool Choice9Selected; //CustomAvatar - Coyote - CHOICE 8
    public bool Choice10Selected; //CustomAvatar - Daisy - CHOICE 9
    public bool Choice11Selected; //CustomAvatar - Kewko - CHOICE 10
    public bool Choice12Selected; //CustomAvatar - Levi - CHOICE 11
    public bool Choice13Selected; //CustomAvatar - Lexi - CHOICE 12
    public bool Choice14Selected; //CustomAvatar - Eule - CHOICE 13


    public GameObject Arrow1GO;
    public GameObject Arrow2GO;
    public GameObject Arrow3GO;
    public GameObject Arrow4GO;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //dont destroy - so the player script can access it 
        PlayerName = "Chef"; 
    }

    public void InputField() //the input field
    {
        PlayerName = NameEntry.text.ToString();
        if(string.IsNullOrWhiteSpace(PlayerName)) //if the player doesnt input anything
        {
            PlayerName = "Chef"; 
        }
    }

    public void Arrow1() //Left Arrow
    {
        if(CurrentChoice > 0)
        {
            CurrentChoice--;
            AvatarSelectImage.sprite = ChoiceSelected[CurrentChoice];
            Arrow1GO.SetActive(true);
        }

        Check();

        switch (CurrentChoice)
        {
            case 0:
                AvatarSelectImage.sprite = Cat1OutfitSelected[OutfitChoice];
                break;

            case 1:
                AvatarSelectImage.sprite = Cat2OutfitSelected[OutfitChoice];
                break;

            case 2:
                AvatarSelectImage.sprite = Cat3OutfitSelected[OutfitChoice];
                break;

            case 3:
                AvatarSelectImage.sprite = Cat4OutfitSelected[OutfitChoice];
                break;

            case 4:
                AvatarSelectImage.sprite = Dog1OutfitSelected[OutfitChoice];
                break;

            case 5:
                AvatarSelectImage.sprite = Dog2OutfitSelected[OutfitChoice];
                break;

            case 6:
                AvatarSelectImage.sprite = Dog3OutfitSelected[OutfitChoice];
                break;

            case 7:
                AvatarSelectImage.sprite = Dog4OutfitSelected[OutfitChoice];
                break;
        }

    }

    public void Arrow2() //Right Arrow
    {
        if (CurrentChoice < 13)
        {
            CurrentChoice++;
            AvatarSelectImage.sprite = ChoiceSelected[CurrentChoice];
            Arrow2GO.SetActive(true);
        }

        Check();

        switch (CurrentChoice)
        {
            case 0:
                AvatarSelectImage.sprite = Cat1OutfitSelected[OutfitChoice];
                break;

            case 1:
                AvatarSelectImage.sprite = Cat2OutfitSelected[OutfitChoice];
                break;

            case 2:
                AvatarSelectImage.sprite = Cat3OutfitSelected[OutfitChoice];
                break;

            case 3:
                AvatarSelectImage.sprite = Cat4OutfitSelected[OutfitChoice];
                break;

            case 4:
                AvatarSelectImage.sprite = Dog1OutfitSelected[OutfitChoice];
                break;

            case 5:
                AvatarSelectImage.sprite = Dog2OutfitSelected[OutfitChoice];
                break;

            case 6:
                AvatarSelectImage.sprite = Dog3OutfitSelected[OutfitChoice];
                break;

            case 7:
                AvatarSelectImage.sprite = Dog4OutfitSelected[OutfitChoice];
                break;
        }

    }

    //Check what animal the player is on 
    //give them the corresponding outfit
    public void Arrow3() //Left Arrow
    {
        if (OutfitChoice > 0)
        {
            OutfitChoice--;
        }

        Check();

        switch (CurrentChoice)
        {
            case 0:
                AvatarSelectImage.sprite = Cat1OutfitSelected[OutfitChoice];
                break;

            case 1:
                AvatarSelectImage.sprite = Cat2OutfitSelected[OutfitChoice];
                break;

            case 2:
                AvatarSelectImage.sprite = Cat3OutfitSelected[OutfitChoice];
                break;

            case 3:
                AvatarSelectImage.sprite = Cat4OutfitSelected[OutfitChoice];
                break;

            case 4:
                AvatarSelectImage.sprite = Dog1OutfitSelected[OutfitChoice];
                break;

            case 5:
                AvatarSelectImage.sprite = Dog2OutfitSelected[OutfitChoice];
                break;

            case 6:
                AvatarSelectImage.sprite = Dog3OutfitSelected[OutfitChoice];
                break;

            case 7:
                AvatarSelectImage.sprite = Dog4OutfitSelected[OutfitChoice];
                break;
        }

    }

    public void Arrow4() //Left Arrow
    {
        
        if(OutfitChoice < 6)
        {
            OutfitChoice++;
        }

        Check();

        switch (CurrentChoice)
        {
            case 0:
                AvatarSelectImage.sprite = Cat1OutfitSelected[OutfitChoice];
                break;

            case 1:
                AvatarSelectImage.sprite = Cat2OutfitSelected[OutfitChoice];
                break;

            case 2:
                AvatarSelectImage.sprite = Cat3OutfitSelected[OutfitChoice];
                break;

            case 3:
                AvatarSelectImage.sprite = Cat4OutfitSelected[OutfitChoice];
                break;

            case 4:
                AvatarSelectImage.sprite = Dog1OutfitSelected[OutfitChoice];
                break;

            case 5:
                AvatarSelectImage.sprite = Dog2OutfitSelected[OutfitChoice];
                break;

            case 6:
                AvatarSelectImage.sprite = Dog3OutfitSelected[OutfitChoice];
                break;

            case 7:
                AvatarSelectImage.sprite = Dog4OutfitSelected[OutfitChoice];
                break;
        }
    }

    public void Finished() //finished button
    {
        SceneManager.LoadScene("Tutorial"); //when done, load the tutorial
    }

    public void Check()
    {
        if (OutfitChoice == 6)
        {
            Arrow4GO.SetActive(false);
        }

        if (OutfitChoice == 5)
        {
            Arrow4GO.SetActive(true);
        }

        if (OutfitChoice == 1)
        {
            Arrow3GO.SetActive(true);
        }

        if (OutfitChoice == 0)
        {
            Arrow3GO.SetActive(false);
        }

        if (CurrentChoice == 1)
        {
            Arrow1GO.SetActive(true);
        }

        if (CurrentChoice == 13)
        {
            Arrow2GO.SetActive(false);
        }

        if(CurrentChoice == 11)
        {
            Arrow2GO.SetActive(true);
        }    

        if (CurrentChoice == 0)
        {
            Arrow1GO.SetActive(false);
        }

        if (CurrentChoice >= 8)
        {
            Arrow3GO.SetActive(false);
            Arrow4GO.SetActive(false);
        }

        if (CurrentChoice == 7 && OutfitChoice == 0)
        {
            Arrow3GO.SetActive(false);
            Arrow4GO.SetActive(true);
        }

        if (CurrentChoice == 7 && OutfitChoice > 0)
        {
            Arrow3GO.SetActive(true);
            Arrow4GO.SetActive(true);
        }

        if (CurrentChoice == 7 && OutfitChoice == 6)
        {
            Arrow3GO.SetActive(true);
            Arrow4GO.SetActive(false);
        }
    }
}
