using UnityEngine;

public class Interact : MonoBehaviour
{

    [Header("Bools")]
    public bool OvenInRange; //same as chopping board
    public bool ChoppingBoardInRange; //check if player has food, if they do then they can make the meal
    public bool FridgeInRange; //Opens up the fridge UI window

    public bool FridgeOpen;
    public bool FoodCooked;
    public bool MealReady;
    public bool PandaInRange;

    [Header("Oven Assets")]
    public GameObject OvenPopup;


    [Header("Fridge Assets")]
    public GameObject FridgeUI;
    public Fridge FridgeScript;

    public GameObject Bread;
    public GameObject Bamboo;
    public GameObject CookedBamboo;
    public GameObject BambooHotdog;

    public CustomerTest CustomerTestScript;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Oven")
        {
            OvenInRange = true;
            Debug.Log("Player at Oven");
        }

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

            if(FridgeScript.HoldingBamboo)
            {
                Bamboo.SetActive(false);
                CookedBamboo.SetActive(true);
                FoodCooked = true;
            }
        }

        if(FridgeInRange)
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
            if(FoodCooked)
            {
                CookedBamboo.SetActive(false);
                Bread.SetActive(false);
                BambooHotdog.SetActive(true);
                MealReady = true;
            }
        }

        if(PandaInRange)
        {
            if (MealReady)
            {
                BambooHotdog.SetActive(false);
                CustomerTestScript.Fed();
            }
        }
    }

}
