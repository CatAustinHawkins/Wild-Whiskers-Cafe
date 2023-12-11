using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewDialogue : MonoBehaviour
{

    public bool PandaInRange;
    public bool FrontOfHouseInRange;
    public TextMeshProUGUI DialogueText;

    public GameObject DialogueBox;

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
            DialogueBox.SetActive(true);
        }
    }
}
