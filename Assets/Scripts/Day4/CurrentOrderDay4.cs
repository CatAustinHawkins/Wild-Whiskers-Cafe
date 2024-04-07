using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//This script is used to show the current order that the player is making

public class CurrentOrderDay4 : MonoBehaviour
{

    public AudioSource ButtonClick;
    public GameObject ButtonSource;
    public PlayerScript Player; //To access the players script

    public GameObject Order; //The first order

    public Image OrderForm;

    public Sprite BlankOrder;
    public Sprite GemsbokOrderMS; //order 1
    public Sprite GemsbokOrderPM; //order 2
    public Sprite IbexOrderLF; //order 3
    public Sprite DuckOrderE;
    public Sprite PangolinOrderAS;
    public Sprite PangolinOrderAP;
    public Sprite ChipmunkRM;

    public bool OrderOpen; //Check if the order is open or not

    public bool TimerRunning;

    public GameObject PlayerGO;
    public PlayerScript player;

    public void Start()
    {
        ButtonSource = GameObject.FindWithTag("ButtonSound");
        ButtonClick = ButtonSource.GetComponent<AudioSource>();

        PlayerGO = GameObject.FindWithTag("Player");
        player = PlayerGO.GetComponent<PlayerScript>();
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.C) && !TimerRunning)
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

            //check which customer the player is currently serving
            if (Player.CurrentOrder == 1)
            {
                OrderForm.sprite = GemsbokOrderMS;  //activate the relevant order form
                Order.SetActive(true);
                OrderOpen = true; //set order open to true
            }
            if (Player.CurrentOrder == 2)
            {
                OrderForm.sprite = GemsbokOrderPM;  //activate the relevant order form
                Order.SetActive(true);
                OrderOpen = true; //set order open to true

            }
            if (Player.CurrentOrder == 3)
            {
                OrderForm.sprite = IbexOrderLF;  //activate the relevant order form
                Order.SetActive(true);
                OrderOpen = true; //set order open to true
            }
            if (Player.CurrentOrder == 4)
            {
                OrderForm.sprite = DuckOrderE;  //activate the relevant order form
                Order.SetActive(true);
                OrderOpen = true; //set order open to true
            }
            if (Player.CurrentOrder == 5)
            {
                OrderForm.sprite = PangolinOrderAS;  //activate the relevant order form
                Order.SetActive(true);
                OrderOpen = true; //set order open to true

            }
            if (Player.CurrentOrder == 6)
            {
                OrderForm.sprite = PangolinOrderAP;  //activate the relevant order form
                Order.SetActive(true);
                OrderOpen = true; //set order open to true
            }
            if (Player.CurrentOrder == 7)
            {
                OrderForm.sprite = ChipmunkRM;  //activate the relevant order form
                Order.SetActive(true);
                OrderOpen = true; //set order open to true
            }
        }
        else //if the order form is open
        {

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