using UnityEngine;
using System.Collections;

//This script is on the fridge

public class Fridge : MonoBehaviour
{
    public GameObject BambooIcon; //the Bamboo Icon gameobject
    public GameObject BreadIcon; //the Bread Icon gameobject
    public GameObject MeatIcon; 

    public bool HoldingBamboo; //if the player is holding bamboo or not
    public bool HoldingBread; //if the player is holding bread or not
    public bool HoldingMeat;


    public Tutorial TutorialScript;
    public Interact InteractScript;

    public GameObject LeftHandUI;
    public GameObject RightHandUI;
    public GameObject BothHandUI;

    public GameObject HoldingBambooGO; //if the player is holding bamboo or not
    public GameObject HoldingBreadGO; //if the player is holding bread or not
    public GameObject HoldingMeatGO;



    public void BambooButton() //This button is on the bamboo icon 
    {
        if(!InteractScript.PlayerLeftHandFull)
        {
            BambooIcon.SetActive(true); //when its clicked, enable the bamboo icon (which the player holds)
            HoldingBamboo = true; //set holding bamboo to true
            InteractScript.PlayerLeftHandFull = true;
            HoldingBambooGO.SetActive(true);
        }
        else
        {
            InteractScript.StartCoroutine(HandUITimer());
        }
        

    }

    public void BreadButton() //This button is on the bread icon
    {
        if(InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            BreadIcon.SetActive(true); //when its clicked, enable the bread icon (which the player holds)
            HoldingBread = true; //set holding bread to true
            HoldingBreadGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }

    }

    public void MeatButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MeatIcon.SetActive(true);
            HoldingMeat = true;
            HoldingMeatGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;

            if (TutorialScript.TutorialImages == 16)
            {
                TutorialScript.NextTutorial();
            }
        }

    }
    public void Update()
    {
        if(HoldingBamboo && HoldingBread && TutorialScript.TutorialImages == 25) /////
        {
            TutorialScript.NextTutorial();
        }
    }

    public IEnumerator HandUITimer()
    {
        if(InteractScript.PlayerLeftHandFull)
        {
            LeftHandUI.SetActive(true);
        }

        if(InteractScript.PlayerRightHandFull)
        {
            RightHandUI.SetActive(true);
        }

        if(InteractScript.PlayerRightHandFull && InteractScript.PlayerLeftHandFull)
        {
            BothHandUI.SetActive(true);
        }

        yield return new WaitForSecondsRealtime(3);
        LeftHandUI.SetActive(false);
        RightHandUI.SetActive(false);
        BothHandUI.SetActive(false);
    }
}
