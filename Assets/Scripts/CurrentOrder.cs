using UnityEngine;
using System.Collections;

//This script is used to show the current order that the player is making

public class CurrentOrder : MonoBehaviour
{


    public PlayerScript Player; //To access the players script

    public GameObject Order; //The first order

    public SpriteRenderer OrderForm;

    public Sprite BlankOrder;
    public Sprite PandaOrderMS;
    public Sprite PandaOrderBH;
    

    public bool OrderOpen; //Check if the order is open or not

    public bool TimerRunning;

    public Tutorial TutorialScript;
    public PlayerScript player;


    public void Update()
    {
        if(Input.GetKey(KeyCode.C) && !TimerRunning)
        {
            Clicked();
            StartCoroutine(DelayTime());
        }
    }

    public void Clicked() //UIBook Button
    {

        player.target = player.transform.position;

        if (!OrderOpen) //if the order form is not currently open
        {
            if(TutorialScript.TutorialImages == 10 || TutorialScript.TutorialImages == 24)
            {
                TutorialScript.NextTutorial();
            }
            //check which customer the player is currently serving
            if(Player.CurrentOrder == 1)
            {
                OrderForm.sprite = PandaOrderMS;  //activate the relevant order form
                Order.SetActive(true);
                OrderOpen = true; //set order open to true
            }
            if (Player.CurrentOrder == 2)
            {
                OrderForm.sprite = PandaOrderBH;  //activate the relevant order form
                Order.SetActive(true);
                OrderOpen = true; //set order open to true

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
