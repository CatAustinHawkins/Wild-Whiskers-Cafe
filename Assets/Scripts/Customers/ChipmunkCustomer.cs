using System.Collections;
using UnityEngine;
using UnityEngine.UI;

//This script is on the customer, controlling their movement and happiness

/// <summary>
/// Chipmunk Customer
/// Day 4
/// 1 Meal
/// </summary>

public class ChipmunkCustomer : MonoBehaviour
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

    public GameObject MouseBurger;

    public GameObject Coins;


    public Dialogue DialogueScript;
    public Interact InteractScript;

    public AudioSource PlateDrop;
    public AudioSource AnimalEating;

    public GameObject Dialogue;
    public GameObject Interact;

    void Start()
    {
        position = gameObject.transform.position; //Get the customers position
        StartCoroutine(HappinessValue());
        DayBegin = true;


        Destroy(Interact);
        Destroy(Dialogue);
    }

    void Update()
    {

        if (overallhappinessvalue < 0) //if the overall happiness reaches 0
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

            //call to leopard script
        }
    }


    IEnumerator DeskWait() //waiting at the front of house desk - then they can move to the table
    {
        yield return new WaitForSeconds(5);
        movingtofoh = false;
        TableFree = true;
        movingtotable = true;

    }

    IEnumerator ThoughtWait()//waiting at the table - then the thought bubble appears
    {
        yield return new WaitForSeconds(6);
        movingtotable = false;
        TableFree = false;
        ThoughtBubble.SetActive(true);
        DialogueScript.AbletoTalk = true;
        DialogueScript.AdderMeal = true;
    }

    IEnumerator HappinessValue()
    {
        yield return new WaitForSeconds(1f);
        overallhappinessvalue = overallhappinessvalue - 0.0025f;
        OverallHappiness.value = overallhappinessvalue;
        StartCoroutine(HappinessValue());
    }


    public void FedMeal() //if the customer has been fed
    {
        MouseBurger.SetActive(true);
        StartCoroutine(Eating1());
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
        AnimalEating.Play();
        yield return new WaitForSeconds(6f);
        DirtyPlate.SetActive(true);
        Coins.SetActive(true);
        MouseBurger.SetActive(false);
        PlateDrop.Play();
        Leaving = true;
    }

}
 