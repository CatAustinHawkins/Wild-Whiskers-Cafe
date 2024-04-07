using UnityEngine;
using System.Collections;

//This script is on the fridge

public class FridgeDay1 : MonoBehaviour
{
    public GameObject BambooIcon; //the Bamboo Icon gameobject
    public GameObject BreadIcon; //the Bread Icon gameobject
    public GameObject MeatIcon; 

    public bool HoldingBamboo; //if the player is holding bamboo or not
    public bool HoldingBread; //if the player is holding bread or not
    public bool HoldingMeat;

    public Interact InteractScriptDay1;

    public GameObject LeftHandUI;
    public GameObject RightHandUI;
    public GameObject BothHandUI;

    public GameObject HoldingBambooGO; //if the player is holding bamboo or not
    public GameObject HoldingBreadGO; //if the player is holding bread or not
    public GameObject HoldingMeatGO;



    public void BambooButton() //This button is on the bamboo icon 
    {
        if(!InteractScriptDay1.PlayerLeftHandFull)
        {
            BambooIcon.SetActive(true); //when its clicked, enable the bamboo icon (which the player holds)
            HoldingBamboo = true; //set holding bamboo to true
            InteractScriptDay1.PlayerLeftHandFull = true;
            HoldingBambooGO.SetActive(true);
        }
        else
        {
            InteractScriptDay1.StartCoroutine(HandUITimer());
        }
        

    }

    public void BreadButton() //This button is on the bread icon
    {
        if(InteractScriptDay1.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            BreadIcon.SetActive(true); //when its clicked, enable the bread icon (which the player holds)
            HoldingBread = true; //set holding bread to true
            HoldingBreadGO.SetActive(true);

            InteractScriptDay1.PlayerRightHandFull = true;
        }

    }

    public void MeatButton()
    {
        if (InteractScriptDay1.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MeatIcon.SetActive(true);
            HoldingMeat = true;
            HoldingMeatGO.SetActive(true);

            InteractScriptDay1.PlayerRightHandFull = true;

        }

    }

    public IEnumerator HandUITimer()
    {
        if(InteractScriptDay1.PlayerLeftHandFull)
        {
            LeftHandUI.SetActive(true);
        }

        if(InteractScriptDay1.PlayerRightHandFull)
        {
            RightHandUI.SetActive(true);
        }

        if(InteractScriptDay1.PlayerRightHandFull && InteractScriptDay1.PlayerLeftHandFull)
        {
            BothHandUI.SetActive(true);
        }

        yield return new WaitForSecondsRealtime(3);
        LeftHandUI.SetActive(false);
        RightHandUI.SetActive(false);
        BothHandUI.SetActive(false);
    }
}
