using System.Collections;
using UnityEngine;
using UnityEngine.UI;

//This script is on the customer, controlling their movement and happiness

public class CustomerTest : MonoBehaviour
{
    //Speed and location variables
    private float speed = 8.0f;
    public GameObject FoHtarget;
    public Vector2 position;
    public GameObject DeskTarget;
    public GameObject LeavingArea;

    //Bools which control where the cusotmer goes
    public bool TableFree;
    public bool movingtofoh;
    public bool movingtotable;
    public bool stoppedmoving;

    //Their thought bubble
    public GameObject ThoughtBubble;

    //Bools to check what they are doing
    public bool MovingtoDesk;
    public bool WaitingatTable;

    //This is set to true when they day begins. Stops the customer from moving around whilst the players in the tutorial
    public bool DayBegin = true;

    //Happiness variables
    public Slider OverallHappiness;
    public float happinessvalue = 1;
    public float overallhappinessvalue = 1;

    //If the customers leaving
    public bool Leaving;

    public GameObject DayFinished;

    //Each customer has their own number to check which customer is currently in the cafe
    public int CustomerNumber;

    //the player's script
    public PlayerScript Player;

    public GameObject DirtyPlate;

    public GameObject MeatSmoothie;
    public GameObject BambooHotdog;

    public Dialogue DialogueScript;
    public Interact InteractScript;
    public Tutorial TutorialScript;

    void Start()
    {
        position = gameObject.transform.position; //Get the customers position
        StartCoroutine(HappinessValue());

    }

    void Update()
    {
        
        if(overallhappinessvalue < 0) //if the overall happiness reaches 0
        {
            DayFinished.SetActive(true); //end the game
        }

        if(DayBegin) //if day begin is true, the customer can start moving
        {
            movingtofoh = true;
            DayBegin = false;
        }
        
        float step = speed * Time.deltaTime;

        if(movingtofoh) //if the player is moving to the front of house
        {
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, FoHtarget.transform.position, step);

            if (!MovingtoDesk)
            {
                StartCoroutine(DeskWait());
                MovingtoDesk = true;
            }
        }

        if(movingtotable) //if the player is moving towards the table
        {
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, DeskTarget.transform.position, step);

            if (!WaitingatTable)
            {
                StartCoroutine(ThoughtWait());
                WaitingatTable = true;
            }
        }

        if(Leaving) //if the customer has been fed and is leaving
        {
            transform.position = Vector2.MoveTowards(transform.position, LeavingArea.transform.position, step);
            transform.position = Vector2.MoveTowards(transform.position, LeavingArea.transform.position, step);

            if (transform.position == LeavingArea.transform.position)
            {
                Destroy(gameObject); //destory the customer
            }
        }
    }


    IEnumerator DeskWait() //waiting at the front of house desk - then they can move to the table
    {
        Debug.Log("DeskWait");
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        movingtofoh = false;
        TableFree = true;
        Debug.Log("DeskWaitDone");
        movingtotable = true;

    }

    IEnumerator ThoughtWait()//waiting at the table - then the thought bubble appears
    {
        Debug.Log("ThoughtWait");
        yield return new WaitForSeconds(8);
        movingtotable = false;
        TableFree = false;
        ThoughtBubble.SetActive(true);
        DialogueScript.AbletoTalk = true;
        Debug.Log("ThoughtWaitDone");


    }

    IEnumerator HappinessValue()
    {
        yield return new WaitForSeconds(1f);
        overallhappinessvalue = overallhappinessvalue - 0.0025f;
        OverallHappiness.value = overallhappinessvalue;
        StartCoroutine(HappinessValue());
    }

    public void FedSmoothie() //if the customer has been fed
    {
        MeatSmoothie.SetActive(true);
        StartCoroutine(Eating1());

    }

    public void FedMeal() //if the customer has been fed
    {
        BambooHotdog.SetActive(true);
        StartCoroutine(Eating2());
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "LeavingArea") //when the customer collides with the leaving area (an off screen zone)
        {
            Destroy(gameObject); //destroy the customer
        }
    }

    IEnumerator Eating1()
    {
        yield return new WaitForSeconds(6f);
        DirtyPlate.SetActive(true);
        MeatSmoothie.SetActive(false);
        BambooHotdog.SetActive(false);
        DialogueScript.AbletoTalk = true;
        DialogueScript.BambooHotdogThought.SetActive(true);
        DialogueScript.ThinkBubble.SetActive(true);
        DialogueScript.MealTime = true;
        if (TutorialScript.TutorialImages == 20)
        {
            TutorialScript.NextTutorial();
        }
    }

    IEnumerator Eating2()
    {
        yield return new WaitForSeconds(6f);
        DirtyPlate.SetActive(true);
        MeatSmoothie.SetActive(false);
        BambooHotdog.SetActive(false);
        InteractScript.Washup2 = true;
        Leaving = true;

        TutorialScript.NextTutorial();

    }
}
 