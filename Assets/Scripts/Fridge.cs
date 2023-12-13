using UnityEngine;

//This script is on the fridge

public class Fridge : MonoBehaviour
{
    public GameObject BambooIcon; //the Bamboo Icon gameobject
    public GameObject BreadIcon; //the Bread Icon gameobject

    public bool HoldingBamboo; //if the player is holding bamboo or not
    public bool HoldingBread; //if the player is holding bread or not

    public void BambooButton() //This button is on the bamboo icon 
    {
        BambooIcon.SetActive(true); //when its clicked, enable the bamboo icon (which the player holds)
        HoldingBamboo = true; //set holding bamboo to true
    }

    public void BreadButton() //This button is on the bread icon
    {
        BreadIcon.SetActive(true); //when its clicked, enable the bread icon (which the player holds)
        HoldingBread = true; //set holding bread to true
    }

}
