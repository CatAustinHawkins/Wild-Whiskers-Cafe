using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CustomerTest : MonoBehaviour
{

    private float speed = 8.0f;
    public Vector3 FoHtarget;
    public Vector3 DeskTarget;
    private Vector2 position;
    public Vector3 LeavingArea;

    public bool TableFree;
    public bool movingtofoh;
    public bool movingtotable;
    public bool stoppedmoving;

    public GameObject ThoughtBubble;

    public bool MovingtoDesk;
    public bool WaitingatTable;

    public bool DayBegin;

    public Slider Happiness;
    public Slider OverallHappiness;
    public float happinessvalue = 1;
    public float overallhappinessvalue = 1;

    public bool Leaving;

    public GameObject NextCustomer;
    public GameObject DayFinished;

    public int CustomerNumber;

    public PlayerScript Player;

    public bool FoodReady;

    void Start()
    {
        StartCoroutine(HappinessDecrease());
        position = gameObject.transform.position;
        //movingtofoh = true;
    }

    void Update()
    {

        Player.CurrentCustomer = CustomerNumber;
        if(overallhappinessvalue < 0)
        {
            DayFinished.SetActive(true);
        }
        if(DayBegin)
        {
            movingtofoh = true;
            DayBegin = false;
        }
        float step = speed * Time.deltaTime;

        if(movingtofoh)
        {
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, FoHtarget, step);

            if(!MovingtoDesk)
            {
                StartCoroutine(DeskWait());
                MovingtoDesk = true;
            }
        }

        if(movingtotable)
        {
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, DeskTarget, step);

            if(!WaitingatTable)
            {
                StartCoroutine(ThoughtWait());
                WaitingatTable = true;
            }
        }

        if(Leaving)
        {
            transform.position = Vector2.MoveTowards(transform.position, LeavingArea, step);

            if(transform.position == LeavingArea)
            {
                NextCustomer.SetActive(true);
                Destroy(gameObject);
            }
        }
    }


    IEnumerator DeskWait()
    {
        Debug.Log("DeskWait");
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(4);
        movingtofoh = false;
        TableFree = true;
        Debug.Log("DeskWaitDone");
        movingtotable = true;

    }

    IEnumerator ThoughtWait()
    {
        Debug.Log("ThoughtWait");
        yield return new WaitForSeconds(7);
        movingtotable = false;
        TableFree = false;
        ThoughtBubble.SetActive(true);
        Debug.Log("ThoughtWaitDone");


    }

    IEnumerator HappinessDecrease()
    {
        happinessvalue = happinessvalue - 0.01f;
        overallhappinessvalue = overallhappinessvalue - 0.00333f;
        Happiness.value = happinessvalue;
        OverallHappiness.value = overallhappinessvalue;
        yield return new WaitForSeconds(1);
        if(happinessvalue < 0)
        {
            Leaving = true;
        }
        else
        {
            StartCoroutine(HappinessDecrease());
        }
    }

    public void Fed()
    {
        Leaving = true;
        if(CustomerNumber == 3)
        {
            DayFinished.SetActive(true);

        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "LeavingArea")
        {
            NextCustomer.SetActive(true);
            Destroy(gameObject);
        }
    }
}
