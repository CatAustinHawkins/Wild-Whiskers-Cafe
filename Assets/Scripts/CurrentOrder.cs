using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//This script is used to show the current order that the player is making

public class CurrentOrder : MonoBehaviour
{

    public AudioSource ButtonClick;
    public GameObject ButtonSource;
    public PlayerScript Player; //To access the players script

    public GameObject Order; //The first order

    public Image OrderForm;

    public Sprite[] Orders;
    //Tutorial - Orders 1 and 2
    //Day 1 - Orders 3, 4 and 5
    //Day 2 - Orders 6, 7, 8, 9 and 10
    //Day 3 - Orders 11, 12, 13, 14, 15 and 16
    //Day 4 - Orders 17, 18, 19, 20 , 21, 22 and 23
    //Day 5 - Orders 24, 25, 26, 27, 28, 30, 31 and 32

    public bool OrderOpen; //Check if the order is open or not

    public bool TimerRunning;

    public Tutorial TutorialScript;
    public PlayerScript player;

    public void Start()
    {
        ButtonSource = GameObject.FindWithTag("ButtonSound");
        ButtonClick = ButtonSource.GetComponent<AudioSource>();
    }
    public void Update()
    {
        if(Input.GetKey(KeyCode.C) && !TimerRunning)
        {
            ButtonClick.Play();
            Clicked();
            StartCoroutine(DelayTime());
        }
    }

    public void Clicked() //UIBook Button
    {

        player.target = player.transform.position;

        if (!OrderOpen) //if the order form is not currently open
        {
            ButtonClick.Play();

            if (TutorialScript.TutorialImages == 10 || TutorialScript.TutorialImages == 24)
            {
                TutorialScript.NextTutorial();
            }
            //check which customer the player is currently serving
           switch(Player.CurrentOrder)
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
                if (TutorialScript.TutorialImages == 11)
                {
                    TutorialScript.NextTutorial();
                }
                Order.SetActive(false); //close the relevant order form
                OrderOpen = false; //set order open to false
        }
    }

    IEnumerator DelayTime()
    {
        TimerRunning = true;
        yield return new WaitForSeconds(0.25f);
        TimerRunning = false;
    }
}
