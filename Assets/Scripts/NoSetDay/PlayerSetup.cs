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
    public Image Choice5;
    public Image Choice6;
    public Image Choice7;
    public Image Choice8;

    //which choice the player chooses
    public bool Choice1Selected;
    public bool Choice2Selected;
    public bool Choice3Selected;
    public bool Choice4Selected;
    public bool Choice5Selected;
    public bool Choice6Selected;
    public bool Choice7Selected;
    public bool Choice8Selected;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //dont destroy - so the player script can access it 
        PlayerName = "Player"; //default to cat
    }

    public void InputField() //the input field
    {
        PlayerName = NameEntry.text.ToString();
        if(string.IsNullOrWhiteSpace(PlayerName)) //if the player doesnt input anything
        {
            PlayerName = "Player"; //default to cat
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
        Choice5Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice1.color = new Color32(171, 171, 171, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
        Choice5.color = new Color32(255, 255, 255, 255);
        Choice6.color = new Color32(255, 255, 255, 255);
        Choice7.color = new Color32(255, 255, 255, 255);
        Choice8.color = new Color32(255, 255, 255, 255);

    }
    public void PlayerAvatarChoice2()
    {
        Choice2Selected = true;
        Choice1Selected = false;
        Choice3Selected = false;
        Choice4Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice2.color = new Color32(171, 171, 171, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
        Choice5.color = new Color32(255, 255, 255, 255);
        Choice6.color = new Color32(255, 255, 255, 255);
        Choice7.color = new Color32(255, 255, 255, 255);
        Choice8.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice3()
    {
        Choice3Selected = true;
        Choice2Selected = false;
        Choice1Selected = false;
        Choice4Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice3.color = new Color32(171, 171, 171, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
        Choice5.color = new Color32(255, 255, 255, 255);
        Choice6.color = new Color32(255, 255, 255, 255);
        Choice7.color = new Color32(255, 255, 255, 255);
        Choice8.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice4()
    {
        Choice4Selected = true;
        Choice2Selected = false;
        Choice3Selected = false;
        Choice1Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice4.color = new Color32(171, 171, 171, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice5.color = new Color32(255, 255, 255, 255);
        Choice6.color = new Color32(255, 255, 255, 255);
        Choice7.color = new Color32(255, 255, 255, 255);
        Choice8.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice5()
    {
        Choice1Selected = false;
        Choice2Selected = false;
        Choice3Selected = false;
        Choice4Selected = false;
        Choice5Selected = true;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice5.color = new Color32(171, 171, 171, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice6.color = new Color32(255, 255, 255, 255);
        Choice7.color = new Color32(255, 255, 255, 255);
        Choice8.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice6()
    {
        Choice6Selected = true;
        Choice2Selected = false;
        Choice3Selected = false;
        Choice1Selected = false;
        Choice5Selected = false;
        Choice4Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice6.color = new Color32(171, 171, 171, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice5.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
        Choice7.color = new Color32(255, 255, 255, 255);
        Choice8.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice7()
    {
        Choice7Selected = true;
        Choice2Selected = false;
        Choice3Selected = false;
        Choice1Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice4Selected = false;
        Choice8Selected = false;

        Choice7.color = new Color32(171, 171, 171, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice5.color = new Color32(255, 255, 255, 255);
        Choice6.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
        Choice8.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice8()
    {
        Choice8Selected = true;
        Choice2Selected = false;
        Choice3Selected = false;
        Choice1Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice4Selected = false;

        Choice8.color = new Color32(171, 171, 171, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice5.color = new Color32(255, 255, 255, 255);
        Choice6.color = new Color32(255, 255, 255, 255);
        Choice7.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
    }

    public void Finished()
    {
        SceneManager.LoadScene("Tutorial"); 
    }


}
