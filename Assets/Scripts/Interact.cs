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

    [Header("Other Bools")]
    public bool FireExtinguishUse;
    public bool TrashBagHeld;
    public bool FridgeOpen; //is the fridge window open
    public bool FoodCooked; //is the food cooked
    public bool MealReady; //is the meal ready
    public bool BroomHeld;
    public bool FireExtinguisherHeld;

    [Header("Fridge Assets")]
    public GameObject FridgeUI; //fridge ui window
    public Fridge FridgeScript; //fridge script

    public GameObject Bread; //bread gameobject that the player holds
    public GameObject Bamboo; //bamboo gameobject that the player holds
    public GameObject Meat;
    public GameObject CookedBamboo; //cooked bamboo gameobject that the player holds
    public GameObject BambooHotdog; //bamboo hotdog gameobject that the player holds
    public GameObject MeatSmoothie;

    public CustomerTest CustomerTestScript; //customer script

    public bool TimerRunning;

    public GameObject OvenInteractPrompt;
    public GameObject ChoppingBoardInteractPrompt;
    public GameObject BlenderInteractPrompt;

    public GameObject TutorialEnd;

    public Tutorial TutorialScript;

    public PlayerScript player;

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
    public bool PlayerRightHandFull;

    public int TrashTimerInt;

    public void Start()
    {
        StartCoroutine(TrashSliderTimer());

    }

    public void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            InteractButton();
        }

        if(Input.GetKey(KeyCode.Alpha4) && !TimerRunning)
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
    }

    public void InteractButton()
    {
        player.target = player.transform.position;

        if(OvenInRange)
        {
            //check what food the player has

           if(FridgeScript.HoldingBamboo) //if the players holding bamboo
           {
                OvenInteractPrompt.SetActive(true);
           }

            if(FoodCooked)
            {
                OvenOn = false;
                CookedBamboo.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }
        }
        if (BlenderinRange)
        {
            //check what food the player has

            if (FridgeScript.HoldingMeat) //if the players holding bamboo
            {
                BlenderInteractPrompt.SetActive(true);
            }

            if (SmoothieMade)
            {
                MeatSmoothie.SetActive(true);
                BlenderInteractPrompt.SetActive(false);
                BlenderTimerValue = 0;
                BlenderTimerSlider.value = BlenderTimerValue;
                BlenderValueColour.color = new Color32(76, 211, 255, 255);
            }
        }

        if (FridgeInRange) //open the fridge UI
        {
            if(!FridgeOpen)
            {
                PlayerMove.target = PlayerMove.transform.position;
                FridgeUI.SetActive(true);
                FridgeOpen = true;
                FridgeLight.SetActive(true);
                StartCoroutine(FridgeLightOverlay());
                if(TutorialScript.TutorialImages == 11)
                {
                    TutorialScript.NextTutorial();
                }
            }
            else
            {
                FridgeUI.SetActive(false);
                FridgeOpen = false;
                FridgeLight.SetActive(false);

                if (TutorialScript.TutorialImages == 13)
                {
                    TutorialScript.NextTutorial();
                }
            }
        }


        if(ChoppingBoardInRange)
        {
            if(FoodCooked) //if the food is cooked
            {
                ChoppingBoardInteractPrompt.SetActive(true);
                StartCoroutine(ChoppingTimer());
            }
        }

        if(PandaInRange)
        {
            if (MealReady) //when the meal is cooked
            {
                BambooHotdog.SetActive(false); //disable the bamboo hotdog
                CustomerTestScript.Fed();//call to the customer script
                if (TutorialScript.TutorialImages == 16)
                {
                    TutorialScript.NextTutorial();
                }
            }
        }
        
        if(BedInRange)
        {
            TutorialEnd.SetActive(true);
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

            if (ToKitchenArea && TutorialScript.TutorialImages == 10)
            {
                TutorialScript.NextTutorial();
            }
        }

        if (ToBedroomArea)
        {
            Camera.transform.position = new Vector3(-89, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(-66, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position;

            if (ToBedroomArea && TutorialScript.TutorialImages == 17)
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
            FireExtinguisherHeld = true;
            FireExtinguisher.SetActive(false);
            FireExtinguisherPlayer.SetActive(true);
            EmptyFireExtinguisher.SetActive(true);
        }

        if(FireExtinguisherInRange && FireExtinguisherHeld)
        {
            FireExtinguisherHeld = false;
            FireExtinguisher.SetActive(true);
            FireExtinguisherPlayer.SetActive(false);
            EmptyFireExtinguisher.SetActive(false);
            FireExtinguisherinUsePlayer.SetActive(false);
            FireExtinguishUse = false;

        }

        if (BroomInRange)
        {
            BroomHeld = true;
            Broom.SetActive(false);
            BroomPlayer.SetActive(true);
            EmptyBroom.SetActive(true);
        }

        if (BroomInRange && BroomHeld)
        {
            BroomHeld = false;
            Broom.SetActive(true);
            BroomPlayer.SetActive(false);
            EmptyBroom.SetActive(false); 
        }

        if(TrashBag1inRange)
        {
            TrashBags[0].SetActive(false);
            TrashBagHeld = true;
            TrashBagObject.SetActive(true);
        }

        if (TrashBag2inRange)
        {
            TrashBags[1].SetActive(false);
            TrashBagHeld = true;
            TrashBagObject.SetActive(true);
        }

        if (TrashBag3inRange)
        {
            TrashBags[2].SetActive(false);
            TrashBagHeld = true;
            TrashBagObject.SetActive(true);
        }

        if(TrashBininRange)
        {
            FridgeScript.MeatIcon.SetActive(false);
            FridgeScript.BambooIcon.SetActive(false);
            FridgeScript.BreadIcon.SetActive(false);
            TrashTimerValue = TrashTimerValue + 0.15f;
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
        yield return new WaitForSeconds(0.25f);
        ChoppingBoardTimerValue = ChoppingBoardTimerValue + 0.125f;
        ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
        StartCoroutine(ChoppingTimer());

        if(ChoppingBoardTimerValue > 1)
        {
            CookedBamboo.SetActive(false);
            Bread.SetActive(false);
            Bamboo.SetActive(false);
            BambooHotdog.SetActive(true); //enable the bamboo hotdog gameobject
            MealReady = true;
            TimerRunning = false;
            ChoppingBoardInteractPrompt.SetActive(false);
            if (TutorialScript.TutorialImages == 15)
            {
                TutorialScript.NextTutorial();
            }
        }
    }

    IEnumerator BlenderTimer()
    {
        yield return new WaitForSeconds(0.25f);
        BlenderTimerValue = BlenderTimerValue + 0.125f;
        BlenderTimerSlider.value = BlenderTimerValue;
        if (!SmoothieMade)
        {
            StartCoroutine(BlenderTimer());
        }

        if(BlenderTimerValue > 1)
        {
            SmoothieMade = true;
            TimerRunning = false;
            BlenderValueColour.color = new Color32(113, 255, 76, 255);
        }
    }
    IEnumerator OvenTimer()
    {
        OvenOn = true;
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

            if (TutorialScript.TutorialImages == 14)
            {
                TutorialScript.NextTutorial();
            }
        }

        if (OvenTimerValue > 2)
        {
            OvenValueColour.color = new Color32(255, 76, 76, 255);
            FireController.SetActive(true);
        }
            
    }

    IEnumerator TrashSliderTimer()
    {
        TrashTimerValue = TrashTimerValue + 0.0015f;
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
        StartCoroutine(BlenderTimer());
        Meat.SetActive(false);
        BlenderInteractPrompt.SetActive(false);
        FridgeScript.HoldingMeat = false;
    }

    public void ChoppingBoardPopUpCross()
    {
        BlenderInteractPrompt.SetActive(false);
    }
}
