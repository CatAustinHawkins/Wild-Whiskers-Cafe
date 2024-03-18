using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject[] ShopObjects;
    public GameObject[] Overlays;

    public Tutorial TutorialScript;

    public PlayerScript PlayerScript;

    //after player buys shop item, save value of the item to be saved and instaniated

    public void Start()
    {
        //check what items the player has previously bought 

    }

    public void FishtankBuy()
    {
        if (TutorialScript.TutorialImages == 5)
        {
            TutorialScript.NextTutorial();
        }

        ShopObjects[0].SetActive(true);
        Overlays[0].SetActive(true);
    }

    public void KiwiCrocodileBuy()
    {
        if(PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;
        }
    }

    public void PineappleHedgehogBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;
        }
    }

    public void AppleCrabBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;
        }
    }

    public void StrawberryMiceBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;
        }
    }

    public void AppleDogBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;
        }
    }

    public void DisplayTable1Buy()
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20)
        {
            PlayerScript.gold = PlayerScript.gold - 20;
        }
    }

    public void DisplayTable2Buy()
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20)
        {
            PlayerScript.gold = PlayerScript.gold - 20;
        }
    }

    public void AlienPlushBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;
        }
    }

    public void WardrobeBuy()
    {
        if (PlayerScript.gold > 15 || PlayerScript.gold == 15)
        {
            PlayerScript.gold = PlayerScript.gold - 15;
        }
    }

    public void VendingMachineBuy()
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20)
        {
            PlayerScript.gold = PlayerScript.gold - 20;
        }
    }
}
