using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// This script is used on the Interact button, to see if the player can interact with the objects surrounding them.
/// This script is very long, but it can be optimised.
/// </summary>
public class Interact : MonoBehaviour
{
    [Header("In Range Bools")]
    public bool OvenInRange; //if the oven is in range
    public bool ChoppingBoardInRange; //if the chopping board is in range
    public bool FridgeInRange; //if the fridge is in range
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

    public bool DirtyPlate1inRange;
    public bool DirtyPlate2inRange;
    public bool DirtyPlate3inRange;
    public bool DirtyPlate4inRange;

    public bool SinkinRange;
    public bool Coin1inRange;
    public bool Coin2inRange;
    public bool Coin3inRange;
    public bool Coin4inRange;

    public bool PandaInRange; //is the player in range of the panda
    public bool AdderInRange;
    public bool LeopardInRange;
    public bool PonyInRange;
    public bool HedgehogInRange;
    public bool GiraffeInRange;
    public bool FerretInRange;
    public bool KangarooInRange;
    public bool ChimpInRange;
    public bool BeaverInRange;
    public bool GemsbokInRange;
    public bool IbexInRange;
    public bool DuckInRange;
    public bool PangolinInRange;
    public bool ChipmunkInRange;
    public bool PlatypusInRange;
    public bool BatInRange;
    public bool RaccoonInRange;
    public bool AlpacaInRange;
    public bool FoxInRange;

    [Header("Other Bools")]
    public bool FireExtinguishUse;
    public bool TrashBagHeld;
    public bool FridgeOpen; //is the fridge window open
    public bool BroomHeld;
    public bool DirtyPlateHeld;
    public bool FireExtinguisherHeld;
    public bool WashingDone;


    [Header("Cooking Bools")]
    public bool BambooCooked; //is the food cooked
    public bool BonesCooked;
    public bool MeatCooked;
    public bool AntCooked;
    public bool ClamCooked;
    public bool CrayfishCooked;
    public bool MelonCooked;
    public bool MossCooked;
    public bool StickCooked;
    public bool WormCooked;
    public bool SpaghettiCooked;
    public bool AntandSpaghettiCooked;
    public bool MushroomsCooked;

    public bool MeatSmoothieMade; //smoothie made
    public bool AntSmoothieMade;
    public bool MelonSmoothieMade;
    public bool StrawberryandAppleSmoothieMade;

    public bool BambooCooking;
    public bool BonesCooking;
    public bool MeatCooking;
    public bool AntCooking;
    public bool ClamCooking;
    public bool CrayfishCooking;
    public bool MelonCooking;
    public bool MossCooking;
    public bool StickCooking;
    public bool WormCooking;
    public bool SpaghettiCooking;
    public bool AntandSpaghettiCooking;
    public bool MushroomsCooking;

    public bool BambooHotdogChopping; //when the bamboo hot dog has been collected
    public bool AntandSpaghettiChopping;
    public bool AntPastaChopping;
    public bool BoneBrothChopping;
    public bool ClamMisoSoupChopping;
    public bool CrayfishTempuraChopping;
    public bool EscargotChopping;
    public bool FruitSaladChopping;
    public bool HaySaladChopping;
    public bool LeafSaladChopping;
    public bool MelonMealChopping;
    public bool MossBurgerChopping;
    public bool MothBiscuitChopping;
    public bool MouseBurgerChopping;
    public bool VenisonSteakChopping;
    public bool WormSpaghettiChopping;
    public bool StickHotdogChopping;

    //chopping board collection bools
    public bool BambooHotdogPrepared; //called from the chopping board when the timer is done
    public bool AntandSpaghettiPrepared;
    public bool AntPastaPrepared;
    public bool BoneBrothPrepared;
    public bool ClamMisoSoupPrepared;
    public bool CrayfishTempuraPrepared;
    public bool EscargotPrepared;
    public bool FruitSaladPrepared;
    public bool StickHotdogPrepared;
    public bool HaySaladPrepared;
    public bool LeafSaladPrepared;
    public bool MelonMealPrepared;
    public bool MossBurgerPrepared;
    public bool MothBiscuitPrepared;
    public bool MouseBurgerPrepared;
    public bool VenisonSteakPrepared;
    public bool WormSpaghettiPrepared;

    public bool BambooHotdogReady; //when the bamboo hot dog has been collected
    public bool AntandSpaghettiReady;
    public bool AntPastaReady;
    public bool BoneBrothReady;
    public bool ClamMisoSoupReady;
    public bool CrayfishTempuraReady;
    public bool EscargotReady;
    public bool FruitSaladReady;
    public bool HaySaladReady;
    public bool LeafSaladReady;
    public bool MelonMealReady;
    public bool MossBurgerReady;
    public bool MothBiscuitReady;
    public bool MouseBurgerReady;
    public bool VenisonSteakReady;
    public bool WormSpaghettiReady;
    public bool StickHotdogReady;

    [Header("Fridge Assets")]
    public GameObject FridgeUI; //fridge ui window
    public Fridge FridgeScript; //fridge script

    [Header("Food Gameobjects")]
    public GameObject HoldingBambooGO; //if the player is holding bamboo or not
    public GameObject HoldingBreadGO; //if the player is holding bread or not
    public GameObject HoldingMeatGO;
    public GameObject HoldingStrawberryGO; //if the player is holding bamboo or not
    public GameObject HoldingAppleGO; //if the player is holding bread or not
    public GameObject HoldingWormsGO;
    public GameObject HoldingTomatoGO;
    public GameObject HoldingAntGO; //if the player is holding bread or not
    public GameObject HoldingHayGO;
    public GameObject HoldingLeafGO;
    public GameObject HoldingBoneGO;
    public GameObject HoldingMossGO;
    public GameObject HoldingMelonGO;
    public GameObject HoldingStickGO;
    public GameObject HoldingSpiceGO;
    public GameObject HoldingSnailGO;
    public GameObject HoldingMushroomGO;
    public GameObject HoldingPastaGO;
    public GameObject HoldingCrayfishGO;
    public GameObject HoldingFlourGO;
    public GameObject HoldingMothGO;
    public GameObject HoldingClamGO;

    [Header("Cooked Food Gameobjects")]
    public GameObject CookedBamboo; //cooked bamboo gameobject that the player holds
    public GameObject CookedAntandSpaghetti;
    public GameObject CookedBoneBroth;
    public GameObject CookedAnt;
    public GameObject CookedClam;
    public GameObject CookedCrayfish;
    public GameObject CookedMeat;
    public GameObject CookedMelon;
    public GameObject CookedMoss;
    public GameObject CookedStick;
    public GameObject CookedWorms;
    public GameObject CookedSpaghetti;

    [Header("Recipe Gameobjects")]
    public GameObject BambooHotdog; //bamboo hotdog gameobject that the player holds
    public GameObject AntPasta;
    public GameObject BoneBroth;
    public GameObject ClamMisoSoup;
    public GameObject CookedMushrooms;
    public GameObject CrayfishTempura;
    public GameObject Escargot;
    public GameObject FruitSalad;
    public GameObject HaySalad;
    public GameObject LeafSalad;
    public GameObject MelonMeal;
    public GameObject MossBurger;
    public GameObject MothBiscuit;
    public GameObject MouseBurger;
    public GameObject StickHotdog;
    public GameObject VenisonSteak;
    public GameObject WormSpaghetti;
    public GameObject MeatSmoothie;
    public GameObject StrawberryandAppleSmoothie;
    public GameObject AntSmoothie;
    public GameObject MelonSmoothie;

    public GameObject DirtyPlate;

    public PandaCustomer PandaCustomerScript; //customer script
    public LeopardCustomer LeopardCustomerScript;
    public AdderCustomer AdderCustomerScript;
    public AlpacaCustomer AlpacaCustomerScript;
    public BatCustomer BatCustomerScript;
    public BeaverCustomer BeaverCustomerScript;
    public ChimpCustomer ChimpCustomerScript;
    public ChipmunkCustomer ChipmunkCustomerScript;
    public DuckCustomer DuckCustomerScript;
    public FerretCustomer FerretCustomerScript;
    public FoxCustomer FoxCustomerScript;
    public GemsbokCustomer GemsbokCustomerScript;
    public GiraffeCustomer GiraffeCustomerScript;
    public HedgehogCustomer HedgehogCustomerScript;
    public IbexCustomer IbexCustomerScript;
    public KangarooCustomer KangarooCustomerScript;
    public PangolinCustomer PangolinCustomerScript;
    public PlatypusCustomer PlatypusCustomerScript;
    public PonyCustomer PonyCustomerScript;
    public RaccoonCustomer RaccoonCustomerScript;



    public bool TimerRunning;

    public GameObject OvenInteractPrompt;
    public GameObject ChoppingBoardInteractPrompt;
    public GameObject BlenderInteractPrompt;
    public GameObject SinkInteractPrompt;

    public GameObject TutorialEnd;
    public GameObject Day1End;
    public GameObject Day2End;
    public GameObject Day3End;
    public GameObject Day4End;
    public GameObject Day5End;

    public Tutorial TutorialScript;
    public Dialogue DialogueScript;
    public PlayerScript PlayerScript;

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

    public GameObject[] DirtyPlateTable;

    public bool DayEnd;

    public bool OnFire;

    public bool Washup2;

    public GameObject[] Coins;

    public AudioSource ButtonClick;
    public GameObject ButtonSource;

    public AudioSource BlenderNoise;
    public AudioSource OvenNoise;
    public AudioSource SinkNoise;
    public AudioSource FireExtinguisherNoise;
    public AudioSource ChoppingBoardNoise;
    public AudioSource CoinPickup;

    public bool AlreadyFed;

    public void Start()
    {
        //StartCoroutine(TrashSliderTimer());
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
        if (other.tag == "Coin4")
        {
            Coin4inRange = true;
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

        if(other.tag == "PandaCustomer")
        {
            PandaInRange = true;
        }

        if (other.tag == "AdderCustomer")
        {
            AdderInRange = true;
        }

        if (other.tag == "LeopardCustomer")
        {
            LeopardInRange = true;
        }

        if (other.tag == "PonyCustomer")
        {
            PonyInRange = true;
        }

        if (other.tag == "HedgehogCustomer")
        {
            HedgehogInRange = true;
        }

        if (other.tag == "GiraffeCustomer")
        {
            GiraffeInRange = true;
        }

        if (other.tag == "FerretCustomer")
        {
            FerretInRange = true;
        }

        if (other.tag == "KangarooCustomer")
        {
            KangarooInRange = true;
        }

        if (other.tag == "ChimpCustomer")
        {
            ChimpInRange = true;
        }

        if (other.tag == "BeaverCustomer")
        {
            BeaverInRange = true;
        }

        if (other.tag == "GemsbokCustomer")
        {
            GemsbokInRange = true;
        }

        if (other.tag == "IbexCustomer")
        {
            IbexInRange = true;
        }

        if (other.tag == "DuckCustomer")
        {
            DuckInRange = true;
        }

        if (other.tag == "PangolinCustomer")
        {
            PangolinInRange = true;
        }

        if (other.tag == "ChipmunkCustomer")
        {
            ChipmunkInRange = true;
        }

        if (other.tag == "PlatypusCustomer")
        {
            PlatypusInRange = true;
        }

        if (other.tag == "BatCustomer")
        {
            BatInRange = true;
        }

        if (other.tag == "RaccoonCustomer")
        {
            RaccoonInRange = true;
        }

        if (other.tag == "AlpacaCustomer")
        {
            AlpacaInRange = true;
        }

        if (other.tag == "FoxCustomer")
        {
            FoxInRange = true;
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

        if(other.tag == "DirtyPlate1")
        {
            DirtyPlate1inRange = true;
        }

        if (other.tag == "DirtyPlate2")
        {
            DirtyPlate2inRange = true;
        }

        if (other.tag == "DirtyPlate3")
        {
            DirtyPlate3inRange = true;
        }

        if (other.tag == "DirtyPlate4")
        {
            DirtyPlate4inRange = true;
        }

        if (other.tag == "Sink")
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
        if (other.tag == "Coin4")
        {
            Coin4inRange = false;
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
        if (other.tag == "PandaCustomer")
        {
            PandaInRange = false;
            
            if (TutorialScript.TutorialImages == 9)
            {
                TutorialScript.NextTutorial();
            }

        }

        if (other.tag == "AdderCustomer")
        {
            AdderInRange = false;
        }

        if (other.tag == "LeopardCustomer")
        {
            LeopardInRange = false;
        }

        if (other.tag == "PonyCustomer")
        {
            PonyInRange = false;
        }

        if (other.tag == "HedgehogCustomer")
        {
            HedgehogInRange = false;
        }

        if (other.tag == "GiraffeCustomer")
        {
            GiraffeInRange = false;
        }

        if (other.tag == "FerretCustomer")
        {
            FerretInRange = false;
        }

        if (other.tag == "KangarooCustomer")
        {
            KangarooInRange = false;
        }

        if (other.tag == "ChimpCustomer")
        {
            ChimpInRange = false;
        }

        if (other.tag == "BeaverCustomer")
        {
            BeaverInRange = false;
        }

        if (other.tag == "GemsbokCustomer")
        {
            GemsbokInRange = false;
        }

        if (other.tag == "IbexCustomer")
        {
            IbexInRange = false;
        }

        if (other.tag == "DuckCustomer")
        {
            DuckInRange = false;
        }

        if (other.tag == "PangolinCustomer")
        {
            PangolinInRange = false;
        }

        if (other.tag == "ChipmunkCustomer")
        {
            ChipmunkInRange = false;
        }

        if (other.tag == "PlatypusCustomer")
        {
            PlatypusInRange = false;
        }

        if (other.tag == "BatCustomer")
        {
            BatInRange = false;
        }

        if (other.tag == "RaccoonCustomer")
        {
            RaccoonInRange = false;
        }

        if (other.tag == "AlpacaCustomer")
        {
            AlpacaInRange = false;
        }

        if (other.tag == "FoxCustomer")
        {
            FoxInRange = false;
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

        if (other.tag == "DirtyPlate1")
        {
            DirtyPlate1inRange = false;
        }

        if (other.tag == "DirtyPlate2")
        {
            DirtyPlate2inRange = false;
        }

        if (other.tag == "DirtyPlate3")
        {
            DirtyPlate3inRange = false;
        }

        if (other.tag == "DirtyPlate4")
        {
            DirtyPlate4inRange = false;
        }

        if (other.tag == "Sink")
        {
            SinkinRange = false;
        }
    }

    public void InteractButton()
    {
        PlayerScript.target = PlayerScript.transform.position;
        ButtonClick.Play();

        if(Coin1inRange)
        {
            Coin1inRange = false;
            CoinPickup.Play();
            PlayerScript.gold = PlayerScript.gold + 10;
            Coins[1].SetActive(false);
        }

        if (Coin2inRange)
        {
            Coin1inRange = false;
            CoinPickup.Play();
            PlayerScript.gold = PlayerScript.gold + 10;
            Coins[2].SetActive(false);
        }

        if (Coin3inRange)
        {
            Coin1inRange = false;
            CoinPickup.Play();
            PlayerScript.gold = PlayerScript.gold + 10;
            Coins[3].SetActive(false);
        }

        if (Coin4inRange)
        {
            Coin1inRange = false;
            CoinPickup.Play();
            PlayerScript.gold = PlayerScript.gold + 10;
            Coins[4].SetActive(false);
        }

        if (OvenInRange && !OnFire)
        {
            //check what food the player has

           if(FridgeScript.HoldingPasta || FridgeScript.HoldingWorms || FridgeScript.HoldingStick || FridgeScript.HoldingMoss || FridgeScript.HoldingMelon || FridgeScript.HoldingMeat || FridgeScript.HoldingCrayfish || FridgeScript.HoldingClam || FridgeScript.HoldingAnt || FridgeScript.HoldingBone || FridgeScript.HoldingBamboo && !OnFire) //if the players holding bamboo
           {
                OvenInteractPrompt.SetActive(true);
           }

           if(StickCooked || MossCooked || MelonCooked || MeatCooked || CrayfishCooked || ClamCooked || AntCooked || BambooCooked && PlayerRightHandFull)
           {
                StartCoroutine(HandUITimer());
           }

            if (SpaghettiCooked || BonesCooked || AntandSpaghettiCooked && PlayerLeftHandFull)
            {
                StartCoroutine(HandUITimer());
            }

            if (BambooCooked && !PlayerLeftHandFull && !OnFire)
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

            if (CrayfishCooked && !PlayerRightHandFull && !OnFire)
            {
                OvenOn = false;
                CookedCrayfish.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerRightHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (AntCooked && !PlayerLeftHandFull && !OnFire)
            {
                OvenOn = false;
                CookedAnt.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (BonesCooked && !PlayerRightHandFull && !OnFire)
            {
                OvenOn = false;
                CookedBoneBroth.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerRightHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (ClamCooked && !PlayerLeftHandFull && !OnFire)
            {
                OvenOn = false;
                CookedClam.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (MeatCooked && !PlayerLeftHandFull && !OnFire && DialogueScript.AdderMeal || DialogueScript.FoxMeal)
            {
                OvenOn = false;
                CookedMeat.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }

            if(MeatCooked && !PlayerRightHandFull && !PlayerLeftHandFull && !OnFire && DialogueScript.LeopardMeal)
            {
                OvenOn = false;
                MeatCooked = false;
                VenisonSteak.SetActive(true);
                VenisonSteakPrepared = true;
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }

            if(MushroomsCooked && !PlayerRightHandFull && !PlayerLeftHandFull && !OnFire)
            {
                OvenOn = false;
                CookedMushrooms.SetActive(true);
                MushroomsCooked = true;
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (MelonCooked && !PlayerLeftHandFull && !OnFire)
            {
                OvenOn = false;
                CookedMelon.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (MossCooked && !PlayerLeftHandFull && !OnFire)
            {
                OvenOn = false;
                CookedMoss.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }


            if (StickCooked && !PlayerLeftHandFull && !OnFire)
            {
                OvenOn = false;
                CookedStick.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerLeftHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }


            if (WormCooked && !PlayerRightHandFull && !OnFire)
            {
                OvenOn = false;
                CookedWorms.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerRightHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }


            if (SpaghettiCooked && !PlayerRightHandFull && !OnFire)
            {
                OvenOn = false;
                CookedSpaghetti.SetActive(true);
                OvenInteractPrompt.SetActive(false);
                OvenTimerValue = 0;
                OvenTimerSlider.value = OvenTimerValue;
                PlayerRightHandFull = true;
                OvenValueColour.color = new Color32(76, 211, 255, 255);
            }
        }

        if (BlenderinRange && !OnFire) //DONE!
        {
            //check what food the player has

            if (FridgeScript.HoldingMeat || FridgeScript.HoldingStrawberry && FridgeScript.HoldingApple || FridgeScript.HoldingMelon || FridgeScript.HoldingAnt) //if the players holding bamboo
            {
                BlenderInteractPrompt.SetActive(true);
            }

            if(StrawberryandAppleSmoothieMade || MelonSmoothieMade || AntSmoothieMade || MeatSmoothieMade && PlayerLeftHandFull)
            {
                StartCoroutine(HandUITimer());
            }

            if (MeatSmoothieMade && !PlayerLeftHandFull)
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

            if (AntSmoothieMade && !PlayerLeftHandFull)
            {
                AntSmoothie.SetActive(true);
                BlenderInteractPrompt.SetActive(false);
                BlenderTimerValue = 0;
                BlenderTimerSlider.value = BlenderTimerValue;
                BlenderValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (MelonSmoothieMade && !PlayerLeftHandFull)
            {
                MelonSmoothie.SetActive(true);
                BlenderInteractPrompt.SetActive(false);
                BlenderTimerValue = 0;
                BlenderTimerSlider.value = BlenderTimerValue;
                BlenderValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (StrawberryandAppleSmoothieMade && !PlayerLeftHandFull)
            {
                StrawberryandAppleSmoothie.SetActive(true);
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
                PlayerScript.target = PlayerScript.transform.position;
                FridgeUI.SetActive(true);
                FridgeOpen = true;
                FridgeLight.SetActive(true);
                StartCoroutine(FridgeLightOverlay());
                if (TutorialScript.TutorialImages == 15)
                {
                    TutorialScript.NextTutorial();
                }
            }
            else
            {
                FridgeUI.SetActive(false);
                FridgeOpen = false;
                FridgeLight.SetActive(false);
                if (TutorialScript.TutorialImages == 25)
                {
                    TutorialScript.NextTutorial();
                }
            }
        }

        if(ChoppingBoardInRange && !OnFire)
        {
            if(BambooCooked && FridgeScript.HoldingBread || MeatCooked && FridgeScript.HoldingBread || FridgeScript.HoldingHay || FridgeScript.HoldingTomato && CookedWorms || FridgeScript.HoldingLeaf || CookedBoneBroth || CookedMoss && FridgeScript.HoldingBread || FridgeScript.HoldingStrawberry && FridgeScript.HoldingApple || CookedStick && FridgeScript.HoldingBread || CookedMelon && FridgeScript.HoldingSpice || FridgeScript.HoldingSnail || CookedAntandSpaghetti && FridgeScript.HoldingTomato || CookedCrayfish && FridgeScript.HoldingFlour || FridgeScript.HoldingMoth && FridgeScript.HoldingFlour || CookedClam && FridgeScript.HoldingSpice) //if the food is cooked
            {
                ChoppingBoardInteractPrompt.SetActive(true);
            }

            if(BambooHotdogPrepared)
            {
                CookedBamboo.SetActive(false);
                HoldingBreadGO.SetActive(false);
                BambooHotdog.SetActive(true); //enable the bamboo hotdog gameobject
                BambooHotdogReady = true;
                BambooCooked = false;

                BambooHotdogChopping = false;
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                BambooHotdogPrepared = false;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);

                if (TutorialScript.TutorialImages == 27)
                {
                    TutorialScript.NextTutorial();
                }
            }

            if(MouseBurgerPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                MouseBurgerPrepared = false;
                MouseBurgerReady = true;
                MouseBurgerChopping = false;
                MouseBurger.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (HaySaladPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                HaySaladPrepared = false;
                HaySaladReady = true;
                HaySaladChopping = false;
                HaySalad.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }


            if (WormSpaghettiPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                WormSpaghettiPrepared = false;
                WormSpaghettiReady = true;
                WormSpaghetti.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                WormSpaghettiChopping = false;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (LeafSaladPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                LeafSaladPrepared = false;
                LeafSaladReady = true;
                LeafSaladChopping = false;
                LeafSalad.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (BoneBrothPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                BoneBrothPrepared = false;
                BoneBrothReady = true;
                BoneBrothChopping = false;
                BoneBroth.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }


            if (MossBurgerPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                MossBurgerPrepared = false;
                MossBurgerReady = true;
                MossBurgerChopping = false;
                MossBurger.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }


            if (FruitSaladPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                FruitSaladPrepared = false;
                FruitSaladReady = true;
                FruitSaladChopping = false;
                FruitSalad.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }


            if (StickHotdogPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                StickHotdogPrepared = false;
                StickHotdogReady = true;
                StickHotdogChopping = false;
                StickHotdog.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (MelonMealPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                MelonMealPrepared = false;
                MelonMealReady = true;
                MelonMealChopping = false;
                MelonMeal.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (EscargotPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                EscargotPrepared = false;
                EscargotReady = true;
                EscargotChopping = false;
                Escargot.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (AntPastaPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                AntPastaPrepared = false;
                AntPastaReady = true;
                AntPastaChopping = false;
                AntPasta.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }


            if (CrayfishTempuraPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                CrayfishTempuraPrepared = false;
                CrayfishTempuraChopping = false;
                CrayfishTempuraReady = true;
                CrayfishTempura.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (MothBiscuitPrepared)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                MothBiscuitPrepared = false;
                MothBiscuitReady = true;
                MothBiscuitChopping = false;
                MothBiscuit.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }

            if (ClamMisoSoupChopping)
            {
                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;
                ClamMisoSoupPrepared = false;
                ClamMisoSoupReady = true;
                ClamMisoSoupChopping = false;
                ClamMisoSoup.SetActive(true); //enable the bamboo hotdog gameobject

                PlayerLeftHandFull = true;
                PlayerRightHandFull = true;

                ChoppingBoardInteractPrompt.SetActive(false);
                ChoppingBoardTimerValue = 0;
                ChoppingBoardTimerSlider.value = ChoppingBoardTimerValue;
                ChoppingBoardValueColour.color = new Color32(76, 211, 255, 255);
            }
        }

        if(PandaInRange)
        {
            if (BambooHotdogReady) //when the meal is cooked
            {
                BambooHotdog.SetActive(false); //disable the bamboo hotdog
                PandaCustomerScript.FedMeal();//call to the customer script
                BambooHotdogReady = false;
                PlayerRightHandFull = false;
                PlayerLeftHandFull = false;

                if (TutorialScript.TutorialImages == 28)
                {
                    TutorialScript.NextTutorial();
                }
            }

            if (MeatSmoothieMade && !AlreadyFed) //when the meal is cooked
            {
                AlreadyFed = true;
                MeatSmoothie.SetActive(false); //disable the bamboo hotdog
                PandaCustomerScript.FedSmoothie();//call to the customer script
                MeatSmoothieMade = false;
                PlayerLeftHandFull = false;

                if (TutorialScript.TutorialImages == 19)
                {
                    TutorialScript.NextTutorial();
                }
            }
        }

        if (AdderInRange)
        {
            if (MouseBurgerReady)
            {
                MouseBurger.SetActive(false);
                AdderCustomerScript.FedMeal();
                MouseBurgerReady = false;
                PlayerRightHandFull = false;
                PlayerLeftHandFull = false;
            }
        }
        
        if(BedInRange)
        {
            if(DayEnd)
            {
                TutorialEnd.SetActive(true);
            }
        }

        if (FireExtinguisherInRange && FireExtinguisherHeld)
        {
            FireExtinguisherHeld = false;
            FireExtinguisher.SetActive(true);
            FireExtinguisherPlayer.SetActive(false);
            EmptyFireExtinguisher.SetActive(false);
            FireExtinguisherinUsePlayer.SetActive(false);
            FireExtinguishUse = false;
            PlayerRightHandFull = false;
        }

        if (FireExtinguisherHeld && !FireExtinguishUse)
        {
            FireExtinguisherNoise.Play();
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


        if (BroomInRange && !BroomHeld) //no change needed
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

        if (BroomInRange && BroomHeld)  //no change needed
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

        if (TrashBininRange)
        {
            HoldingAntGO.SetActive(false);
            HoldingAppleGO.SetActive(false);
            HoldingBoneGO.SetActive(false);
            HoldingClamGO.SetActive(false);
            HoldingCrayfishGO.SetActive(false);
            HoldingFlourGO.SetActive(false);
            HoldingHayGO.SetActive(false);
            HoldingLeafGO.SetActive(false);
            HoldingMelonGO.SetActive(false);
            HoldingMossGO.SetActive(false);
            HoldingMothGO.SetActive(false);
            HoldingMushroomGO.SetActive(false);
            HoldingPastaGO.SetActive(false);
            HoldingSnailGO.SetActive(false);
            HoldingSpiceGO.SetActive(false);
            HoldingStickGO.SetActive(false);
            HoldingStrawberryGO.SetActive(false);
            HoldingTomatoGO.SetActive(false);
            HoldingWormsGO.SetActive(false);
            HoldingMeatGO.SetActive(false);
            HoldingBambooGO.SetActive(false);
            HoldingBreadGO.SetActive(false);
            
            FridgeScript.HoldingBamboo = false;
            FridgeScript.HoldingBread = false;
            FridgeScript.HoldingMeat = false;
            FridgeScript.HoldingAnt = false;
            FridgeScript.HoldingApple = false;
            FridgeScript.HoldingBone = false;
            FridgeScript.HoldingClam = false;
            FridgeScript.HoldingCrayfish = false;
            FridgeScript.HoldingFlour = false;
            FridgeScript.HoldingHay = false;
            FridgeScript.HoldingLeaf = false;
            FridgeScript.HoldingMelon = false;
            FridgeScript.HoldingMoss = false;
            FridgeScript.HoldingMushroom = false;
            FridgeScript.HoldingPasta = false;
            FridgeScript.HoldingSnail = false;
            FridgeScript.HoldingSpice = false;
            FridgeScript.HoldingStick = false;
            FridgeScript.HoldingStrawberry = false;
            FridgeScript.HoldingTomato = false;
            FridgeScript.HoldingWorms = false;

            StrawberryandAppleSmoothie.SetActive(false);
            AntSmoothie.SetActive(false);
            MelonSmoothie.SetActive(false);
            MeatSmoothie.SetActive(false);

            BambooHotdog.SetActive(false);
            AntPasta.SetActive(false);
            BoneBroth.SetActive(false);
            ClamMisoSoup.SetActive(false);
            CrayfishTempura.SetActive(false);
            Escargot.SetActive(false);
            FruitSalad.SetActive(false);
            HaySalad.SetActive(false);
            LeafSalad.SetActive(false);
            MelonMeal.SetActive(false);
            MossBurger.SetActive(false);
            MothBiscuit.SetActive(false);
            MouseBurger.SetActive(false);
            StickHotdog.SetActive(false);
            VenisonSteak.SetActive(false);
            WormSpaghetti.SetActive(false);

            CookedBamboo.SetActive(false);
            CookedAntandSpaghetti.SetActive(false);
            CookedBoneBroth.SetActive(false);
            CookedAnt.SetActive(false);
            CookedClam.SetActive(false);
            CookedCrayfish.SetActive(false);
            CookedMeat.SetActive(false);
            CookedMelon.SetActive(false);
            CookedMoss.SetActive(false);
            CookedStick.SetActive(false);
            CookedWorms.SetActive(false);
            CookedSpaghetti.SetActive(false);

            MeatSmoothieMade = false;
            AntSmoothieMade = false;
            MelonSmoothieMade = false;
            StrawberryandAppleSmoothieMade = false;

            BambooCooked = false;
            BonesCooked = false;
            AntCooked = false;
            ClamCooked = false;
            CrayfishCooked = false;
            MelonCooked = false;
            MossCooked = false;
            StickCooked = false;
            WormCooked = false;
            SpaghettiCooked = false;
            AntandSpaghettiCooked = false;
            MushroomsCooked = false; 

            BambooHotdogReady = false;
            AntPastaReady = false;
            BoneBrothReady = false;
            ClamMisoSoupReady = false;
            CrayfishTempuraReady = false;
            EscargotReady = false;
            FruitSaladReady = false;
            HaySaladReady = false;
            LeafSaladReady = false;
            MelonMealReady = false;
            MossBurgerReady = false;
            MothBiscuitReady = false;
            MouseBurgerReady = false;
            StickHotdogReady = false;
            VenisonSteakReady = false;
            WormSpaghettiReady = false;

            TrashTimerValue = TrashTimerValue + 0.15f;
            PlayerRightHandFull = false;
            PlayerLeftHandFull = false;
        }

        if (WardrobeInRange) //open the fridge UI
        {
            if (!WardrobeOpen)
            {
                PlayerScript.target = PlayerScript.transform.position;
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
    
        if(DirtyPlate1inRange)
        {
            if(!PlayerRightHandFull)
            {
                DirtyPlateHeld = true;
                DirtyPlate.SetActive(true);
                DirtyPlateTable[1].SetActive(false);
                PlayerRightHandFull = true;
            }
            else
            {
                StartCoroutine(HandUITimer());
            }
        }

        if (DirtyPlate2inRange)
        {
            if (!PlayerRightHandFull)
            {
                DirtyPlateHeld = true;
                DirtyPlate.SetActive(true);
                DirtyPlateTable[2].SetActive(false);
                PlayerRightHandFull = true;
            }
            else
            {
                StartCoroutine(HandUITimer());
            }
        }
        if (DirtyPlate3inRange)
        {
            if (!PlayerRightHandFull)
            {
                DirtyPlateHeld = true;
                DirtyPlate.SetActive(true);
                DirtyPlateTable[3].SetActive(false);
                PlayerRightHandFull = true;
            }
            else
            {
                StartCoroutine(HandUITimer());
            }
        }
        if (DirtyPlate4inRange)
        {
            if (!PlayerRightHandFull)
            {
                DirtyPlateHeld = true;
                DirtyPlate.SetActive(true);
                DirtyPlateTable[4].SetActive(false);
                PlayerRightHandFull = true;
            }
            else
            {
                StartCoroutine(HandUITimer());
            }
        }
        if (SinkinRange && DirtyPlateHeld)
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
        if (ChoppingBoardTimerValue == 1 && BambooHotdogChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            BambooHotdogPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && MouseBurgerChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            MouseBurgerPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && HaySaladChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            HaySaladPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && WormSpaghettiChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            WormSpaghettiPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && LeafSaladChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            LeafSaladPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && BoneBrothChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            BoneBrothPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && MossBurgerChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            MossBurgerPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && FruitSaladChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            FruitSaladPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && StickHotdogChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            StickHotdogPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && MelonMealChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            MelonMealPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && EscargotChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            EscargotPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && AntPastaChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            AntPastaPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && CrayfishTempuraChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            CrayfishTempuraPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && MothBiscuitChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            MothBiscuitPrepared = true;
        }

        if (ChoppingBoardTimerValue == 1 && ClamMisoSoupChopping)
        {
            ChoppingBoardValueColour.color = new Color32(113, 255, 76, 255);
            ClamMisoSoupPrepared = true;
        }

        if (ChoppingBoardTimerValue < 1)
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

        if (!MeatSmoothieMade && !AntSmoothieMade && !MelonSmoothieMade && !StrawberryandAppleSmoothieMade)
        {
            StartCoroutine(BlenderTimer());
        }

        if(BlenderTimerValue == 1 && DialogueScript.PandaDrink1 || DialogueScript.LeopardDrink || DialogueScript.PandaDrink2) 
        {
            MeatSmoothieMade = true;
            BlenderValueColour.color = new Color32(113, 255, 76, 255);

            if (TutorialScript.TutorialImages == 17)
            {
                TutorialScript.NextTutorial();
            }
            StopCoroutine(BlenderTimer());
        }

        if (BlenderTimerValue == 1 && DialogueScript.HedgehogDrink || DialogueScript.PangolinDrink || DialogueScript.BatDrink)
        {
            AntSmoothieMade = true;
            BlenderValueColour.color = new Color32(113, 255, 76, 255);
            StopCoroutine(BlenderTimer());
        }

        if (BlenderTimerValue == 1 && DialogueScript.GemsbokDrink || DialogueScript.KangarooDrink)
        {
            MelonSmoothieMade = true;
            BlenderValueColour.color = new Color32(113, 255, 76, 255);
            StopCoroutine(BlenderTimer());
        }

        if (BlenderTimerValue == 1 && DialogueScript.PonyDrink || DialogueScript.ChimpDrink || DialogueScript.AlpacaDrink)
        {
            StrawberryandAppleSmoothieMade = true;
            BlenderValueColour.color = new Color32(113, 255, 76, 255);
            StopCoroutine(BlenderTimer());
        }
    }

    IEnumerator SinkTimer()
    {
        PlayerScript.WashingUp = true;
        yield return new WaitForSeconds(0.25f);
        SinkTimerValue = SinkTimerValue + 0.125f;
        SinkTimerSlider.value = SinkTimerValue;
        if (SinkTimerValue < 1)
        {
            StartCoroutine(SinkTimer());
        }

        if (SinkTimerValue == 1)
        {
            PlayerScript.WashingUp = false;
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

        if (OvenTimerValue > 1 && BambooCooking)
        {
            BambooCooked = true;
            BambooCooking = false;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }

        if (OvenTimerValue > 1 && BonesCooking)
        {
            BonesCooked = true;
            BonesCooking = false;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }

        if (OvenTimerValue > 1 && MeatCooking)
        {
            MeatCooked = true;
            MeatCooking = false;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }

        if(OvenTimerValue > 1 && AntCooking)
        {
            AntCooking = false;
            AntCooked = true;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }

        if (OvenTimerValue > 1 && ClamCooking)
        {
            ClamCooking = false;
            ClamCooked = true;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }
        if (OvenTimerValue > 1 && CrayfishCooking)
        {
            CrayfishCooking = false;
            CrayfishCooked = true;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }
        if (OvenTimerValue > 1 && MelonCooking)
        {
            MelonCooking = false;
            MelonCooked = true;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }
        if (OvenTimerValue > 1 && MossCooking)
        {
            MossCooking = false;
            MossCooked = true;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }
        if (OvenTimerValue > 1 && StickCooking)
        {
            StickCooking = false;
            StickCooked = true;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }
        if (OvenTimerValue > 1 && WormCooking)
        {
            WormCooking = false;
            WormCooked = true;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }
        if (OvenTimerValue > 1 && SpaghettiCooking)
        {
            SpaghettiCooking = false;
            SpaghettiCooked = true;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }
        if (OvenTimerValue > 1 && AntandSpaghettiCooking)
        {
            AntandSpaghettiCooking = false;
            AntandSpaghettiCooked = true;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }
        if (OvenTimerValue > 1 && MushroomsCooking)
        {
            MushroomsCooking = false;
            MushroomsCooked = true;
            OvenValueColour.color = new Color32(113, 255, 76, 255);
        }
        if (OvenTimerValue > 3)
        {
            OnFire = true;
            OvenValueColour.color = new Color32(255, 76, 76, 255);
            FireController.SetActive(true);
        }
            
    }

    /*
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
    */

    IEnumerator FridgeLightOverlay()
    {
        yield return new WaitForSeconds(0.33f);
        FridgeLight.SetActive(false);
    }

    public void OvenPopupTick()
    {
        StartCoroutine(OvenTimer());
        OvenInteractPrompt.SetActive(false);
        OvenOn = true;
        OvenNoise.Play();
        ButtonClick.Play();
        
        if(FridgeScript.HoldingBamboo)
        {
            BambooCooking = true;
            PlayerLeftHandFull = false;
            HoldingBambooGO.SetActive(false);
        }

        if(FridgeScript.HoldingBone)
        {
            BonesCooking = true;
            PlayerRightHandFull = false;
            HoldingBoneGO.SetActive(false);
        }

        if (FridgeScript.HoldingMeat)
        {
            MeatCooking = true;
            PlayerLeftHandFull = false;
            HoldingMeatGO.SetActive(false);
        }

        if (FridgeScript.HoldingAnt)
        {
            AntCooking = true;
            PlayerLeftHandFull = false;
            HoldingMeatGO.SetActive(false);
        }

        if (FridgeScript.HoldingClam)
        {
            ClamCooking = true;
            PlayerLeftHandFull = false;
            HoldingMeatGO.SetActive(false);
        }

        if (FridgeScript.HoldingCrayfish)
        {
            CrayfishCooking = true;
            PlayerLeftHandFull = false;
            HoldingMeatGO.SetActive(false);
        }

        if (FridgeScript.HoldingMelon)
        {
            MelonCooking = true;
            PlayerLeftHandFull = false;
            HoldingMeatGO.SetActive(false);
        }

        if (FridgeScript.HoldingMoss)
        {
            MossCooking = true;
            PlayerLeftHandFull = false;
            HoldingMeatGO.SetActive(false);
        }

        if (FridgeScript.HoldingStick)
        {
            StickCooking = true;
            PlayerLeftHandFull = false;
            HoldingMeatGO.SetActive(false);
        }

        if (FridgeScript.HoldingWorms)
        {
            WormCooking = true;
            PlayerRightHandFull = false;
            HoldingMeatGO.SetActive(false);
        }

        if (FridgeScript.HoldingPasta && HoldingAntGO)
        {
            SpaghettiCooking = true;
            AntCooking = true;
            PlayerLeftHandFull = false;
            PlayerRightHandFull = false;
            HoldingPastaGO.SetActive(false);
            HoldingAntGO.SetActive(false);
        }

        if (FridgeScript.HoldingMushroom)
        {
            PlayerRightHandFull = false;
            MushroomsCooking = true;
            HoldingMushroomGO.SetActive(false);
        }
    }

    public void OvenPopupCross()
    {
        OvenInteractPrompt.SetActive(false);
        ButtonClick.Play();

    }

    public void BlenderPopupTick()
    {
        StartCoroutine(BlenderTimer());
        BlenderInteractPrompt.SetActive(false);
        BlenderNoise.Play();
        ButtonClick.Play();

        if(FridgeScript.HoldingMeat)
        {
            HoldingMeatGO.SetActive(false);
            FridgeScript.HoldingMeat = false;
            PlayerLeftHandFull = false;
        }

        if(FridgeScript.HoldingAnt)
        {
            HoldingAntGO.SetActive(false);
            FridgeScript.HoldingAnt = false;
            PlayerLeftHandFull = false;
        }

        if(FridgeScript.HoldingMelon)
        {
            HoldingMelonGO.SetActive(false);
            FridgeScript.HoldingMelon = false;
            PlayerLeftHandFull = false;
        }

        if (FridgeScript.HoldingStrawberry || FridgeScript.HoldingApple)
        {
            HoldingStrawberryGO.SetActive(false);
            FridgeScript.HoldingStrawberry = false;
            HoldingAppleGO.SetActive(false);
            FridgeScript.HoldingApple = false;
            PlayerLeftHandFull = false;
            PlayerRightHandFull = true;
        }
    }

    public void BlenderPopupCross()
    {
        BlenderInteractPrompt.SetActive(false);
        ButtonClick.Play();

    }

    public void ChoppingBoardPopUpTick()
    {
        ChoppingBoardNoise.Play();
        StartCoroutine(ChoppingTimer());
        ChoppingBoardInteractPrompt.SetActive(false);
        ButtonClick.Play();

        if(BambooCooked && FridgeScript.HoldingBread)
        {
            HoldingBreadGO.SetActive(false);
            FridgeScript.HoldingBread = false;
            BambooCooked = false;
            CookedBamboo.SetActive(false);
            BambooHotdogChopping = true;
        }

        if(FridgeScript.HoldingHay)
        {
            HoldingHayGO.SetActive(false);
            FridgeScript.HoldingHay = false;
            HaySaladChopping = true;
        }

        if(WormCooked && FridgeScript.HoldingTomato)
        {
            WormCooked = false;
            CookedWorms.SetActive(false);
            FridgeScript.HoldingTomato = false;
            HoldingTomatoGO.SetActive(false);
            WormSpaghettiChopping = true;
        }

        if(FridgeScript.HoldingLeaf)
        {
            FridgeScript.HoldingLeaf = false;
            HoldingLeafGO.SetActive(false);
            LeafSaladChopping = true;
        }

        if(BonesCooked)
        {
            BonesCooked = false;
            CookedBoneBroth.SetActive(false);
            BoneBrothChopping = true;
        }

        if(MossCooked && FridgeScript.HoldingBread)
        {
            MossCooked = false;
            FridgeScript.HoldingBread = false;
            CookedMoss.SetActive(false);
            HoldingBreadGO.SetActive(false);

            MossBurgerChopping = true;
        }

        if(FridgeScript.HoldingStrawberry && FridgeScript.HoldingApple)
        {
            FridgeScript.HoldingStrawberry = false;
            FridgeScript.HoldingApple = false;

            HoldingAppleGO.SetActive(false);
            HoldingStrawberryGO.SetActive(false);

            FruitSaladChopping = true;
        }

        if(FridgeScript.HoldingBread && StickCooked)
        {
            StickCooked = false;
            FridgeScript.HoldingBread = false;

            HoldingBreadGO.SetActive(false);
            CookedStick.SetActive(false);

            StickHotdogChopping = true;
        }

        if (FridgeScript.HoldingSnail)
        {
            FridgeScript.HoldingSnail = false;

            HoldingSnailGO.SetActive(false);

            EscargotChopping = true;
        }


        if (FridgeScript.HoldingSnail)
        {
            FridgeScript.HoldingSnail = false;

            HoldingSnailGO.SetActive(false);

            EscargotChopping = true;
        }

        if(FridgeScript.HoldingTomato && AntandSpaghettiCooked)
        {
            FridgeScript.HoldingTomato = false;
            HoldingTomatoGO.SetActive(false);
            AntandSpaghettiCooked = true;
            CookedAntandSpaghetti.SetActive(false);

            AntandSpaghettiChopping = true;
        }

        if(CrayfishCooked && FridgeScript.HoldingFlour)
        {
            FridgeScript.HoldingFlour = false;
            HoldingFlourGO.SetActive(false);
            CrayfishCooked = true;
            CookedCrayfish.SetActive(false);

            CrayfishTempuraChopping = true;
        }

        if (FridgeScript.HoldingMoth && FridgeScript.HoldingFlour)
        {
            FridgeScript.HoldingMoth = false;
            FridgeScript.HoldingFlour = false;
            HoldingMothGO.SetActive(false);
            HoldingFlourGO.SetActive(false);
            MothBiscuitChopping = true;
        }

        if(ClamCooked && FridgeScript.HoldingSpice)
        {
            FridgeScript.HoldingSpice = false;
            ClamCooked = false;
            CookedClam.SetActive(false);
            HoldingSpiceGO.SetActive(false);

            ClamMisoSoupChopping = true;
        }
    }

    public void ChoppingBoardPopUpCross()
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

    public void SinkWashUpCross()
    {
        SinkInteractPrompt.SetActive(false);
        ButtonClick.Play();

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
