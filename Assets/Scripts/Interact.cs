using UnityEngine;
using System.Collections;
using TMPro;

//This script is used on the Interact button, to see if the player can interact with the objects around them

public class Interact : MonoBehaviour
{

    [Header("Bools")]
    public bool OvenInRange; //if the oven is in range
    public bool ChoppingBoardInRange; //if the chopping board is in range
    public bool FridgeInRange; //if the fridge is in range

    public bool FridgeOpen; //is the fridge window open
    public bool FoodCooked; //is the food cooked
    public bool MealReady; //is the meal ready
    public bool PandaInRange; //is the player in range of the panda

    public bool BedInRange;


    [Header("Fridge Assets")]
    public GameObject FridgeUI; //fridge ui window
    public Fridge FridgeScript; //fridge script

    public GameObject Bread; //bread gameobject that the player holds
    public GameObject Bamboo; //bamboo gameobject that the player holds
    public GameObject CookedBamboo; //cooked bamboo gameobject that the player holds
    public GameObject BambooHotdog; //bamboo hotdog gameobject that the player holds

    public CustomerTest CustomerTestScript; //customer script

    public bool TimerRunning;

    public GameObject OvenInteractPrompt;
    public GameObject ChoppingBoardInteractPrompt;

    public GameObject TutorialEnd;

    public Tutorial TutorialScript;

    public TextMeshProUGUI OvenTimerTimerText;
    public TextMeshProUGUI ChoppingBoardTimerText;

    public float OvenTimerFloat = 3f;
    public float ChoppingBoardFloat = 2f;

    public void Start()
    {
        OvenTimerFloat = 3f;
        ChoppingBoardFloat = 2f;
    }
    public void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            InteractButton();
        }

        if(Input.GetKey(KeyCode.Alpha4) && !TimerRunning)
        {
            InteractButton();
            StartCoroutine(DelayTime());
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Oven") //check if the player is colliding with the oven
        {
            OvenInRange = true; //set oven in range to true
            Debug.Log("Player at Oven");
        }

        //same for the other game objects
        if (other.tag == "Fridge")
        {
            FridgeInRange = true;
            Debug.Log("Player at Fridge");
        }

        if (other.tag == "ChoppingBoard")
        {
            ChoppingBoardInRange = true;
        }

        if(other.tag == "PandaCustomer")
        {
            PandaInRange = true;
        }

        if (other.tag == "Bed")
        {
            BedInRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        //when the player stops colliding with these tags change their bools
        if(other.tag == "Oven")
        {
            OvenInRange = false;
            Debug.Log("Player left Oven");
        }

        if (other.tag == "Fridge")
        {
            FridgeInRange = false;
            Debug.Log("Player at Fridge");
        }

        if(other.tag == "ChoppingBoard")
        {
            ChoppingBoardInRange = false;
        }
        if (other.tag == "PandaCustomer")
        {
            PandaInRange = false;
        }
        if (other.tag == "Bed")
        {
            BedInRange = false;
        }

    }

    public void InteractButton()
    {
        if(OvenInRange)
        {
            //check what food the player has

            if(FridgeScript.HoldingBamboo) //if the players holding bamboo
            {
                OvenInteractPrompt.SetActive(true);
                StartCoroutine(OvenTimer());
            }
        }

        if(FridgeInRange) //open the fridge UI
        {
            if(!FridgeOpen)
            {
                FridgeUI.SetActive(true);
                FridgeOpen = true;
                if(TutorialScript.TutorialImages == 11)
                {
                    TutorialScript.NextTutorial();
                }
            }
            else
            {
                FridgeUI.SetActive(false);
                FridgeOpen = false;
                if (TutorialScript.TutorialImages == 13)
                {
                    TutorialScript.NextTutorial();
                }
            }
        }

        if(ChoppingBoardInRange)
        {
            if(FoodCooked) //if the food is cooked
            {
                ChoppingBoardInteractPrompt.SetActive(true);
                StartCoroutine(ChoppingTimer());
            }
        }

        if(PandaInRange)
        {
            if (MealReady) //when the meal is cooked
            {
                BambooHotdog.SetActive(false); //disable the bamboo hotdog
                CustomerTestScript.Fed();//call to the customer script
                if (TutorialScript.TutorialImages == 16)
                {
                    TutorialScript.NextTutorial();
                }
            }
        }
        
        if(BedInRange)
        {
            TutorialEnd.SetActive(true);
        }
    }

    IEnumerator DelayTime()
    {
        TimerRunning = true;
        yield return new WaitForSeconds(0.25f);
        TimerRunning = false;
    }

    IEnumerator OvenTimer()
    {
        StartCoroutine(OvenTimerText());
        TimerRunning = true;
        yield return new WaitForSeconds(3f);
        TimerRunning = false;
        Bamboo.SetActive(false);
        CookedBamboo.SetActive(true); //make them hold cooked bamboo instead
        FoodCooked = true;
        OvenInteractPrompt.SetActive(false);
        if (TutorialScript.TutorialImages == 14)
        {
            TutorialScript.NextTutorial();
        }
    }

    IEnumerator ChoppingTimer()
    {
        StartCoroutine(ChoppingTimerText());
        TimerRunning = true;
        yield return new WaitForSeconds(2f);
        CookedBamboo.SetActive(false);
        Bread.SetActive(false);
        Bamboo.SetActive(false);
        BambooHotdog.SetActive(true); //enable the bamboo hotdog gameobject
        MealReady = true;
        TimerRunning = false;
        ChoppingBoardInteractPrompt.SetActive(false);
        if (TutorialScript.TutorialImages == 15)
        {
            TutorialScript.NextTutorial();
        }
    }

    IEnumerator ChoppingTimerText()
    {
        yield return new WaitForSeconds(0.25f);
        ChoppingBoardFloat = ChoppingBoardFloat - 0.25f;
        ChoppingBoardTimerText.text = ChoppingBoardFloat.ToString() + "s";
        if (ChoppingBoardFloat > 0)
        {
            StartCoroutine(ChoppingTimerText());
        }
    }

    IEnumerator OvenTimerText()
    {
        yield return new WaitForSeconds(0.25f);
        OvenTimerFloat = OvenTimerFloat - 0.25f;
        OvenTimerTimerText.text = OvenTimerFloat.ToString() + "s";
        if (OvenTimerFloat > 0)
        {
            StartCoroutine(OvenTimerText());
        }
    }
}
