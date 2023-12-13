using UnityEngine;
using TMPro;

//This script is used for the tutorial screen at the start of the game

public class Tutorial : MonoBehaviour
{

    public GameObject[] TutorialImageArray; //An array of tutorial images
    public int TutorialImages; //the current tutorial image number
    public CustomerTest customertestscript; //the customer test script

    public TextMeshProUGUI TutorialButtonText; //the tutorial button text 

    public void NextTutorial() //when the next tutorial button is clicked
    {

        if (TutorialImages == 9) //if the player is on the ninth tutorial, rename the button to "End tutorial"
        {
            TutorialButtonText.text = "End Tutorial";
        }

        if (TutorialImages == 10) //if the player is on the tenth, and final, tutorial close the tutorial window by destroying it and then set daybegin to true.
        {
            Destroy(gameObject);
            customertestscript.DayBegin = true;
        }

        TutorialImageArray[TutorialImages].SetActive(false); //disable the current tutorial image

        TutorialImages++; //increment the tutorial image variable

        TutorialImageArray[TutorialImages].SetActive(true); //set the next tutorial image to true
    }
}
