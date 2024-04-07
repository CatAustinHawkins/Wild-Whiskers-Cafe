using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject[] ShopObjects;
    public GameObject[] Overlays;

    public Tutorial TutorialScript;

    public PlayerScript PlayerScript;

    public int FishTankBought;
    public int KiwiCrocodileBought;
    public int PineappleHedgehogBought;
    public int AppleCrabBought;
    public int StrawberryMiceBought;
    public int AppleDogBought;
    public int DisplayTable1Bought;
    public int DisplayTable2Bought;
    public int AlienPlushBought;
    public int WardrobeBought;
    public int VendingMachineBought;
    public int BearPlushBought;

    //after player buys shop item, save value of the item to be saved and instaniated

    public void Start()
    {
        //check what items the player has previously bought 

        Load();

        if(FishTankBought == 1)
        {
            ShopObjects[0].SetActive(true);
            Overlays[0].SetActive(true);
        }
        if (KiwiCrocodileBought == 1)
        {
            ShopObjects[1].SetActive(true);
            Overlays[1].SetActive(true);
        }
        if (PineappleHedgehogBought == 2)
        {
            ShopObjects[2].SetActive(true);
            Overlays[2].SetActive(true);
        }
        if (AppleCrabBought == 1)
        {
            ShopObjects[3].SetActive(true);
            Overlays[3].SetActive(true);
        }
        if (StrawberryMiceBought == 1)
        {
            ShopObjects[4].SetActive(true);
            Overlays[4].SetActive(true);
        }
        if (DisplayTable1Bought == 1)
        {
            ShopObjects[5].SetActive(true);
            Overlays[5].SetActive(true);
        }
        if (DisplayTable2Bought == 1)
        {
            ShopObjects[6].SetActive(true);
            Overlays[6].SetActive(true);
        }
        if (AlienPlushBought == 1)
        {
            ShopObjects[7].SetActive(true);
            Overlays[7].SetActive(true);
        }
        if (WardrobeBought == 1)
        {
            ShopObjects[8].SetActive(true);
            Overlays[8].SetActive(true);
        }
        if (VendingMachineBought == 1)
        {
            ShopObjects[9].SetActive(true);
            Overlays[9].SetActive(true);
        }
        if (BearPlushBought == 1)
        {
            ShopObjects[10].SetActive(true);
            Overlays[10].SetActive(true);
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("FishTankPurchased", FishTankBought);
        PlayerPrefs.SetInt("KiwiCrocodilePurchased", KiwiCrocodileBought);
        PlayerPrefs.SetInt("PineappleHedgehogPurchased", PineappleHedgehogBought);
        PlayerPrefs.SetInt("AppleCrabPurchased", AppleCrabBought);
        PlayerPrefs.SetInt("StrawberryMicePurchased", StrawberryMiceBought);
        PlayerPrefs.SetInt("DisplayTable1Purchased", DisplayTable1Bought);
        PlayerPrefs.SetInt("DisplayTable2Purchased", DisplayTable2Bought);
        PlayerPrefs.SetInt("AlienPlushPurchased", AlienPlushBought);
        PlayerPrefs.SetInt("WardrobePurchased", WardrobeBought);
        PlayerPrefs.SetInt("VendingMachinePurchased", VendingMachineBought);
        PlayerPrefs.SetInt("BearPlushPurchased", BearPlushBought);
    }

    public void Load()
    {
        FishTankBought = PlayerPrefs.GetInt("FishTankPurchased");
        KiwiCrocodileBought = PlayerPrefs.GetInt("KiwiCrocodilePurchased");
        PineappleHedgehogBought = PlayerPrefs.GetInt("PineappleHedgehogPurchased");
        AppleCrabBought = PlayerPrefs.GetInt("AppleCrabPurchased");
        StrawberryMiceBought = PlayerPrefs.GetInt("StrawberryMicePurchased");
        DisplayTable1Bought = PlayerPrefs.GetInt("DisplayTable1Purchased");
        DisplayTable2Bought = PlayerPrefs.GetInt("DisplayTable2Purchased");
        AlienPlushBought = PlayerPrefs.GetInt("AlienPlushPurchased");
        WardrobeBought = PlayerPrefs.GetInt("WardrobePurchased");
        VendingMachineBought = PlayerPrefs.GetInt("VendingMachinePurchased");
        BearPlushBought = PlayerPrefs.GetInt("BearPlushPurchased");

    }

    public void FishtankBuy()
    {
        if (TutorialScript.TutorialImages == 5)
        {
            TutorialScript.NextTutorial();
        }

        ShopObjects[0].SetActive(true);
        Overlays[0].SetActive(true);

        FishTankBought = 1;
        Save();

    }

    public void KiwiCrocodileBuy()
    {
        if(PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[1].SetActive(true);
            Overlays[1].SetActive(true);
            KiwiCrocodileBought = 1;
        }
        Save();

    }

    public void PineappleHedgehogBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[2].SetActive(true);
            Overlays[2].SetActive(true);

            PineappleHedgehogBought = 1;
        }
        Save();

    }

    public void AppleCrabBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[3].SetActive(true);
            Overlays[3].SetActive(true);
            AppleCrabBought = 1;

        }
        Save();

    }

    public void StrawberryMiceBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[4].SetActive(true);
            Overlays[4].SetActive(true);
            StrawberryMiceBought = 1;

        }
        Save();

    }

    public void AppleDogBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[5].SetActive(true);
            Overlays[5].SetActive(true);
            AppleDogBought = 1;

        }
        Save();

    }

    public void DisplayTable1Buy()
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20)
        {
            PlayerScript.gold = PlayerScript.gold - 20;

            ShopObjects[6].SetActive(true);
            Overlays[6].SetActive(true);
            DisplayTable1Bought = 1;

        }
        Save();

    }

    public void DisplayTable2Buy()
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20)
        {
            PlayerScript.gold = PlayerScript.gold - 20;

            ShopObjects[7].SetActive(true);
            Overlays[7].SetActive(true);

            DisplayTable2Bought = 1;

        }
        Save();

    }

    public void AlienPlushBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[8].SetActive(true);
            Overlays[8].SetActive(true);

            AlienPlushBought = 1;

        }
        Save();

    }

    public void WardrobeBuy()
    {
        if (PlayerScript.gold > 15 || PlayerScript.gold == 15)
        {
            PlayerScript.gold = PlayerScript.gold - 15;

            ShopObjects[9].SetActive(true);
            Overlays[9].SetActive(true);

            WardrobeBought = 1;

        }

        Save();

    }

    public void VendingMachineBuy()
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20)
        {
            PlayerScript.gold = PlayerScript.gold - 20;

            ShopObjects[10].SetActive(true);
            Overlays[10].SetActive(true);

            VendingMachineBought = 1;

        }

        Save();

    }

    public void BearPlushBuy()
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10)
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[11].SetActive(true);
            Overlays[11].SetActive(true);

            BearPlushBought = 1;

        }

        Save();
    }
}
