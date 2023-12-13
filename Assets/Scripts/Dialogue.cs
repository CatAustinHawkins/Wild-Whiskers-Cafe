using UnityEngine;
using TMPro;

//This script controls the dialogue between the player and the customer - plan to change this

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI DialogueText; //The dialogue text asset

    public GameObject PandaOrder; //the first orderform - the panda's

    public GameObject Buttons; //The Yes/No buttons
    public GameObject ThoughtBubble;//The customers thought bubble

    public TextMeshProUGUI FirstOptionText; //The first option (Yes) 
    public TextMeshProUGUI SecondOptionText; //The second option (No)

    public bool FirstDialogue; //The first dialogue with the customer
    public bool OptionNoWasClicked; //Initial Choice 
    public bool OptionYesWasClicked; //Initial Choice

    public PlayerScript Player;

    //This dialogue is "Hi! Can I get a hotdog please?"
    
    //if the player says Yes
    //"Yay!"

    //And then, if the player talks to the customer again they say
    //"Thank you!"

    //if the player said No
    //"Oh... Are you sure?"

    //then displays Yes and No again
    //If the player says Yes - as in, Yes I'm sure
    //":(" 

    //If the player says No - as in, No I'm not sure
    //"Yay!"

    public void YesButton() //Yes Button
    {
        if (FirstDialogue)
        {
            DialogueText.text = "Yay!";
            Buttons.SetActive(false);
            PandaOrder.SetActive(true);
            ThoughtBubble.SetActive(false);
            OptionYesWasClicked = true;
        }

        if(OptionYesWasClicked)
        {
            DialogueText.text = "Thank you!";
        }

        if(OptionNoWasClicked)
        {
            DialogueText.text = ":(";
            //call to the customer to get them to walk away and leave
        }

    }

    public void NoButton() //No Button
    {
        if(FirstDialogue)
        {
            DialogueText.text = "Oh... Are you sure?";
            OptionNoWasClicked = true;
            FirstDialogue = false;
        }

        if (OptionNoWasClicked)
        {
            DialogueText.text = "Yay!";
            Buttons.SetActive(false);
            PandaOrder.SetActive(true);
            ThoughtBubble.SetActive(false);

        }
    }

}
