using UnityEngine;
using TMPro;

//This script is used for the tutorial screen at the start of the game

public class Tutorial : MonoBehaviour
{

    //show tutorial
    //player has to provide the input to go to the next tutorial
    

    public GameObject[] TutorialImageArray; //An array of tutorial images
    public int TutorialImages; //the current tutorial image number

    //tutorial1 - wasd movement controls
    //tutorial2 - overall happiness meter
    //tutorial3 - open ui book 
    //tutorial4 - use arrow keys to interact with ui book
    //tutorial5 - go to the shop page
    //tutorial6 - get the fishtank!
    //tutorial7 - close ui book
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


    public void FixedUpdate()
    {
        if (TutorialImages == 0)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                //use WASD to move
                NextTutorial();
            }
        }

        if(TutorialImages == 1)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                //close happiness tutorial
                NextTutorial();
            }
        }

        if(TutorialImages == 2)
        {
            if(Input.GetKey(KeyCode.Alpha1))
            {
                //open ui book
                NextTutorial();

            }
        }

        if(TutorialImages == 3)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                //navigate ui book
                NextTutorial();

            }
        }

        if (TutorialImages == 4)
        {
            if (Input.GetKey(KeyCode.Alpha1) || Input.GetKey(KeyCode.Escape))
            {
                //close ui book
                NextTutorial();

            }
        }

        if (TutorialImages == 5)
        {
            //talk to panda 
        }

        if (TutorialImages == 6)
        {
            //accept the order
        }

        if (TutorialImages == 7)
        {
            //close the dialogue
        }

        if (TutorialImages == 8)
        {
            //open the order
        }

        if (TutorialImages == 9)
        {
            //close the order form DONE
        }

        if (TutorialImages == 10)
        {
            //go to the kitchen 
        }

        if (TutorialImages == 11)
        {
            //open the fridge
        }

        if (TutorialImages == 12)
        {
            //select the bamboo and bread
        }

        if (TutorialImages == 13)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                //close ui book
                NextTutorial();

            }
        }

        if (TutorialImages == 14)
        {
            //cook bamboo in the oven
            if (Input.GetKey(KeyCode.Space))
            {
                //close ui book
                NextTutorial();

            }
        }

        if (TutorialImages == 15)
        {
            //put the food together on the chopping board
        }

        if (TutorialImages == 16)
        {
            //serve the customer
        }

        if (TutorialImages == 17)
        {
            //go to your room
        }

        if (TutorialImages == 18)
        {
            //go to bed
        }
    }

    public void NextTutorial()
    {
        TutorialImageArray[TutorialImages].SetActive(false); //set the next tutorial image to true
        TutorialImages++;
        TutorialImageArray[TutorialImages].SetActive(true);
    }

}
