using UnityEngine;
using UnityEngine.UI;

//Unused Script
//This would be used to control the player difficulty

public class Setup : MonoBehaviour
{
    public bool Under12; //is the player under 12
    public bool Over13; //is the player above 13

    public bool Easy; //easy mode bool
    public bool Normal; //normal mode bool
    public bool Hard; //hard mode bool

    public bool Under12Easy; //under 12 easy mode
    public bool Under12Normal; //under 12 normal mode
    public bool Under12Hard; //under 12 hard mode

    public bool Over13Easy; //over 13 easy mode
    public bool Over13Normal; //over 13 normal mode
    public bool Over13Hard; //over 13 hard mode

    public Image Choice1; //choice images for the buttons
    public Image Choice2;
    public Image Choice3;
    public Image Choice4;
    public Image Choice5;

    public int GameMode = 4; //default game mode - over 13 normal
    //GameMode 1 = Under 12 Easy
    //GameMode 2 = Under 12 Normal
    //GameMode 3 = Under 12 Hard

    //GameMode 4 = Over 13 Easy
    //GameMode 5 = Over 13 Normal
    //GameMode 6 = Over 13 Hard
    public void Start()
    {
        DontDestroyOnLoad(this.gameObject); //dont destroy - so the player script can access it 
        Over13Normal = true; //set the default game mode to true
    }
    public void Under12Selected() //if the player clicks that they are under 12
    {
        Choice1.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice2.color = Color.white;

        Under12 = true; //set under12 to true
        Over13 = false; //set over13 to false

        if(Easy) //if the player also selected easy
        {
            Under12Easy = true; //set under12 easy to true
            Under12Normal = false; //set other variables to false
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 1; //under 12 easy gamemode
        }

        if (Normal) //if the player also selected normal
        {
            Under12Easy = false;
            Under12Normal = true;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 2; //under 12 normal gamemode

        }

        if (Hard) //if the player also selected hard
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = true;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 3; //under 12 hard gamemode

        }
    }

    public void Over13Selected() //if the player clicks that they are under 13
    {
        Choice2.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice1.color = Color.white;

        Under12 = false;
        Over13 = true;

        if (Easy) //if the player also selected easy
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = true;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 4; //over 13 easy gamemode

        }

        if (Normal) //if the player also selected normal
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = true;
            Over13Hard = false;

            GameMode = 5; //over 13 normal gamemode

        }

        if (Hard) //if the player also selected hard
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = true;

            GameMode = 6; //over 13 hard gamemode

        }
    }

    public void EasyModeSelected() //if the player clicks easy mode
    {
        Choice3.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice4.color = Color.white;
        Choice5.color = Color.white;

        Easy = true;
        Normal = false;
        Hard = false;
    
        if(Under12) //if the player also selected Under 12
        {
            Under12Easy = true;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 1; //under 12 easy gamemode

        }

        if (Over13) //if the player also selected Over 13
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = true;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 4; //over 13 easy gamemode
        }
    }

    public void NormalModeSelected() //if the player clicks normal mode
    {
        Easy = false;
        Normal = true;
        Hard = false;

        Choice3.color = Color.white;
        Choice4.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it
        Choice5.color = Color.white;

        if (Under12) //if the player also selected Under 12
        {
            Under12Easy = false;
            Under12Normal = true;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 2; //under 12 normal gamemode
        }

        if (Over13) //if the player also selected Over 13
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = true;
            Over13Hard = false;

            GameMode = 5; //over 13 normal gamemode
        }
    }


    public void HardModeSelected() //if the player clicks hard mode
    {
        Easy = false;
        Normal = false;
        Hard = true;

        Choice3.color = Color.white;
        Choice4.color = Color.white;

        Choice5.color = new Color32(171, 171, 171, 255);
        //change the button colour, so it is visible the player clicked it

        if (Under12) //if the player also selected Under 12
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = true;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 3; //under 12 hard gamemode
        }

        if (Over13) //if the player also selected Over 13
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = true;
            GameMode = 6; //over 13 hard gamemode
        }
    }
}
