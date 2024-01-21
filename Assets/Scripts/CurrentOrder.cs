using UnityEngine;
using System.Collections;

//This script is used to show the current order that the player is making

public class CurrentOrder : MonoBehaviour
{

    private IEnumerator coroutine;


    public PlayerScript Player; //To access the players script

    public GameObject Order1; //The first order
    public GameObject Order2; //The second order
    public GameObject Order3; //The third order

    public bool OrderOpen; //Check if the order is open or not

    public bool TimerRunning;


    public void Update()
    {
        if(Input.GetKey(KeyCode.Alpha2) && !TimerRunning)
        {
            Clicked();
            StartCoroutine(DelayTime());
        }

        if (Input.GetKey(KeyCode.Escape) && OrderOpen)
        {
            Clicked();
        }
    }

    public void Clicked() //UIBook Button
    {
        if(!OrderOpen) //if the order form is not currently open
        {
            //check which customer the player is currently serving
            if(Player.CurrentCustomer == 1)
            {
                Order1.SetActive(true); //activate the relevant order form
                OrderOpen = true; //set order open to true
            }
            if(Player.CurrentCustomer == 2)
            {
                Order2.SetActive(true);
                OrderOpen = true;

            }
            if (Player.CurrentCustomer == 3)
            {
                Order3.SetActive(true);
                OrderOpen = true;

            }
        }
        else //if the order form is open
        {
            //check which customer the player is currently serving
            if (Player.CurrentCustomer == 1)
            {
                Order1.SetActive(false); //close the relevant order form
                OrderOpen = false; //set order open to false

            }
            if (Player.Recipe2InProgress)
            {
                Order2.SetActive(false);
                OrderOpen = false;

            }
            if (Player.Recipe3InProgress)
            {
                Order3.SetActive(false);
                OrderOpen = false;

            }
        }
    }

    IEnumerator DelayTime()
    {
        TimerRunning = true;
        yield return new WaitForSeconds(0.25f);
        TimerRunning = false;
    }
}
