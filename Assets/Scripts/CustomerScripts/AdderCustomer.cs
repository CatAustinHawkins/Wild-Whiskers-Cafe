using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script is on the customer, controlling their movement and happiness.
/// Day 1 Adder
/// 1 Meal
/// </summary>
 
public class AdderCustomer : MonoBehaviour
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

    public GameObject MouseBurger; //REPLACE WITH FOOD

    public GameObject Coins; //coins

    public Dialogue DialogueScript; //dialogue script

    public GameObject LeopardCustomer; //REPLACE WITH SPAWNED CUSTOMER

    public AudioSource PlateDrop;
    public AudioSource AnimalEating;


    void Start()
    {
        position = gameObject.transform.position; //Get the customers position
        StartCoroutine(HappinessValue());
        StartCoroutine(LeopardSpawn());

        movingtofoh = true; //start moving to the front of house desk

        DialogueScript.AdderMeal = true;
    }

    void Update()
    {
        if (OverallHappiness.value < 0) //if the overall happiness reaches 0
        {
            GameFinished.SetActive(true); //end the game
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

            StartCoroutine(AdderLeaving());

            if (transform.position == LeavingArea.transform.position)
            {
                gameObject.SetActive(false); //destory the customer
            }
        }
    }
    IEnumerator AdderLeaving() //waiting at the front of house desk - then they can move to the table
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false); //destroy the customer
    }

    IEnumerator DeskWait() //waiting at the front of house desk - then they can move to the table
    {
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

    IEnumerator HappinessValue()
    {
        yield return new WaitForSeconds(1f);
        OverallHappiness.value = OverallHappiness.value - 0.0025f;
        StartCoroutine(HappinessValue());
    }


    public void FedMeal() //if the customer has been fed
    {
        MouseBurger.SetActive(true);
        StartCoroutine(Eating1());
        DialogueScript.AdderMeal = false;
        DialogueScript.AdderDone = true;
        DialogueScript.LeopardDrink = true;
        DialogueScript.AbletoTalk = true;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "LeavingArea") //when the customer collides with the leaving area (an off screen zone)
        {
            gameObject.SetActive(false);
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

    IEnumerator LeopardSpawn()
    {
        yield return new WaitForSeconds(30f);
        LeopardCustomer.SetActive(true);
    }
}
 