using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;

    public GameObject SnakeOrder;

    public GameObject Buttons;
    public GameObject ThoughtBubble;

    public TextMeshProUGUI FirstOptionText;
    public TextMeshProUGUI SecondOptionText;

    public bool FirstDialogue;
    public bool OptionNoWasClicked; //Initial Choice 
    public bool OptionYesWasClicked; //Initial Choice

    public PlayerScript Player;
    public void YesButton()
    {
        if (FirstDialogue)
        {
            DialogueText.text = "Yay!";
            Buttons.SetActive(false);
            SnakeOrder.SetActive(true);
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

    public void NoButton()
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
            SnakeOrder.SetActive(true);
            ThoughtBubble.SetActive(false);

        }

        //are you sure
        //display buttons again
        //if player says no then the character leaves


    }

}
