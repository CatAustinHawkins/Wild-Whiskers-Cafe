using UnityEngine;
using TMPro;

//This script is used for the tutorial screen at the start of the game

public class Tutorial : MonoBehaviour
{

    //show tutorial
    //player has to provide the input to go to the next tutorial
    

    public GameObject[] TutorialImageArray; //An array of tutorial images
    public int TutorialImages; //the current tutorial image number
    public CustomerTest customertestscript; //the customer test script

    //tutorial1 - wasd movement controls
    //tutorial2 - overall happiness meter
    //tutorial3 - open ui book 
    //tutorial4 - use arrow keys to interact with ui book
    //tutorial5 - close ui book
    //tutorial6 - talk to the panda
    //tutorial7 - accept the order
    //tutorial8 - close dialogue
    //tutorial9 - open order
    //tutorial10 - close order form
    //tutorial11 - go to the kitchen
    //tutorial12 - open the fridge
    //tutorial13- select the bamboo and bread
    //tutorial14 - close the fridge
    //tutorial15 - cook bamboo in the oven
    //tutorial16 - put the food together on the chopping board
    //tutorial17 - serve the customer
    //tutorial18 - go to your room
    //tutorial19 - go to bed


    //things to add
    //blender 
    //fire
    //trash
    //  

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
            //close the fridge
        }

        if (TutorialImages == 14)
        {
            //cook bamboo in the oven
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
