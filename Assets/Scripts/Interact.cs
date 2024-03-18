using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;
//This script is used on the Interact button, to see if the player can interact with the objects around them

public class Interact : MonoBehaviour
{
    [Header("In Range Bools")]
    public bool OvenInRange; //if the oven is in range
    public bool ChoppingBoardInRange; //if the chopping board is in range
    public bool FridgeInRange; //if the fridge is in range
    public bool PandaInRange; //is the player in range of the panda
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

    [Header("Other Bools")]
    public bool FireExtinguishUse;
    public bool TrashBagHeld;
    public bool FridgeOpen; //is the fridge window open
    public bool FoodCooked; //is the food cooked
    public bool MealReady; //is the meal ready
    public bool BroomHeld;
    public bool DirtyPlateHeld;
    public bool FireExtinguisherHeld;
    public bool WashingDone;

    [Header("Fridge Assets")]
    public GameObject FridgeUI; //fridge ui window
    public Fridge FridgeScript; //fridge script

    public GameObject Bread; //bread gameobject that the player holds
    public GameObject Bamboo; //bamboo gameobject that the player holds
    public GameObject Meat;
    public GameObject CookedBamboo; //cooked bamboo gameobject that the player holds
    public GameObject BambooHotdog; //bamboo hotdog gameobject that the player holds
    public GameObject MeatSmoothie;
    public GameObject DirtyPlate;

    public PandaCustomer CustomerTestScript; //customer script

    public bool TimerRunning;

    public GameObject OvenInteractPrompt;
    public GameObject ChoppingBoardInteractPrompt;
    public GameObject BlenderInteractPrompt;
    public GameObject SinkInteractPrompt;

    public GameObject TutorialEnd;

    public Tutorial TutorialScript;

    public GameObject Camera; //get the camera gameobject so it can be moved 
    public Vector3 NewCameraPosition; //the new position for the camera
    public GameObject Player; //get the player gameobject so it can be moved
    public Vector3 NewPlayerPosition; //the new position for the camera

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

    public bool SmoothieMade;

    public bool PlayerLeftHandFull;
    //Broom
    //Bamboo
    //bamboo hotdog

    public bool PlayerRightHandFull;
    //Bread
    //DirtyPlate
    //FireExtinguish
    //MeatSmoothie
    //bamboo hotdog
    //trashbag
    //meat

    public GameObject LeftHandUI;
    public GameObject RightHandUI;
    public GameObject BothHandUI;

    public int TrashTimerInt;

    public bool MealPrepared;

    public GameObject DirtyPlateTable;

    public bool DayEnd;

    public bool OnFire;

    public bool Washup2;
    public void Start()
    {
        StartCoroutine(TrashSliderTimer());

    }

    public void Update()
    {

        if(Input.GetKey(KeyCode.E) && !TimerRunning)
        {
            InteractButton();
            StartCoroutine(DelayTime());
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
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

        if(other.tag == "PandaCustomer")
        {
            PandaInRange = true;
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
        if(other.tag == "Oven")
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
        if (other.tag == "PandaCustomer")
        {
            PandaInRange = false;
            
            if (TutorialScript.TutorialImages == 9)
            {
                TutorialScript.NextTutorial();
            }

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

        if(OvenInRange && !OnFire)
        {
            //check what food the player has

           if(FridgeScript.HoldingBamboo && !OnFire) //if the players holding bamboo
           {
                OvenInteractPrompt.SetActive(true);
           }

           if(FoodCooked && PlayerLeftHandFull)
           {
                StartCoroutine(HandUITimer());
           }

            if(FoodCooked && !PlayerLeftHandFull && !OnFire)
            {
                OvenOn = false;
                CookedBamboo.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);

                if (TutorialScript.TutorialImages == 26)
                {
                    TutorialScript.NextTutorial();
                }
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
                if (TutorialScript.TutorialImages == 18)
                {
                    TutorialScript.NextTutorial();
                }
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
                if (TutorialScript.TutorialImages == 15 || TutorialScript.TutorialImages == 26)
                {
                    TutorialScript.NextTutorial();
                }
            }
            else
            {
                FridgeUI.SetActive(false);
                FridgeOpen = false;
                FridgeLight.SetActive(false);
                if (TutorialScript.TutorialImages == 26)
                {
                    TutorialScript.NextTutorial();
                }
            }
        }

        if(ChoppingBoardInRange && !OnFire)
        {
            if(FoodCooked) //if the food is cooked
            {
                ChoppingBoardInteractPrompt.SetActive(true);
            }

            if(MealPrepared)
            {
                CookedBamboo.SetActive(false);
                Bread.SetActive(false);
                BambooHotdog.SetActive(true); //enable the bamboo hotdog gameobject
                MealReady = true;
                FoodCooked = false;

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);

                if (TutorialScript.TutorialImages == 27)
                {
                    TutorialScript.NextTutorial();
                }
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

                if (TutorialScript.TutorialImages == 28)
                {
                    TutorialScript.NextTutorial();
                }
            }

            if (SmoothieMade) //when the meal is cooked
            {
                MeatSmoothie.SetActive(false); //disable the bamboo hotdog
                CustomerTestScript.FedSmoothie();//call to the customer script
                SmoothieMade = false;
                PlayerLeftHandFull = false;

                if (TutorialScript.TutorialImages == 19)
                {
                    TutorialScript.NextTutorial();
                }
            }
        }
        
        if(BedInRange)
        {
            if(DayEnd)
            {
                TutorialEnd.SetActive(true);
            }
        }

        if(ToCafeArea1)
        {
            Camera.transform.position = new Vector3(0, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(21, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position;
        }

        if (ToCafeArea2)
        {
            Camera.transform.position = new Vector3(0, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(-21, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position;
        }

        if (ToKitchenArea)
        {
            Camera.transform.position = new Vector3(80, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(57, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position;
            if (TutorialScript.TutorialImages == 12)
            {
                TutorialScript.NextTutorial();
            }
        }

        if (ToBedroomArea)
        {
            Camera.transform.position = new Vector3(-89, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(-66, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position;
            if (TutorialScript.TutorialImages == 31)
            {
                TutorialScript.NextTutorial();
            }
        }

        if (FireExtinguisherHeld && !FireExtinguishUse)
        {
            FireExtinguisherinUsePlayer.SetActive(true);
            FireExtinguisherPlayer.SetActive(false);
            FireExtinguishUse = true;
        }

        if (FireExtinguisherInRange)
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

        if(FireExtinguisherInRange && FireExtinguisherHeld)
        {
            FireExtinguisherHeld = false;
            FireExtinguisher.SetActive(true);
            FireExtinguisherPlayer.SetActive(false);
            EmptyFireExtinguisher.SetActive(false);
            FireExtinguisherinUsePlayer.SetActive(false);
            FireExtinguishUse = false;
            PlayerRightHandFull = false;
        }

        if (BroomInRange)
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

        if (BroomInRange && BroomHeld)
        {
            BroomHeld = false;
            Broom.SetActive(true);
            BroomPlayer.SetActive(false);
            EmptyBroom.SetActive(false);
            PlayerLeftHandFull = false; 
        }

        if(TrashBag1inRange)
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

        if (TrashBag2inRange)
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

        if (TrashBag3inRange)
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
            if(FridgeScript.HoldingBamboo || FridgeScript.HoldingBread || FridgeScript.HoldingMeat || SmoothieMade)
            {
                FridgeScript.MeatIcon.SetActive(false);
                FridgeScript.BambooIcon.SetActive(false);
                FridgeScript.BreadIcon.SetActive(false);
                MeatSmoothie.SetActive(false);
                SmoothieMade = false;
                TrashTimerValue = TrashTimerValue + 0.15f;
                PlayerRightHandFull = false;
                PlayerLeftHandFull = false;
            }
        }

        if (WardrobeInRange) //open the fridge UI
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

        if(KitchenExitInRange && TrashBagHeld)
        {
            TrashBagObject.SetActive(false);
            TrashBagHeld = false;
            PlayerRightHandFull = false;
        }
    
        if(DirtyPlateinRange)
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

        if(SinkinRange && DirtyPlateHeld)
        {
            SinkInteractPrompt.SetActive(true);
            if (TutorialScript.TutorialImages == 22)
            {
                TutorialScript.NextTutorial();
            }
        }
    }

    IEnumerator DelayTime()
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

            if (TutorialScript.TutorialImages == 17)
            {
                TutorialScript.NextTutorial();
            }
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
            if (TutorialScript.TutorialImages == 23)
            {
                TutorialScript.NextTutorial();
            }
            if (Washup2 == true)
            {
                DayEnd = true;
                TutorialScript.NextTutorial();

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

    IEnumerator TrashSliderTimer()
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

    IEnumerator FridgeLightOverlay()
    {
        yield return new WaitForSeconds(0.33f);
        FridgeLight.SetActive(false);
    }

    public void OvenPopupTick()
    {
        StartCoroutine(OvenTimer());
        Bamboo.SetActive(false);
        OvenInteractPrompt.SetActive(false);
        FridgeScript.HoldingBamboo = false;
        OvenOn = true;
    }

    public void OvenPopupCross()
    {
        OvenInteractPrompt.SetActive(false);
    }

    public void BlenderPopupTick()
    {
        StartCoroutine(BlenderTimer());
        Meat.SetActive(false);
        BlenderInteractPrompt.SetActive(false);
        FridgeScript.HoldingMeat = false;
    }

    public void BlenderPopupCross()
    {
        BlenderInteractPrompt.SetActive(false);
    }


    public void ChoppingBoardPopUpTick()
    {
        StartCoroutine(ChoppingTimer());
        Bread.SetActive(false);
        CookedBamboo.SetActive(false);
        ChoppingBoardInteractPrompt.SetActive(false);   
    }

    public void ChoppingBoardPopUpCross()
    {
        ChoppingBoardInteractPrompt.SetActive(false);
    }
    public void SinkWashUpTick()
    {
        StartCoroutine(SinkTimer());
        DirtyPlate.SetActive(false);
        SinkInteractPrompt.SetActive(false);

    }

    public void SinkWashUpCross()
    {
        SinkInteractPrompt.SetActive(false);
    }
    public IEnumerator HandUITimer()
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

    public void FireGone()
    {
        OvenTimerValue = 0;
        OnFire = false;
        FireController.SetActive(false);
        OvenTimerSlider.value = OvenTimerValue;
        OvenValueColour.color = new Color32(76, 211, 255, 255);
    }
}
