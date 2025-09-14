using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//This script is used to show the current order that the player is making

public class CurrentOrder : MonoBehaviour
{
    public AudioSource ButtonClick; //button click audio
    public GameObject ButtonSource; //gameobject with the button click audio attached

    public PlayerScript Player; //To access the players script

    public GameObject Order; //The order gameobject 

    public Image OrderForm; //the image of the orderform, which gets its sprite changed

    public Sprite[] Orders;
    //Tutorial - Orders 0 and 1
    //Day 1 - Orders 2, 3 and 4
    //Day 2 - Orders 5, 6, 7, 8 and 8
    //Day 3 - Orders 10, 11, 12, 13, 14 and 15
    //Day 4 - Orders 16, 17, 18, 19 , 20, 21 and 22
    //Day 5 - Orders 23, 24, 25, 26, 28, 29, 30 and 31

    public bool OrderOpen; //Check if the order is open or not

    public bool TimerRunning;  //timer running bool

    public Tutorial TutorialScript;

    public void Start()
    {
        ButtonSource = GameObject.FindWithTag("ButtonSound"); //locate buttonsource gameobject
        ButtonClick = ButtonSource.GetComponent<AudioSource>(); //locate audio source component 
    }
    public void Update()
    {
        if(Input.GetKey(KeyCode.C) && !TimerRunning)
        {
            ButtonClick.Play(); //play button click noise
            Clicked();
            StartCoroutine(DelayTime());
        }
    }

    public void Clicked() //UIBook Button
    {
        if (!OrderOpen) //if the order form is not currently open
        {
            ButtonClick.Play(); //play button click noise

            if (TutorialScript.TutorialImages == 10 || TutorialScript.TutorialImages == 24)//if current tutorial prompt is 10 or 24
            {
                TutorialScript.NextTutorial(); //show the next tutorial
            }

            OrderForm.sprite = Orders[Player.CurrentOrder];
            Order.SetActive(true);
            OrderOpen = true;
        }

        else //if the order form is open
        {
            if (TutorialScript.TutorialImages == 11)//if current tutorial prompt is 11
            {
                TutorialScript.NextTutorial(); //show the next tutorial
            }
            Order.SetActive(false); //close the relevant order form
            OrderOpen = false; //set order open to false
        }
    }

    IEnumerator DelayTime() //this coroutine is to prevent glitches when the player opens the current order
    {
        TimerRunning = true; //timer running is true
        yield return new WaitForSeconds(0.25f); //wait 0.25 seconds
        TimerRunning = false; //timer running is false
    }
}
