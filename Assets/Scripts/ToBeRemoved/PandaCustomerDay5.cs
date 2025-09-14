using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

//This script is on the customer, controlling their movement and happiness

/// <summary>
/// Panda Customer
/// Tutorial and Day 5
/// </summary>
public class PandaCustomerDay5 : MonoBehaviour
{
    //Speed and location variables
    private float speed = 8.0f; //customer speed
    public GameObject FoHtarget; //front of house desk target
    public Vector2 position; //the customers position
    public GameObject DeskTarget; //the table target
    public GameObject LeavingArea; //the leaving area

    //Bools which control where the customer goes
    public bool movingtofoh;
    public bool movingtotable;

    //Their thought bubble
    public GameObject ThoughtBubble;

    //Bools to check what they are doing
    public bool MovingtoDesk;
    public bool WaitingatTable;

    //Happiness variables
    public Slider OverallHappiness;

    //If the customers leaving
    public bool Leaving;

    public GameObject GameFinished; //game finished gameobject

    public GameObject DirtyPlate; //dirty plate

    public GameObject MeatSmoothie; //meat smoothie that the panda eats
    public GameObject BambooHotdog; //bamboo hotdog that the panda eats

    public GameObject Coins; //coins

    public Dialogue DialogueScript; //dialogue script

    public AudioSource PlateDrop;
    public AudioSource AnimalEating;

    public GameObject BatCustomer;
    void Start()
    {
        position = gameObject.transform.position; //Get the customers position
        StartCoroutine(HappinessValue()); //start the happiness bar timer
        movingtofoh = true; //start moving to the front of house desk
    }

    void Update()
    {
        if (OverallHappiness.value < 0) //if the overall happiness reaches 0
        {
            GameFinished.SetActive(true); //end the game
        }

        float step = speed * Time.deltaTime; //customer speed 

        if(movingtofoh) //if the player is moving to the front of house
        {
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, FoHtarget.transform.position, step);

            if (!MovingtoDesk && !BatCustomer.activeSelf) //if the player isnt moving to the desk
            {
                StartCoroutine(DeskWait()); //start the coroutine
                MovingtoDesk = true; //set moving to desk to true
            }
        }

        if(movingtotable) //if the player is moving towards the table
        {
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, DeskTarget.transform.position, step);

            if (!WaitingatTable) //if the player isnt waiting at the table
            {
                StartCoroutine(ThoughtWait()); //start the coroutine
                WaitingatTable = true; //set moving to table to true
            }
        }

        if(Leaving) //if the customer has been fed and is leaving
        {
            transform.position = Vector2.MoveTowards(transform.position, LeavingArea.transform.position, step);

            StartCoroutine((PandaLeaving()));

            if (transform.position == LeavingArea.transform.position) //if the player is at the same position as the leaving area
            {
                gameObject.SetActive(false);
            }
        }
    }

    IEnumerator PandaLeaving() //waiting at the front of house desk - then they can move to the table
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false); //destroy the customer

    }
    IEnumerator DeskWait() //waiting at the front of house desk - then they can move to the table
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        movingtofoh = false; 
        movingtotable = true;

    }

    IEnumerator ThoughtWait()//waiting at the table - then the thought bubble appears
    {
        yield return new WaitForSeconds(6);
        movingtotable = false;
        ThoughtBubble.SetActive(true);
        DialogueScript.AbletoTalk = true;
    }

    IEnumerator HappinessValue() //happiness timer
    {
        yield return new WaitForSeconds(1f);
        OverallHappiness.value = OverallHappiness.value - 0.0025f;
        StartCoroutine(HappinessValue());
    }

    public void FedSmoothie() //if the customer has been fed
    {
        MeatSmoothie.SetActive(true); //enable the meat smoothie on the table
        DialogueScript.PandaDrink2 = false; //disable panda drink bool, as the panda has been served
        StartCoroutine(Eating1());

    }

    public void FedMeal() //if the customer has been fed
    {
        BambooHotdog.SetActive(true); //enable the bamboo hotdog on the table
        StartCoroutine(Eating2());
        DialogueScript.PandaMeal2 = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "LeavingArea") //when the customer collides with the leaving area (an off screen zone)
        {
            gameObject.SetActive(false); //destroy the customer
        }
    }

    IEnumerator Eating1() //first eating coroutine
    {
        AnimalEating.Play(); //play animal eating noise 
        yield return new WaitForSeconds(6f); //wait 6 seconds
        DirtyPlate.SetActive(true); //spawn dirty plate on the table
        Coins.SetActive(true); //spawn coins on the table
        MeatSmoothie.SetActive(false);
        DialogueScript.AbletoTalk = true; //set able to talk to true, so the panda can order bamboo hotdog
        DialogueScript.ThoughtIcons[2].SetActive(true); //enable next thought bubble and icon
        DialogueScript.ThinkBubble[1].SetActive(true);
        DialogueScript.PandaMeal2 = true; //set panda meal 1 to true
        PlateDrop.Play(); //play plate drop noise 
    }

    IEnumerator Eating2() //second eating coroutine
    {
        AnimalEating.Play();
        yield return new WaitForSeconds(6f); //wait 6 seconds
        DirtyPlate.SetActive(true);
        BambooHotdog.SetActive(false);
        Coins.SetActive(true);
        PlateDrop.Play();
        Leaving = true; //make the customer leave
        DialogueScript.PandaDone = true;
    }
}
 