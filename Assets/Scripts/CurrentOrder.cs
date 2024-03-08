using UnityEngine;
using System.Collections;

//This script is used to show the current order that the player is making

public class CurrentOrder : MonoBehaviour
{


    public PlayerScript Player; //To access the players script

    public GameObject Order1; //The first order
    public GameObject Order2; //The first order


    public bool OrderOpen; //Check if the order is open or not

    public bool TimerRunning;

    public Tutorial TutorialScript;
    public PlayerScript player;

    public GameObject OrderBackground;

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
                Order1.SetActive(true); //activate the relevant order form
                OrderOpen = true; //set order open to true
                OrderBackground.SetActive(true);
            }
            if (Player.CurrentOrder == 2)
            {
                Order2.SetActive(true); //activate the relevant order form
                OrderOpen = true; //set order open to true
                OrderBackground.SetActive(true);

            }

        }
        else //if the order form is open
        {
            //check which customer the player is currently serving
            if (Player.CurrentOrder == 1)
            {
                if (TutorialScript.TutorialImages == 11)
                {
                    TutorialScript.NextTutorial();
                }
                Order1.SetActive(false); //close the relevant order form
                OrderOpen = false; //set order open to false
                OrderBackground.SetActive(false);

            }

            if (Player.CurrentOrder == 2)
            {
                Order2.SetActive(false); //close the relevant order form
                OrderOpen = false; //set order open to false
                OrderBackground.SetActive(false);

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
