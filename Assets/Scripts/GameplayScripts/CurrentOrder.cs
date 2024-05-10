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
            //check which customer the player is currently serving
            switch (Player.CurrentOrder)
            {
                case 0:
                    OrderForm.sprite = Orders[0];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 1:
                    OrderForm.sprite = Orders[1];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 2:
                    OrderForm.sprite = Orders[2];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 3:
                    OrderForm.sprite = Orders[3];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 4:
                    OrderForm.sprite = Orders[4];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 5:
                    OrderForm.sprite = Orders[5];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 6:
                    OrderForm.sprite = Orders[6];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 7:
                    OrderForm.sprite = Orders[7];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 8:
                    OrderForm.sprite = Orders[8];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 9:
                    OrderForm.sprite = Orders[9];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 10:
                    OrderForm.sprite = Orders[10];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 11:
                    OrderForm.sprite = Orders[11];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 12:
                    OrderForm.sprite = Orders[12];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 13:
                    OrderForm.sprite = Orders[13];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 14:
                    OrderForm.sprite = Orders[14];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 15:
                    OrderForm.sprite = Orders[15];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 16:
                    OrderForm.sprite = Orders[16];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 17:
                    OrderForm.sprite = Orders[17];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 18:
                    OrderForm.sprite = Orders[18];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 19:
                    OrderForm.sprite = Orders[19];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 20:
                    OrderForm.sprite = Orders[20];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 21:
                    OrderForm.sprite = Orders[21];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 22:
                    OrderForm.sprite = Orders[22];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 23:
                    OrderForm.sprite = Orders[23];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 24:
                    OrderForm.sprite = Orders[24];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 25:
                    OrderForm.sprite = Orders[25];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 26:
                    OrderForm.sprite = Orders[26];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 27:
                    OrderForm.sprite = Orders[27];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 28:
                    OrderForm.sprite = Orders[28];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 29:
                    OrderForm.sprite = Orders[29];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 30:
                    OrderForm.sprite = Orders[30];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 31:
                    OrderForm.sprite = Orders[31];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
                case 32:
                    OrderForm.sprite = Orders[32];  //activate the relevant order form
                    Order.SetActive(true);
                    OrderOpen = true; //set order open to true
                    break;
            }
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
