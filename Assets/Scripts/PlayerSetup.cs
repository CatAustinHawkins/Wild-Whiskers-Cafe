using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This script controls the player setup

public class PlayerSetup : MonoBehaviour
{

    public TMP_InputField NameEntry; //the input field the player can put their name into

    public string PlayerName = "Cat"; //default name is Cat

    //Different player images
    public Image Choice1; 
    public Image Choice2;
    public Image Choice3;
    public Image Choice4;

    //which choice the player chooses
    public bool Choice1Selected;
    public bool Choice2Selected;
    public bool Choice3Selected;
    public bool Choice4Selected;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //dont destroy - so the player script can access it 
        PlayerName = "Cat"; //default to cat
    }

    public void InputField() //the input field
    {
        PlayerName = NameEntry.text.ToString();
        if(string.IsNullOrWhiteSpace(PlayerName)) //if the player doesnt input anything
        {
            PlayerName = "Cat"; //default to cat
        }
    }


    //each player avatar choice is a button
    //clicking each option changes the bool and updated the button to reflect what the player chose
    public void PlayerAvatarChoice1()
    {
        Choice1Selected = true;
        Choice2Selected = false;
        Choice3Selected = false;
        Choice4Selected = false;

        Choice1.color = new Color32(171, 171, 171, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice2()
    {
        Choice2Selected = true;
        Choice1Selected = false;
        Choice3Selected = false;
        Choice4Selected = false;

        Choice2.color = new Color32(171, 171, 171, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice3()
    {
        Choice3Selected = true;
        Choice1Selected = false;
        Choice2Selected = false;
        Choice4Selected = false;

        Choice3.color = new Color32(171, 171, 171, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice4()
    {
        Choice4Selected = true;
        Choice1Selected = false;
        Choice2Selected = false;
        Choice3Selected = false;

        Choice4.color = new Color32(171, 171, 171, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
    }

    public void Finished()
    {
        SceneManager.LoadScene("Tutorial"); 
    }


}
