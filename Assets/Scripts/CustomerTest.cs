using System.Collections;
using UnityEngine;
using UnityEngine.UI;

//This script is on the customer, controlling their movement and happiness

public class CustomerTest : MonoBehaviour
{
    //Speed and location variables
    private float speed = 8.0f;
    public Vector3 FoHtarget;
    public Vector2 position;
    public Vector3 DeskTarget;
    public Vector3 LeavingArea;

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
    public bool DayBegin;

    //Happiness variables
    public Slider Happiness;
    public Slider OverallHappiness;
    public float happinessvalue = 1;
    public float overallhappinessvalue = 1;

    //If the customers leaving
    public bool Leaving;

    //Day finished UI screen
    public GameObject DayFinished;

    //Each customer has their own number to check which customer is currently in the cafe
    public int CustomerNumber;

    //the player's script
    public PlayerScript Player;


    void Start()
    {
        position = gameObject.transform.position; //Get the customers position
    }

    void Update()
    {

        Player.CurrentCustomer = CustomerNumber; //set the players variable to the current customer number so other scripts can use it
        
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
            transform.position = Vector2.MoveTowards(transform.position, FoHtarget, step);

            if (!MovingtoDesk)
            {
                StartCoroutine(DeskWait());
                MovingtoDesk = true;
            }
        }

        if(movingtotable) //if the player is moving towards the table
        {
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, DeskTarget, step);

            if (!WaitingatTable)
            {
                StartCoroutine(ThoughtWait());
                WaitingatTable = true;
            }
        }

        if(Leaving) //if the customer has been fed and is leaving
        {
            transform.position = Vector2.MoveTowards(transform.position, LeavingArea, step);
            transform.position = Vector2.MoveTowards(transform.position, LeavingArea, step);

            if (transform.position == LeavingArea)
            {
                Destroy(gameObject); //destory the customer
                DayFinished.SetActive(true); //enable the day finished ui window

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
        Debug.Log("ThoughtWaitDone");


    }

    public void Fed() //if the customer has been fed
    {
        Leaving = true; //they can leave
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "LeavingArea") //when the customer collides with the leaving area (an off screen zone)
        {
            DayFinished.SetActive(true); //enable the day finished UI Window
            Destroy(gameObject); //destroy the customer
        }
    }
}
