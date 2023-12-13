using UnityEngine;

//This script is used on the Interact button, to see if the player can interact with the objects around them

public class Interact : MonoBehaviour
{

    [Header("Bools")]
    public bool OvenInRange; //if the oven is in range
    public bool ChoppingBoardInRange; //if the chopping board is in range
    public bool FridgeInRange; //if the fridge is in range

    public bool FridgeOpen; //is the fridge window open
    public bool FoodCooked; //is the food cooked
    public bool MealReady; //is the meal ready
    public bool PandaInRange; //is the player in range of the panda


    [Header("Fridge Assets")]
    public GameObject FridgeUI; //fridge ui window
    public Fridge FridgeScript; //fridge script

    public GameObject Bread; //bread gameobject that the player holds
    public GameObject Bamboo; //bamboo gameobject that the player holds
    public GameObject CookedBamboo; //cooked bamboo gameobject that the player holds
    public GameObject BambooHotdog; //bamboo hotdog gameobject that the player holds

    public CustomerTest CustomerTestScript; //customer script
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Oven") //check if the player is colliding with the oven
        {
            OvenInRange = true; //set oven in range to true
            Debug.Log("Player at Oven");
        }

        //same for the other game objects
        if (other.tag == "Fridge")
        {
            FridgeInRange = true;
            Debug.Log("Player at Fridge");
        }

        if (other.tag == "ChoppingBoard")
        {
            ChoppingBoardInRange = true;
        }

        if(other.tag == "PandaCustomer")
        {
            PandaInRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        //when the player stops colliding with these tags change their bools
        if(other.tag == "Oven")
        {
            OvenInRange = false;
            Debug.Log("Player left Oven");
        }

        if (other.tag == "Fridge")
        {
            FridgeInRange = false;
            Debug.Log("Player at Fridge");
        }

        if(other.tag == "ChoppingBoard")
        {
            ChoppingBoardInRange = false;
        }
        if (other.tag == "PandaCustomer")
        {
            PandaInRange = false;
        }

    }

    public void InteractButton()
    {
        if(OvenInRange)
        {
            //check what food the player has

            if(FridgeScript.HoldingBamboo) //if the players holding bamboo
            {
                Bamboo.SetActive(false);
                CookedBamboo.SetActive(true); //make them hold cooked bamboo instead
                FoodCooked = true;
            }
        }

        if(FridgeInRange) //open the fridge UI
        {
            if(!FridgeOpen)
            {
                FridgeUI.SetActive(true);
                FridgeOpen = true;
            }
            else
            {
                FridgeUI.SetActive(false);
                FridgeOpen = false;
            }
        }

        if(ChoppingBoardInRange)
        {
            if(FoodCooked) //if the food is cooked
            {
                CookedBamboo.SetActive(false);
                Bread.SetActive(false);
                BambooHotdog.SetActive(true); //enable the bamboo hotdog gameobject
                MealReady = true;
            }
        }

        if(PandaInRange)
        {
            if (MealReady) //when the meal is cooked
            {
                BambooHotdog.SetActive(false); //disable the bamboo hotdog
                CustomerTestScript.Fed();//call to the customer script
            }
        }
    }

}
