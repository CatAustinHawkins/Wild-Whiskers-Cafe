using UnityEngine;
using TMPro;

//new dialogue script that works the dialogue button

public class NewDialogue : MonoBehaviour
{

    public bool PandaInRange; //if pandas in range
    public TextMeshProUGUI DialogueText; //dialogue text object

    public GameObject DialogueBox; //dialogue box


    //same as interact script
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "PandaCustomer")
        {
            PandaInRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "PandaCustomer")
        {
            PandaInRange = false;
            DialogueBox.SetActive(false);
        }
    }

    public void DialogueButton()
    {
        if(PandaInRange)
        {
            DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
        }
    }
}
