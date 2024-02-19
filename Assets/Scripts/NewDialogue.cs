using UnityEngine;
using TMPro;
using System.Collections;
//new dialogue script that works the dialogue button

public class NewDialogue : MonoBehaviour
{
    private IEnumerator coroutine;

    public bool PandaInRange; //if pandas in range
    public TextMeshProUGUI DialogueText; //dialogue text object

    public GameObject DialogueBox; //dialogue box

    public bool TimerRunning;

    public bool DialogueOpen;

    public TextMeshProUGUI DialogueTextTMP;
    public TextMeshProUGUI NameTextTMP;
    public Tutorial TutorialScript;

    public GameObject ThinkBubble;

    public void Update()
    {
        if(Input.GetKey(KeyCode.Alpha3) && !TimerRunning)
        {
            DialogueButton();
            StartCoroutine(DelayTime());
        }

        if (Input.GetKey(KeyCode.Escape) && DialogueOpen)
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (Input.GetKey(KeyCode.Alpha5) && !TimerRunning)
        {
            TickButton();
            StartCoroutine(DelayTime());
        }

        if (Input.GetKey(KeyCode.Alpha6) && !TimerRunning)
        {
            CrossButton();
            StartCoroutine(DelayTime());
        }
    }


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
        if(!DialogueOpen)
        {
            if (PandaInRange)
            {
                DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                DialogueOpen = true;
                if(TutorialScript.TutorialImages == 5)
                {
                    TutorialScript.NextTutorial();
                }
            }
        }
        else
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
            if (TutorialScript.TutorialImages == 7)
            {
                TutorialScript.NextTutorial();
            }
        }
    }

    //controls the tick button
    public void TickButton()
    {
        if (DialogueOpen)
        {
            if (PandaInRange)
            {
                ThinkBubble.SetActive(false);
                DialogueTextTMP.text = "Yay!!!";
            }
        }

        if (TutorialScript.TutorialImages == 6)
        {
            TutorialScript.NextTutorial();
        }
    }

    //controls the cross button
    public void CrossButton()
    {
        if (DialogueOpen)
        {
            if (PandaInRange)
            {
                //
                DialogueTextTMP.text = "Oh... :(";
            }
        }
    }

    IEnumerator DelayTime()
    {
        TimerRunning = true;
        yield return new WaitForSeconds(0.25f);
        TimerRunning = false;
    }
}
