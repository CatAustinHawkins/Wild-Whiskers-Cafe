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

            ShopObjects[1].SetActive(true);
            Overlays[1].SetActive(true);
        }

    }

    public void PineappleHedgehogBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[2].SetActive(true);
            Overlays[2].SetActive(true);
        }

    }

    public void AppleCrabBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[3].SetActive(true);
            Overlays[3].SetActive(true);
        }

    }

    public void StrawberryMiceBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[4].SetActive(true);
            Overlays[4].SetActive(true);
        }

    }

    public void AppleDogBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[5].SetActive(true);
            Overlays[5].SetActive(true);
        }

    }

    public void DisplayTable1Buy()
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20)
        {
            PlayerScript.gold = PlayerScript.gold - 20;

            ShopObjects[6].SetActive(true);
            Overlays[6].SetActive(true);
        }

    }

    public void DisplayTable2Buy()
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20)
        {
            PlayerScript.gold = PlayerScript.gold - 20;

            ShopObjects[7].SetActive(true);
            Overlays[7].SetActive(true);
        }

    }

    public void AlienPlushBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[8].SetActive(true);
            Overlays[8].SetActive(true);
        }

    }

    public void WardrobeBuy()
    {
        if (PlayerScript.gold > 15 || PlayerScript.gold == 15)
        {
            PlayerScript.gold = PlayerScript.gold - 15;

            ShopObjects[9].SetActive(true);
            Overlays[9].SetActive(true);
        }
    }

    public void VendingMachineBuy()
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20)
        {
            PlayerScript.gold = PlayerScript.gold - 20;

            ShopObjects[10].SetActive(true);
            Overlays[10].SetActive(true);
        }
    }

    public void BearPlushBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[11].SetActive(true);
            Overlays[11].SetActive(true);
        }
    }
}
