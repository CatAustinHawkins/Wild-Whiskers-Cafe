using UnityEngine;
using UnityEngine.EventSystems;

//This script is used for the tutorial screen at the start of the game

public class Tutorial : MonoBehaviour
{
    //show tutorial
    //player has to provide the input to go to the next tutorial

    public GameObject[] TutorialImageArray; //An array of tutorial images
    public int TutorialImages; //the current tutorial image number

    //tutorial1 - wasd movement controls
    //tutorial2 - overall happiness meter
    //tutorial3 - open cook book 
    //tutorial4 - use arrow keys to interact with ui book
    //tutorial5 - go to the shop page
    //tutorial6 - get the fishtank!
    //tutorial7 - close cook book
    //tutorial8 - talk to the panda
    //tutorial9 - accept the order 
    //tutorial10 - close dialogue
    //tutorial11 - open order
    //tutorial12 - close order form
    //tutorial13 - go to the kitchen
    //tutorial14 - kitchen intro
    //tutorial15 - Use the broom when puddles appear! and use the fire extinguisher
    //tutorial16 - open the fridge
    //tutorial17 - select the meat
    //tutorial18 - blend the meat
    //tutorial19 - collect the smoothie
    //tutorial20 - serve the customer!
    //tutorial21 - wait for the customer to finish eating
    //tutorial22 - pick up plate and accept the next order
    //tutorial23 - go to the sink
    //tutorial24 - wash up the plate
    //tutorial25 - check the next order!
    //tutorial26- select the bamboo and bread
    //tutorial27 - close the fridge
    //tutorial28 - cook bamboo in the oven
    //tutorial29 - put the food together on the chopping board
    //tutorial30 - serve the customer
    //tutorial31 - wash the plate up!
    //tutorial32 - go to your room
    //tutorial33 - go to bed

    //Most tutorials are triggered via other scripts

    public void FixedUpdate()
    {
        if (TutorialImages == 0) //if on the 1st tutorial
        {
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0)) //player has to move
            {
                if(!EventSystem.current.IsPointerOverGameObject()) //check that they weren't clicking UI
                {
                    NextTutorial(); //play next tutorial
                }
            }
        }
        if (TutorialImages == 1) //if on the 2nd tutorial
        {
            //to close the tutorial prompt
            if (Input.GetKey(KeyCode.Space))
            {
                NextTutorial(); //play next tutorial
            }
        }

        if (TutorialImages == 2) //if on the 3rd tutorial
        {
            //if the player opens the cookbook
            if (Input.GetKey(KeyCode.Q))
            {
                NextTutorial(); //play next tutorial

            }
        }
        if (TutorialImages == 3) //if on the 4th tutorial
        {
            //if the player navigates the cookbook
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                NextTutorial(); //play next tutorial
            }
        }
            
        if (TutorialImages == 4) //if on the 5th tutorial
        {
            //if the player opens the cookbook
            if (Input.GetKey(KeyCode.Q))
            {
                NextTutorial(); //play next tutorial
            }
        }

        if (TutorialImages == 14) //if on the 15th tutorial
        {
            //to close the tutorial prompt
            if (Input.GetKey(KeyCode.Space))
            {
                NextTutorial(); //play next tutorial
            }
        }
        if (TutorialImages == 13) //if on the 14th tutorial
        {
            //to close the tutorial prompt
            if (Input.GetKey(KeyCode.Space))
            {
                //close ui book
                NextTutorial(); //play next tutorial
            }
        }
    }
    public void NextTutorial() //if next tutorial is called 
    {
        TutorialImageArray[TutorialImages].SetActive(false); //set the curren tutorial image to false
        TutorialImages++; //increment the tutorial images int, to show the next tutorial in the sequence
        TutorialImageArray[TutorialImages].SetActive(true); //set the current tutorial image to true
    }
}