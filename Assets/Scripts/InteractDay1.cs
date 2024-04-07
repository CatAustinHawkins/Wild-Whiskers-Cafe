using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;
//This script is used on the Interact button, to see if the player can interact with the objects around them

public class InteractDay1 : MonoBehaviour
{
    [Header("In Range Bools")]
    public bool OvenInRange; //if the oven is in range
    public bool ChoppingBoardInRange; //if the chopping board is in range
    public bool FridgeInRange; //if the fridge is in range
    
    public bool AdderInRange; //is the player in range of the panda
    public bool LeopardInRange;

    public bool BedInRange;
    public bool ToCafeArea1;//to cafe from kitchen
    public bool ToCafeArea2;//to cafe from bedroom
    public bool ToKitchenArea;
    public bool ToBedroomArea;
    public bool BroomInRange;
    public bool FireExtinguisherInRange;
    public bool TrashBag1inRange;
    public bool TrashBag2inRange;
    public bool TrashBag3inRange;
    public bool WardrobeInRange;
    public bool KitchenExitInRange;
    public bool BlenderinRange;
    public bool TrashBininRange;
    public bool DirtyPlateinRange;
    public bool SinkinRange;
    public bool Coin1inRange;
    public bool Coin2inRange;
    public bool Coin3inRange;

    [Header("Other Bools")]
    public bool FireExtinguishUse;
    public bool TrashBagHeld;
    public bool FridgeOpen; //is the fridge window open

    public bool BurgerCooked; //is the food cooked
    public bool BurgerPutTogether;
    public bool SmoothieMade; //is the meal ready
    public bool SteakCooked; 

    public bool BroomHeld;
    public bool DirtyPlateHeld;
    public bool FireExtinguisherHeld;
    public bool WashingDone;

    public bool MeatSmoothieInProgress;
    public bool MouseBurgerInProgress;
    public bool VenisonSteakInProgress;

    [Header("Fridge Assets")]
    public GameObject FridgeUI; //fridge ui window
    public FridgeDay1 FridgeScript; //fridge script

    public GameObject Bread; //bread gameobject that the player holds
    public GameObject Bamboo; //bamboo gameobject that the player holds
    public GameObject Meat;
    public GameObject CookedBamboo; //cooked bamboo gameobject that the player holds
    public GameObject BambooHotdog; //bamboo hotdog gameobject that the player holds

    public GameObject MouseBurger;
    public GameObject CookedMeat;
    public GameObject MeatSmoothie;
    public GameObject DirtyPlate;

    public PandaCustomer CustomerTestScript; //customer script

    public bool TimerRunning;

    public GameObject OvenInteractPrompt;
    public GameObject ChoppingBoardInteractPrompt;
    public GameObject BlenderInteractPrompt;
    public GameObject SinkInteractPrompt;

    public GameObject DayEndGO;

    public PlayerScript PlayerMove;

    public GameObject Broom;
    public GameObject FireExtinguisher;

    public GameObject BroomPlayer;
    public GameObject FireExtinguisherPlayer;
    public GameObject FireExtinguisherinUsePlayer;

    public GameObject EmptyBroom;
    public GameObject EmptyFireExtinguisher;

    [Header("Slider Controls")]
    public Slider OvenTimerSlider;
    public Slider BlenderTimerSlider;
    public Slider TrashTimerSlider;
    public Slider SinkTimerSlider;
    public Slider ChoppingBoardTimerSlider;

    public float OvenTimerValue;
    public float BlenderTimerValue;
    public float TrashTimerValue;
    public float SinkTimerValue;
    public float ChoppingBoardTimerValue;

    public Image OvenValueColour;
    public Image BlenderValueColour;
    public Image ChoppingBoardValueColour;
    public Image SinkValueColour;

    public GameObject FireController;

    public bool OvenOn;

    public GameObject FridgeLight;


    public GameObject[] TrashBags;
    public int TrashBagRandom;

    public GameObject WardrobeUI;
    public bool WardrobeOpen;

    public GameObject TrashBagObject;

    public bool PlayerLeftHandFull;

    public bool PlayerRightHandFull;

    public GameObject LeftHandUI;
    public GameObject RightHandUI;
    public GameObject BothHandUI;

    public int TrashTimerInt;

    public GameObject DirtyPlateTable;

    public bool DayEnd;

    public bool OnFire;

    public bool Washup2;

    public GameObject[] Coins;

    public AudioSource ButtonClick;
    public GameObject ButtonSource;

    public AudioSource BlenderNoise;
    public AudioSource BroomNoise;
    public AudioSource OvenNoise;
    public AudioSource SinkNoise;
    public AudioSource FireExtinguisherNoise;
    public AudioSource ChoppingBoardNoise;
    public AudioSource CoinPickup;

    public bool AlreadyFed;

    public void Start()
    {
        StartCoroutine(TrashSliderTimer());
        ButtonSource = GameObject.FindWithTag("ButtonSound");
        ButtonClick = ButtonSource.GetComponent<AudioSource>();
    }

    public void Update()
    {

        if(Input.GetKeyDown(KeyCode.E) && !TimerRunning)
        {
            ButtonClick.Play();

            InteractButton();
            StartCoroutine(DelayTime());
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Coin1")
        {
            Coin1inRange = true;
        }
        
        if (other.tag == "Coin2")
        {
            Coin2inRange = true;
        }
        
        if (other.tag == "Coin3")
        {
            Coin3inRange = true;
        }

        if (other.tag == "Oven") //check if the player is colliding with the oven
        {
            OvenInRange = true; //set oven in range to true
        }

        //same for the other game objects
        if (other.tag == "Fridge")
        {
            FridgeInRange = true;
        }

        if (other.tag == "ChoppingBoard")
        {
            ChoppingBoardInRange = true;
        }

        if(other.tag == "AdderCustomer")
        {
            AdderInRange = true;
        }

        if (other.tag == "LeopardCustomer")
        {
            LeopardInRange = true;
        }

        if (other.tag == "Bed")
        {
            BedInRange = true;
        }

        if(other.tag == "ToCafe1")
        {
            ToCafeArea1 = true;
        }
        if (other.tag == "ToCafe2")
        {
            ToCafeArea2 = true;
        }
        if (other.tag == "ToKitchen")
        {
            ToKitchenArea = true;
        }

        if(other.tag == "ToBedroom")
        {
            ToBedroomArea = true;
        }

        if(other.tag == "FireExtinguisher")
        {
            FireExtinguisherInRange = true;
        }

        if(other.tag == "Broom")
        {
            BroomInRange = true;
        }

        if (other.tag == "TrashBag1")
        {
            TrashBag1inRange = true;
        }

        if (other.tag == "TrashBag2")
        {
            TrashBag2inRange = true;
        }

        if (other.tag == "TrashBag3")
        {
            TrashBag3inRange = true;
        }

        if(other.tag == "Wardrobe")
        {
            WardrobeInRange = true;
        }

        if(other.tag == "KitchenExit")
        {
            KitchenExitInRange = true;  
        }

        if(other.tag == "Blender")
        {
            BlenderinRange = true;
        }

        if(other.tag == "TrashBin")
        {
            TrashBininRange = true;
        }

        if(other.tag == "DirtyPlate")
        {
            DirtyPlateinRange = true;
        }

        if(other.tag == "Sink")
        {
            SinkinRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Coin1")
        {
            Coin1inRange = false;
        }

        if (other.tag == "Coin2")
        {
            Coin2inRange = false;
        }

        if (other.tag == "Coin3")
        {
            Coin3inRange = false;
        }

        if (other.tag == "Oven")
        {
            OvenInRange = false;
            OvenInteractPrompt.SetActive(false);
        }

        if (other.tag == "Fridge")
        {
            FridgeInRange = false;
            FridgeLight.SetActive(false);
            FridgeOpen = false;
            FridgeUI.SetActive(false);

        }

        if (other.tag == "ChoppingBoard")
        {
            ChoppingBoardInRange = false;
        }
        if (other.tag == "AdderCustomer")
        {
            AdderInRange = false;
        }

        if (other.tag == "LeopardCustomer")
        {
            LeopardInRange = false;
        }

        if (other.tag == "Bed")
        {
            BedInRange = false;
        }

        if (other.tag == "ToCafe1")
        {
            ToCafeArea1 = false;
        }
        if (other.tag == "ToCafe2")
        {
            ToCafeArea2 = false;
        }
        if (other.tag == "ToKitchen")
        {
            ToKitchenArea = false;
        }

        if (other.tag == "ToBedroom")
        {
            ToBedroomArea = false;
        }

        if (other.tag == "FireExtinguisher")
        {
            FireExtinguisherInRange = false;
        }

        if (other.tag == "Broom")
        {
            BroomInRange = false;
        }

        if(other.tag == "TrashBag1")
        {
            TrashBag1inRange = false;   
        }

        if (other.tag == "TrashBag2")
        {
            TrashBag2inRange = false;
        }

        if (other.tag == "TrashBag3")
        {
            TrashBag3inRange = false;
        }

        if (other.tag == "Wardrobe")
        {
            WardrobeInRange = false;
        }

        if (other.tag == "KitchenExit")
        {
            KitchenExitInRange = false;
        }

        if (other.tag == "Blender")
        {
            BlenderinRange = false;
        }

        if (other.tag == "TrashBin")
        {
            TrashBininRange = false;
        }

        if (other.tag == "DirtyPlate")
        {
            DirtyPlateinRange = false;
        }


        if (other.tag == "Sink")
        {
            SinkinRange = false;
        }
    }

    public void InteractButton()
    {
        PlayerMove.target = PlayerMove.transform.position;
        ButtonClick.Play();

        if(Coin1inRange)
        {
            Coin1inRange = false;
            CoinPickup.Play();
            PlayerMove.gold = PlayerMove.gold + 5;
            Coins[0].SetActive(false);
        }

        if (Coin2inRange)
        {
            Coin2inRange = false;
            CoinPickup.Play();
            PlayerMove.gold = PlayerMove.gold + 5;
            Coins[1].SetActive(false);
        }

        if (Coin3inRange)
        {
            Coin3inRange = false;
            CoinPickup.Play();
            PlayerMove.gold = PlayerMove.gold + 5;
            Coins[2].SetActive(false);
        }

        if (OvenInRange && !OnFire)
        {
            //check what food the player has

           if(FridgeScript.HoldingMeat && !OnFire) //if the players holding bamboo
           {
                OvenInteractPrompt.SetActive(true);
           }

           if(BurgerCooked && PlayerLeftHandFull)
           {
                StartCoroutine(HandUITimer());
           }

            if(BurgerCooked && !PlayerLeftHandFull && !OnFire) //mouse burger burger cooked
            {
                OvenOn = false;
                CookedMeat.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (SteakCooked && !PlayerLeftHandFull && !OnFire) //mouse burger burger cooked
            {
                OvenOn = false;
                CookedMeat.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }
        }

        if (BlenderinRange && !OnFire)
        {
            //check what food the player has

            if (FridgeScript.HoldingMeat) //if the players holding bamboo
            {
                BlenderInteractPrompt.SetActive(true);
            }

            if(SmoothieMade && PlayerLeftHandFull)
            {
                StartCoroutine(HandUITimer());
            }

            if (SmoothieMade && !PlayerLeftHandFull)
            {
                MeatSmoothie.SetActive(true);
                BlenderInteractPrompt.SetActive(false);
                BlenderTimerValue = 0;
                BlenderTimerSlider.value = BlenderTimerValue;
                BlenderValueColour.color = new Color32(76, 211, 255, 255);
            }

        }

        if (FridgeInRange && !OnFire) //open the fridge UI
        {
            if(!FridgeOpen)
            {
                PlayerMove.target = PlayerMove.transform.position;
                FridgeUI.SetActive(true);
                FridgeOpen = true;
                FridgeLight.SetActive(true);
                StartCoroutine(FridgeLightOverlay());
            }
            else
            {
                FridgeUI.SetActive(false);
                FridgeOpen = false;
                FridgeLight.SetActive(false);
            }
        }

        if(ChoppingBoardInRange && !OnFire)
        {
            if(BurgerCooked && FridgeScript.HoldingBread) //if the food is cooked
            {
                ChoppingBoardInteractPrompt.SetActive(true);
            }

            if(MouseBurger)
            {
                CookedBamboo.SetActive(false);
                Bread.SetActive(false);
                MouseBurger.SetActive(true); //enable the bamboo hotdog gameobject
                MealReady = true;
                FoodCooked = false;

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                MealPrepared = false;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }
        }

        if(PandaInRange)
        {
            if (MealReady) //when the meal is cooked
            {
                BambooHotdog.SetActive(false); //disable the bamboo hotdog
                CustomerTestScript.FedMeal();//call to the customer script
                MealReady = false;
                PlayerRightHandFull = false;
                PlayerLeftHandFull = false;
            }

            if (SmoothieMade && !AlreadyFed) //when the meal is cooked
            {
                AlreadyFed = true;
                MeatSmoothie.SetActive(false); //disable the bamboo hotdog
                CustomerTestScript.FedSmoothie();//call to the customer script
                SmoothieMade = false;
                PlayerLeftHandFull = false;
            }
        }
        
        if(BedInRange) //No Change Needed
        {
            if(DayEnd)
            {
                DayEndGO.SetActive(true);
            }
        }

        if (FireExtinguisherInRange && FireExtinguisherHeld) //No Change Needed
        {
            FireExtinguisherHeld = false;
            FireExtinguisher.SetActive(true);
            FireExtinguisherPlayer.SetActive(false);
            EmptyFireExtinguisher.SetActive(false);
            FireExtinguisherinUsePlayer.SetActive(false);
            FireExtinguishUse = false;
            PlayerRightHandFull = false;
        }

        if (FireExtinguisherHeld && !FireExtinguishUse) //No Change Needed
        {
            FireExtinguisherNoise.Play();
            FireExtinguisherinUsePlayer.SetActive(true);
            FireExtinguisherPlayer.SetActive(false);
            FireExtinguishUse = true;
        }

        if (FireExtinguisherInRange) //No Change Needed
        {
            if(!PlayerRightHandFull)
            {
                FireExtinguisherHeld = true;
                FireExtinguisher.SetActive(false);
                FireExtinguisherPlayer.SetActive(true);
                EmptyFireExtinguisher.SetActive(true);
                PlayerRightHandFull = true;
            }
            else
            {
                StartCoroutine(HandUITimer());
            }

        }

        if (BroomInRange && !BroomHeld) //No Change Needed
        {
            if(!PlayerLeftHandFull)
            {
                BroomHeld = true;
                Broom.SetActive(false);
                BroomPlayer.SetActive(true);
                EmptyBroom.SetActive(true);
                PlayerLeftHandFull = true;
            }
            else
            {
                StartCoroutine(HandUITimer());
            }
        }

        if (BroomInRange && BroomHeld) //No Change Needed
        {
            BroomHeld = false;
            Broom.SetActive(true);
            BroomPlayer.SetActive(false);
            EmptyBroom.SetActive(false);
            PlayerLeftHandFull = false; 
        }

        if(TrashBag1inRange) //No Change Needed
        {
            if(PlayerRightHandFull)
            {
                StartCoroutine(HandUITimer());
            }
            else
            {
                TrashBags[0].SetActive(false);
                TrashBagHeld = true;
                TrashBagObject.SetActive(true);
                PlayerRightHandFull = true;
            }
        }

        if (TrashBag2inRange) //No Change Needed
        {
            if (PlayerRightHandFull)
            {
                StartCoroutine(HandUITimer());
            }
            else
            {
                TrashBags[1].SetActive(false);
                TrashBagHeld = true;
                TrashBagObject.SetActive(true);
                PlayerRightHandFull = true;
            }
        }

        if (TrashBag3inRange) //No Change Needed
        {
            if (PlayerRightHandFull)
            {
                StartCoroutine(HandUITimer());
            }
            else
            {
                TrashBags[2].SetActive(false);
                TrashBagHeld = true;
                TrashBagObject.SetActive(true);
                PlayerRightHandFull = true;
            }
        }

        if(TrashBininRange)
        {
            if(FridgeScript.HoldingBamboo || FridgeScript.HoldingBread || FridgeScript.HoldingMeat || SmoothieMade || FoodCooked || MealReady)
            {
                FridgeScript.MeatIcon.SetActive(false);
                FridgeScript.BambooIcon.SetActive(false);
                FridgeScript.BreadIcon.SetActive(false);
                FridgeScript.HoldingBamboo = false;
                FridgeScript.HoldingBread = false;
                FridgeScript.HoldingMeat = false;
                MeatSmoothie.SetActive(false);
                BambooHotdog.SetActive(false);
                CookedBamboo.SetActive(false);
                SmoothieMade = false;
                FoodCooked = false;
                MealReady = false;
                TrashTimerValue = TrashTimerValue + 0.15f;
                PlayerRightHandFull = false;
                PlayerLeftHandFull = false;
            }
        }

        if (WardrobeInRange) //No Change Needed
        {
            if (!WardrobeOpen)
            {
                PlayerMove.target = PlayerMove.transform.position;
                WardrobeUI.SetActive(true);
                WardrobeOpen = true;
            }
            else
            {
                WardrobeUI.SetActive(false);
                WardrobeOpen = false;
            }
        }

        if(KitchenExitInRange && TrashBagHeld) //No Change Needed
        {
            TrashBagObject.SetActive(false);
            TrashBagHeld = false;
            PlayerRightHandFull = false;
        }
    
        if(DirtyPlateinRange) //No Change Needed
        {
            if(!PlayerRightHandFull)
            {
                DirtyPlateHeld = true;
                DirtyPlate.SetActive(true);
                DirtyPlateTable.SetActive(false);
                PlayerRightHandFull = true;
            }
            else
            {
                StartCoroutine(HandUITimer());
            }
        }

        if(SinkinRange && DirtyPlateHeld) //No Change Needed
        {
            SinkInteractPrompt.SetActive(true);
        }
    }

    IEnumerator DelayTime() //No Change Needed
    {
        TimerRunning = true;
        yield return new WaitForSeconds(0.25f);
        TimerRunning = false;
    }

    IEnumerator ChoppingTimer()
    {
        PlayerRightHandFull = false;
        PlayerLeftHandFull = false;
        yield return new WaitForSeconds(0.25f);
        ChoppingBoardTimerValue = ChoppingBoardTimerValue + 0.125f;
        ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
        if (ChoppingBoardTimerValue == 1)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);

            MealPrepared = true;

        }
        else
        {
            StartCoroutine(ChoppingTimer());
        }

    }

    IEnumerator BlenderTimer()
    {
        PlayerRightHandFull = false;
        yield return new WaitForSeconds(0.25f);
        BlenderTimerValue = BlenderTimerValue + 0.125f;
        BlenderTimerSlider.value = BlenderTimerValue;
        if (!SmoothieMade)
        {
            StartCoroutine(BlenderTimer());
        }

        if(BlenderTimerValue == 1)
        {
            SmoothieMade = true;
            BlenderValueColour.color = new Color32(113, 255, 76, 255);
        }
    }

    IEnumerator SinkTimer()
    {
        PlayerMove.WashingUp = true;
        yield return new WaitForSeconds(0.25f);
        SinkTimerValue = SinkTimerValue + 0.125f;
        SinkTimerSlider.value = SinkTimerValue;
        if (SinkTimerValue < 1)
        {
            StartCoroutine(SinkTimer());
        }

        if (SinkTimerValue == 1)
        {
            PlayerMove.WashingUp = false;
            SinkTimerValue = 0;
            SinkTimerSlider.value = SinkTimerValue;
            PlayerRightHandFull = false;
            DirtyPlateHeld = false;

            if (Washup2 == true)
            {
                DayEnd = true;
            }
        }
    }
    IEnumerator OvenTimer()
    {
        OvenOn = true;
        PlayerLeftHandFull = false;
        yield return new WaitForSeconds(0.25f);
        OvenTimerValue = OvenTimerValue + 0.08333f;
        OvenTimerSlider.value = OvenTimerValue;
        if (OvenOn)
        {
            StartCoroutine(OvenTimer());
        }
        else
        {
            OvenTimerValue = 0;
            OvenTimerSlider.value = OvenTimerValue;
        }

        if (OvenTimerValue > 1)
        {
            FoodCooked = true;

            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }

        if (OvenTimerValue > 3)
        {
            FoodCooked = false;
            OnFire = true;
            OvenValueColour.color = new Color32(255, 76, 76, 255);
            FireController.SetActive(true);
        }
            
    }

    IEnumerator TrashSliderTimer()//No Change Needed
    {
        TrashTimerValue = TrashTimerValue + 0.0005f;
        TrashTimerSlider.value = TrashTimerValue;
        yield return new WaitForSeconds(0.25f);
        StartCoroutine(TrashSliderTimer());
        if(TrashTimerValue > 1)
        {
            TrashBagRandom = Random.Range(0, 2);
            TrashBags[TrashBagRandom].SetActive(true);
            TrashTimerValue = 0;
            TrashTimerSlider.value = 0;
        }
    }

    IEnumerator FridgeLightOverlay() //No Change Needed
    {
        yield return new WaitForSeconds(0.33f);
        FridgeLight.SetActive(false);
    }

    public void OvenPopupTick() //Check what food is being cooked
    {
        StartCoroutine(OvenTimer());
        Bamboo.SetActive(false);
        OvenInteractPrompt.SetActive(false);
        FridgeScript.HoldingBamboo = false;
        OvenOn = true;
        OvenNoise.Play();
        ButtonClick.Play();
    }

    public void OvenPopupCross() //No Change Needed
    {
        OvenInteractPrompt.SetActive(false);
        ButtonClick.Play();
    }

    public void BlenderPopupTick()
    {
        StartCoroutine(BlenderTimer());
        Meat.SetActive(false);
        BlenderInteractPrompt.SetActive(false);
        FridgeScript.HoldingMeat = false;
        BlenderNoise.Play();
        ButtonClick.Play();
    }

    public void BlenderPopupCross() //No Change Needed
    {
        BlenderInteractPrompt.SetActive(false);
        ButtonClick.Play();
    }

    public void ChoppingBoardPopUpTick()
    {
        ChoppingBoardNoise.Play();
        StartCoroutine(ChoppingTimer());
        Bread.SetActive(false);
        CookedBamboo.SetActive(false);
        ChoppingBoardInteractPrompt.SetActive(false);
        ButtonClick.Play();
    }

    public void ChoppingBoardPopUpCross() //No Change Needed
    {
        ChoppingBoardInteractPrompt.SetActive(false);
        ButtonClick.Play();
    }
    public void SinkWashUpTick()
    {
        SinkNoise.Play();
        StartCoroutine(SinkTimer());
        DirtyPlate.SetActive(false);
        SinkInteractPrompt.SetActive(false);
        ButtonClick.Play();
    }

    public void SinkWashUpCross() //No Change Needed
    {
        SinkInteractPrompt.SetActive(false);
        ButtonClick.Play();
    }
    public IEnumerator HandUITimer() //No Change Needed
    {
        if (PlayerLeftHandFull)
        {
            LeftHandUI.SetActive(true);
        }

        if (PlayerRightHandFull)
        {
            RightHandUI.SetActive(true);
        }

        if (PlayerRightHandFull && LeftHandUI)
        {
            BothHandUI.SetActive(true);
        }

        yield return new WaitForSecondsRealtime(3);
        LeftHandUI.SetActive(false);
        RightHandUI.SetActive(false);
        BothHandUI.SetActive(false);
    }

    public void FireGone() //No Change Needed
    {
        OvenTimerValue = 0;
        OnFire = false;
        FireController.SetActive(false);
        OvenTimerSlider.value = OvenTimerValue;
        OvenValueColour.color = new Color32(76, 211, 255, 255);
    }
}
