using System.Collections;
using UnityEngine;
using UnityEngine.UI;

//This script is on the customer, controlling their movement and happiness

/// <summary>
/// Leopard Customer
/// Day 1 
/// 2 Meals
/// </summary>
public class LeopardCustomer : MonoBehaviour
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

    public GameObject VenisonSteak; //meat smoothie that the panda eats
    public GameObject MeatSmoothie;

    public GameObject Coins; //coins

    public Dialogue DialogueScript; //dialogue script

    public AudioSource PlateDrop;
    public AudioSource AnimalEating;

    void Start()
    {
        position = gameObject.transform.position; //Get the customers position

        StartCoroutine(HappinessValue());

        movingtofoh = true; //start moving to the front of house desk
    }

    void Update()
    {

        if (OverallHappiness.value < 0) //if the overall happiness reaches 0
        {
            GameFinished.SetActive(true); //end the game
        }

        float step = speed * Time.deltaTime;

        if (movingtofoh) //if the player is moving to the front of house
        {
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, FoHtarget.transform.position, step);

            if (!MovingtoDesk)
            {
                StartCoroutine(DeskWait());
                MovingtoDesk = true;
            }
        }

        if (movingtotable) //if the player is moving towards the table
        {
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, DeskTarget.transform.position, step);

            if (!WaitingatTable)
            {
                StartCoroutine(ThoughtWait());
                WaitingatTable = true;
            }
        }

        if (Leaving) //if the customer has been fed and is leaving
        {
            transform.position = Vector2.MoveTowards(transform.position, LeavingArea.transform.position, step);

            StartCoroutine(LeopardLeaving());

            if (transform.position == LeavingArea.transform.position)
            {
                gameObject.SetActive(false);
            }
        }
    }
    IEnumerator LeopardLeaving() //waiting at the front of house desk - then they can move to the table
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
        DialogueScript.LeopardDrink = true;
    }

    IEnumerator HappinessValue()
    {
        yield return new WaitForSeconds(1f);
        OverallHappiness.value = OverallHappiness.value - 0.0025f;
        StartCoroutine(HappinessValue());
    }

    public void FedSmoothie() //if the customer has been fed
    {
        MeatSmoothie.SetActive(true);
        DialogueScript.LeopardDrink = false;
        StartCoroutine(Eating1());
    }

    public void FedMeal() //if the customer has been fed
    {
        VenisonSteak.SetActive(true);
        DialogueScript.LeopardMeal = false;
        StartCoroutine(Eating2());
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LeavingArea") //when the customer collides with the leaving area (an off screen zone)
        {
            gameObject.SetActive(false); //destroy the customer
        }
    }

    IEnumerator Eating1()
    {
        AnimalEating.Play();
        yield return new WaitForSeconds(6f);
        DirtyPlate.SetActive(true);
        Coins.SetActive(true);
        MeatSmoothie.SetActive(false);
        DialogueScript.ThoughtIcons[5].SetActive(true); //enable next thought bubble and icon
        DialogueScript.ThinkBubble[3].SetActive(true);
        DialogueScript.AbletoTalk = true;
        DialogueScript.LeopardMeal = true;
        PlateDrop.Play();
    }

    IEnumerator Eating2() //second eating coroutine
    {
        AnimalEating.Play();
        yield return new WaitForSeconds(6f); //wait 6 seconds
        DirtyPlate.SetActive(true);
        VenisonSteak.SetActive(false);
        Coins.SetActive(true);
        PlateDrop.Play();
        Leaving = true; //make the customer leave
        DialogueScript.LeopardDone = true;
    }
}
 