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
    public Image Choice1; //Cat Avatar 1
    public Image Choice2; //Cat Avatar 2
    public Image Choice3; //Cat Avatar 3
    public Image Choice4; //Cat Avatar 4
    public Image Choice5; //Dog Avatar 1
    public Image Choice6; //Dog Avatar 2
    public Image Choice7; //Dog Avatar 3
    public Image Choice8; //Dog Avatar 4

    //which choice the player chooses
    public bool Choice1Selected; //Cat Avatar 1
    public bool Choice2Selected; //Cat Avatar 2
    public bool Choice3Selected; //Cat Avatar 3
    public bool Choice4Selected; //Cat Avatar 4
    public bool Choice5Selected; //Dog Avatar 1
    public bool Choice6Selected; //Dog Avatar 2
    public bool Choice7Selected; //Dog Avatar 3
    public bool Choice8Selected; //Dog Avatar 4

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
    public void PlayerAvatarChoice1() //if the player chooses option 1
    {
        Choice1Selected = true; //set choice 1 selected to true
        Choice2Selected = false; //set everything to false
        Choice3Selected = false;
        Choice4Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice1.color = new Color32(171, 171, 171, 255); 
        //change the button colour, so it is visible the player clicked it
        Choice2.color = Color.white; //change the other buttons to white, to show they arent selected
        Choice3.color = Color.white;
        Choice4.color = Color.white;
        Choice5.color = Color.white;
        Choice6.color = Color.white;
        Choice7.color = Color.white;
        Choice8.color = Color.white;

    }
    public void PlayerAvatarChoice2()
    {
        Choice2Selected = true; //set choice 2 selected to true
        Choice1Selected = false; //set everything to false
        Choice3Selected = false;
        Choice4Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice2.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice1.color = Color.white; //change the other buttons to white, to show they arent selected
        Choice3.color = Color.white;
        Choice4.color = Color.white;
        Choice5.color = Color.white;
        Choice6.color = Color.white;
        Choice7.color = Color.white;
        Choice8.color = Color.white;
    }
    public void PlayerAvatarChoice3()
    {
        Choice3Selected = true; //set choice 3 selected to true
        Choice2Selected = false; //set everything to false
        Choice1Selected = false;
        Choice4Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice3.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice2.color = Color.white; //change the other buttons to white, to show they arent selected
        Choice1.color = Color.white;
        Choice4.color = Color.white;
        Choice5.color = Color.white;
        Choice6.color = Color.white;
        Choice7.color = Color.white;
        Choice8.color = Color.white;
    }
    public void PlayerAvatarChoice4()
    {
        Choice4Selected = true; //set choice 4 selected to true
        Choice2Selected = false; //set everything to false
        Choice3Selected = false;
        Choice1Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice4.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice2.color = Color.white; //change the other buttons to white, to show they arent selected
        Choice3.color = Color.white;
        Choice1.color = Color.white;
        Choice5.color = Color.white;
        Choice6.color = Color.white;
        Choice7.color = Color.white;
        Choice8.color = Color.white;
    }
    public void PlayerAvatarChoice5()
    {
        Choice5Selected = true; //set choice 5 selected to true
        Choice1Selected = false; //set everything to false
        Choice2Selected = false;
        Choice3Selected = false;
        Choice4Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice5.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice2.color = Color.white; //change the other buttons to white, to show they arent selected
        Choice3.color = Color.white;
        Choice4.color = Color.white;
        Choice1.color = Color.white;
        Choice6.color = Color.white;
        Choice7.color = Color.white;
        Choice8.color = Color.white;
    }
    public void PlayerAvatarChoice6()
    {
        Choice6Selected = true; //set choice 6 selected to true
        Choice2Selected = false; //set everything to false
        Choice3Selected = false;
        Choice1Selected = false;
        Choice5Selected = false;
        Choice4Selected = false;
        Choice7Selected = false;
        Choice8Selected = false;

        Choice6.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice2.color = Color.white; //change the other buttons to white, to show they arent selected
        Choice3.color = Color.white;
        Choice1.color = Color.white;
        Choice5.color = Color.white;
        Choice4.color = Color.white;
        Choice7.color = Color.white;
        Choice8.color = Color.white;
    }
    public void PlayerAvatarChoice7()
    {
        Choice7Selected = true; //set choice 7 selected to true
        Choice2Selected = false; //set everything to false
        Choice3Selected = false;
        Choice1Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice4Selected = false;
        Choice8Selected = false;

        Choice7.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice2.color = Color.white; //change the other buttons to white, to show they arent selected
        Choice3.color = Color.white;
        Choice1.color = Color.white;
        Choice5.color = Color.white;
        Choice6.color = Color.white;
        Choice4.color = Color.white;
        Choice8.color = Color.white;
    }
    public void PlayerAvatarChoice8()
    {
        Choice7Selected = true; //set choice 8 selected to true
        Choice2Selected = false; //set everything to false
        Choice3Selected = false;
        Choice1Selected = false;
        Choice5Selected = false;
        Choice6Selected = false;
        Choice7Selected = false;
        Choice4Selected = false;

        Choice8.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice2.color = Color.white; //change the other buttons to white, to show they arent selected
        Choice3.color = Color.white;
        Choice1.color = Color.white;
        Choice5.color = Color.white;
        Choice6.color = Color.white;
        Choice7.color = Color.white;
        Choice4.color = Color.white;
    }

    public void Finished() //finished button
    {
        SceneManager.LoadScene("Tutorial"); //when done, load the tutorial
    }
}
