using UnityEngine;

//This script controls the Shop section in the UI/Cookbook. 

public class Shop : MonoBehaviour
{
    public GameObject[] ShopObjects; //all the shop objects
    public GameObject[] Overlays; //the overlays, which prevent the player from buying the object twice

    public Tutorial TutorialScript; //the tutorial script

    public PlayerScript PlayerScript; //the player script

    //ints as to whether an item has been bought, so they can be saved
    //int = 1 = bought
    //int = 0 = not bought
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

        //load in all items that were bought
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
    public void Save() //save all item states
    {
       // PlayerPrefs.SetInt("FishTankPurchased", FishTankBought);
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

    public void Load() //load all item states
    {
      //  FishTankBought = PlayerPrefs.GetInt("FishTankPurchased");
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

    public void FishtankBuy() //when the fish tank button is clicked
    {
        if (TutorialScript.TutorialImages == 5) //if on tutorial 5
        {
            TutorialScript.NextTutorial(); //next tutorial
        }

        ShopObjects[0].SetActive(true); //enable shop objects 0, the fish tank
        Overlays[0].SetActive(true); //enable the fish tank overlay, preventing the player from buying it again

        FishTankBought = 1; //save that the fish tank has been bought
        Save();
    }

    //repeat
    public void KiwiCrocodileBuy() //when the kiwi crocodile poster button is clicked
    {
        if(PlayerScript.gold > 10 || PlayerScript.gold == 10) //if the player has 10 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 10; //take away 10 gold

            ShopObjects[1].SetActive(true);
            Overlays[1].SetActive(true);
            KiwiCrocodileBought = 1;
        }
        Save();
    }

    public void PineappleHedgehogBuy() //when the pineapple hedgehog poster button is clicked
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10) //if the player has 10 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[2].SetActive(true);
            Overlays[2].SetActive(true);

            PineappleHedgehogBought = 1;
        }
        Save();
    }

    public void AppleCrabBuy() //when the apple crab poster button is clicked
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10) //if the player has 10 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[3].SetActive(true);
            Overlays[3].SetActive(true);
            AppleCrabBought = 1;
        }
        Save();
    }

    public void StrawberryMiceBuy() //when the strawberry mice poster button is clicked
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10) //if the player has 10 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[4].SetActive(true);
            Overlays[4].SetActive(true);
            StrawberryMiceBought = 1;
        }
        Save();
    }

    public void AppleDogBuy() //when the apple dog poster button is clicked
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10) //if the player has 10 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[5].SetActive(true);
            Overlays[5].SetActive(true);
            AppleDogBought = 1;
        }
        Save();
    }

    public void DisplayTable1Buy() //when the display table 1 button is clicked
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20) //if the player has 20 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 20;

            ShopObjects[6].SetActive(true);
            Overlays[6].SetActive(true);
            DisplayTable1Bought = 1;
        }
        Save();
    }

    public void DisplayTable2Buy() //when the display table 2 button is clicked
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20) //if the player has 20 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 20;

            ShopObjects[7].SetActive(true);
            Overlays[7].SetActive(true);

            DisplayTable2Bought = 1;
        }
        Save();
    }

    public void AlienPlushBuy()//when the alien plush button is clicked
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10) //if the player has 10 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[8].SetActive(true);
            Overlays[8].SetActive(true);

            AlienPlushBought = 1;
        }
        Save();
    }

    public void WardrobeBuy()//when the wardrobe button is clicked
    {
        if (PlayerScript.gold > 15 || PlayerScript.gold == 15) //if the player has 15 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 15;

            ShopObjects[9].SetActive(true);
            Overlays[9].SetActive(true);

            WardrobeBought = 1;
        }
        Save();
    }

    public void VendingMachineBuy()//when the vending machine button is clicked
    {
        if (PlayerScript.gold > 20 || PlayerScript.gold == 20) //if the player has 20 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 20;

            ShopObjects[10].SetActive(true);
            Overlays[10].SetActive(true);

            VendingMachineBought = 1;

        }
        Save();
    }

    public void BearPlushBuy()//when the bear plushie button is clicked
    {
        if (PlayerScript.gold > 10 || PlayerScript.gold == 10) //if the player has 10 or more gold
        {
            PlayerScript.gold = PlayerScript.gold - 10;

            ShopObjects[11].SetActive(true);
            Overlays[11].SetActive(true);

            BearPlushBought = 1;
        }
        Save();
    }
}
