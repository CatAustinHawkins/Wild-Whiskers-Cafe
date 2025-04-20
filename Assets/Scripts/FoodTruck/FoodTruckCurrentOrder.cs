using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//This script is used to show the current order that the player is making

public class FoodTruckCurrentOrder : MonoBehaviour
{
    public AudioSource ButtonClick; //button click audio
    public GameObject ButtonSource; //gameobject with the button click audio attached

    public PlayerScript Player; //To access the players script

    public GameObject Order; //The order gameobject 

    public Image OrderForm; //the image of the orderform, which gets its sprite changed

    public bool OrderOpen; //Check if the order is open or not

    public bool TimerRunning;  //timer running bool

    public void Start()
    {
        ButtonSource = GameObject.FindWithTag("ButtonSound"); //locate buttonsource gameobject
        ButtonClick = ButtonSource.GetComponent<AudioSource>(); //locate audio source component 
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.C) && !TimerRunning)
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
            Order.SetActive(true);
            OrderOpen = true; //set order open to true
        }

        else //if the order form is open
        {
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