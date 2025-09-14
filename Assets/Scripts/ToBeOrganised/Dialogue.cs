using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;

//This script controls all the dialogue that appears in Critter Cafe

public class Dialogue : MonoBehaviour
{
    public bool AbletoTalk; //whether the player is able to talk to the customers

    public GameObject DialogueBox; //dialogue box

    public bool TimerRunning;  //timer running bool

    public bool DialogueOpen; //if the dialogue is open

    public TextMeshProUGUI DialogueTextTMP; //the dialogue text object
    public TextMeshProUGUI NameTextTMP; //the name in the dialogue text
    public Tutorial TutorialScript; //the tutorial script

    public GameObject[] ThinkBubble;//the customer's think bubbles
    [Header("Thought GameObjects")]
    public GameObject[] ThoughtIcons; //the customer's thought icons 


    //The different meal bools 

    //Tutorial
    public bool PandaDrink1;
    public bool PandaMeal1;

    //Day 1 
    public bool AdderMeal;
    public bool LeopardDrink;
    public bool LeopardMeal;

    //Day 2
    public bool PonyDrink;
    public bool PonyMeal;
    public bool HedgehogDrink;
    public bool HedgehogMeal;
    public bool GiraffeMeal;

    //Day 3
    public bool FerretMeal;
    public bool KangarooDrink;
    public bool KangarooMeal;
    public bool ChimpDrink;
    public bool ChimpMeal;
    public bool BeaverMeal;

    //Day 4
    public bool GemsbokDrink;
    public bool GemsbokMeal;
    public bool IbexMeal;
    public bool DuckMeal;
    public bool PangolinDrink;
    public bool PangolinMeal;
    public bool ChipmunkMeal;

    //Day 5
    public bool PlatypusMeal;
    public bool BatDrink;
    public bool BatMeal;
    public bool RaccoonMeal;
    public bool AlpacaDrink;
    public bool AlpacaMeal;
    public bool FoxMeal;
    public bool PandaDrink2;
    public bool PandaMeal2;


    //Player
    public PlayerScript Player; //To access the players script
    public Interact InteractScript; //to access the interact script


    //gameobjects that are disabled to give the player access to the ingredients in the fridge
    //Tutorial
    public GameObject BambooUIUnused;
    public GameObject BreadUIUnused;
    public GameObject MeatUIUnused;

    //None for Day 1

    //Day 2
    public GameObject StrawberryUIUnused;
    public GameObject AppleUIUnused;
    public GameObject WormsUIUnused;
    public GameObject TomatoUIUnused;
    public GameObject AntUIUnused;
    public GameObject HayUIUnused;
    public GameObject LeafUIUnused;

    //Day 3
    public GameObject BoneUIUnused;
    public GameObject MossUIUnused;
    public GameObject StickUIUnused;
    public GameObject MelonUIUnused;

    //Day 4
    public GameObject SpiceUIUnused;
    public GameObject SnailUIUnused;
    public GameObject MushroomUIUnused;
    public GameObject PastaUIUnused;

    //Day 5
    public GameObject CrayfishUIUnused;
    public GameObject FlourUIUnused;
    public GameObject MothUIUnused;
    public GameObject ClamUIUnused;

    //gameobjects that are enabled to give the player access to the ingredients in the fridge

    //Tutorial
    public GameObject BambooUI;
    public GameObject BreadUI;
    public GameObject MeatUI;

    //None for Day 1

    //Day 2
    public GameObject StrawberryUI;
    public GameObject AppleUI;
    public GameObject WormsUI;
    public GameObject TomatoUI;
    public GameObject AntUI;
    public GameObject HayUI;
    public GameObject LeafUI;

    //Day 3
    public GameObject BoneUI;
    public GameObject MossUI;
    public GameObject StickUI;
    public GameObject MelonUI;

    //Day 4
    public GameObject SpiceUI;
    public GameObject SnailUI;
    public GameObject MushroomUI;
    public GameObject PastaUI;

    //Day 5 
    public GameObject CrayfishUI;
    public GameObject FlourUI;
    public GameObject MothUI;
    public GameObject ClamUI;

    public GameObject TickButtonGO; //tick button on the dialogue box
    public GameObject CrossButtonGO; //cross button on the dialogue box

    [Header("Audio")] //all the audio used
    public AudioSource AntSmoothieAudio;
    public AudioSource AntPastaAudio;
    public AudioSource WormSpaghettiAudio;
    public AudioSource BoneBrothAudio;
    public AudioSource HaySaladAudio;
    public AudioSource VenisonSteakAudio;
    public AudioSource MeatSmoothieAudio;
    public AudioSource MouseBurgerAudio;
    public AudioSource BambooHotdogAudio;
    public AudioSource StrawberryandAppleSmoothieAudio;
    public AudioSource MossBurgerAudio;
    public AudioSource MelonSmoothieAudio;
    public AudioSource FruitSaladAudio;
    public AudioSource StickHotdogAudio;
    public AudioSource RoastedMushroomAudio;
    public AudioSource LeafSaladAudio;
    public AudioSource EscargotAudio;
    public AudioSource PoachedMelonAudio;
    public AudioSource CrayfishTempuraAudio;
    public AudioSource ClamMisoSoupAudio;
    public AudioSource MothBiscuitAudio;
    public AudioSource PandaYes;
    public AudioSource PandaNo;

    public bool AdderDone;

    public bool PonyDone;
    public bool HedgehogDone;

    public bool FerretDone;
    public bool KangarooDone;
    public bool ChimpDone;

    public bool GemsbokDone;
    public bool IbexDone;
    public bool DuckDone;
    public bool PangolinDone;

    public bool PlatypusDone;
    public bool BatDone;
    public bool RaccoonDone;
    public bool AlpacaDone;
    public bool FoxDone;

    public bool LeopardDone;
    public bool GiraffeDone;
    public bool BeaverDone;
    public bool ChipmunkDone;
    public bool PandaDone;

    public bool FailedConvo;

    public Image DialogueImage;

    public Sprite PandaSprite;
    public Sprite LeopardSprite;

    public GameObject DialogueImageGO;
    public GameObject AdderSpriteGO;

    public Sprite PlayerSprite1;
    public Sprite PlayerSprite2;
    public Sprite PlayerSprite3;
    public Sprite PlayerSprite4;
    public Sprite PlayerSprite5;
    public Sprite PlayerSprite6;
    public Sprite PlayerSprite7;
    public Sprite PlayerSprite8;

    public GameObject PlayerSetup; //the player setup gameobject
    public PlayerSetup PlayerSetupScript; //the player setup script

    /*Tutorial
    Panda Orders Meat Smoothie and Bamboo Hotdog T1

    Day 1
    Adder Orders Mouse Burger T1
    Leopard Orders Meat Smoothie and Venison Steak T2

    Day 2
    Pony Orders Strawberry and Apple Smoothie and Hay Salad T1
    Hedgehog Orders Ant Smoothie and Worm Spaghetti T2
    Giraffe Orders Leaf Salad T1

    Day 3
    Ferret Orders Bone Broth T1
    Kangaroo Orders Melon Smoothie and Moss Burger T2
    Chimp Orders Strawberry and Apple Smoothie and Fruit Salad T3
    Beaver Orders Stick Hotdog T1

    Day 4
    Gemsbok Orders Melon Smoothie and Poached Melon T1
    Ibex Orders Leaf Salad T2
    Duck Orders Escargot T3
    Pangolin Orders Ant Smoothie and Ant Pasta T1
    Chipmunk Orders Roasted Mushroom T2

    Day 5
    Platypus Orders Crayfish Tempura T1
    Bat Orders Ant Smoothie and Moth Biscuit T2
    Raccoon Orders Clam Miso Soup T3
    Alpaca Orders Strawberry and Apple Smoothie and Hay Salad T4
    Fox Orders Mouse Burger T1
    Panda Orders Meat Smoothie and Bamboo Hotdog T2
    */
    public void Start()
    {
        PlayerSetup = GameObject.FindWithTag("Setup"); //find the player setup script
        PlayerSetupScript = PlayerSetup.GetComponent<PlayerSetup>();
    }
    public void Update()
    {
        if (AbletoTalk) //if the player is able to talk
        {
            if (Input.GetKey(KeyCode.E) && !TimerRunning) //if the player presses E, and timer isnt running
            {
                if (InteractScript.PandaInRange || InteractScript.AdderInRange || InteractScript.LeopardInRange || InteractScript.PonyInRange || InteractScript.PonyInRange || InteractScript.HedgehogInRange || InteractScript.GiraffeInRange || InteractScript.FerretInRange || InteractScript.KangarooInRange || InteractScript.ChimpInRange || InteractScript.BeaverInRange || InteractScript.GemsbokInRange || InteractScript.IbexInRange || InteractScript.DuckInRange || InteractScript.PangolinInRange || InteractScript.ChipmunkInRange || InteractScript.PlatypusInRange || InteractScript.BatInRange || InteractScript.RaccoonInRange || InteractScript.AlpacaInRange || InteractScript.FoxInRange)
                {
                    DialogueButton(); //call the dialogue button function
                    StartCoroutine(DelayTime());
                }
            }

            if (Input.GetKey(KeyCode.Y) && !TimerRunning) //if the player presses Y, and timer isnt running
            {
                TickButton(); //call the tick button function
                StartCoroutine(DelayTime());
            }

            if (Input.GetKey(KeyCode.N) && !TimerRunning) //if the player presses N, and timer isnt running
            {
                CrossButton(); //call the cross button function
                StartCoroutine(DelayTime());
            }
        }

        if (Input.GetKey(KeyCode.E) && DialogueOpen && !TimerRunning) //if the player has the dialogue box open
        {
            DialogueBox.SetActive(false); //close the dialogue box
            DialogueOpen = false;
            if (TutorialScript.TutorialImages == 9)
            {
                TutorialScript.NextTutorial();
            }
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        //if the player leaves the trigger box of the customers, close the dialogue box
        if (other.tag == "PandaCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "AdderCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "LeopardCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "PonyCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "HedgehogCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "GiraffeCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "FerretCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "KangarooCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "ChimpCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "BeaverCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "GemsbokCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "IbexCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "DuckCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "PangolinCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "ChipmunkCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "PlatypusCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "BatCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "RaccoonCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "AlpacaCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }

        if (other.tag == "FoxCustomer")
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }
    }
    
    public void DialogueButton()
    {
        if (DialogueOpen)//if the dialogue is open
        {
            DialogueBox.SetActive(false); //close the dialogue
            DialogueOpen = false;
            if (TutorialScript.TutorialImages == 9)
            {
                TutorialScript.NextTutorial();
            }
        }
        if (AbletoTalk)
        {
            if (InteractScript.PandaInRange || InteractScript.AdderInRange || InteractScript.LeopardInRange || InteractScript.PonyInRange || InteractScript.PonyInRange || InteractScript.HedgehogInRange || InteractScript.GiraffeInRange || InteractScript.FerretInRange || InteractScript.KangarooInRange || InteractScript.ChimpInRange || InteractScript.BeaverInRange || InteractScript.GemsbokInRange || InteractScript.IbexInRange || InteractScript.DuckInRange || InteractScript.PangolinInRange || InteractScript.ChipmunkInRange || InteractScript.PlatypusInRange || InteractScript.BatInRange || InteractScript.RaccoonInRange || InteractScript.AlpacaInRange || InteractScript.FoxInRange)
            {

                if (!DialogueOpen) //if the dialogue box isnt open
                {
                    DialogueBox.SetActive(true); //open the dialogue box
                    DialogueOpen = true;

                    if (PlayerSetupScript.Choice1Selected)
                    {
                        DialogueImage.sprite = PlayerSprite1;
                    }

                    if (PlayerSetupScript.Choice2Selected)
                    {
                        DialogueImage.sprite = PlayerSprite2;
                    }

                    if (PlayerSetupScript.Choice3Selected)
                    {
                        DialogueImage.sprite = PlayerSprite3;
                    }

                    if (PlayerSetupScript.Choice4Selected)
                    {
                        DialogueImage.sprite = PlayerSprite4;
                    }

                    if (PlayerSetupScript.Choice5Selected)
                    {
                        DialogueImage.sprite = PlayerSprite5;
                    }

                    if (PlayerSetupScript.Choice6Selected)
                    {
                        DialogueImage.sprite = PlayerSprite6;
                    }

                    if (PlayerSetupScript.Choice7Selected)
                    {
                        DialogueImage.sprite = PlayerSprite7;
                    }

                    if (PlayerSetupScript.Choice8Selected)
                    {
                        DialogueImage.sprite = PlayerSprite8;
                    }
                    DialogueImageGO.SetActive(true);

                    NameTextTMP.text = PlayerSetupScript.PlayerName;
                    DialogueTextTMP.text = "I can't speak to this customer at the moment.";
                    FailedConvo = true;

                    //if a customer is in range, check what meal is active, and then
                    //show the relevant dialogue and play the relevant audio
                    //repeat for each customer 
                    if (InteractScript.PandaInRange)
                    {
                        if (PandaDrink1)
                        {
                            FailedConvo = false;

                            if (TutorialScript.TutorialImages == 7)
                            {
                                TutorialScript.NextTutorial();
                            }
                            MeatSmoothieAudio.Play();

                            DialogueImage.sprite = PandaSprite;

                            NameTextTMP.text = "Panda";
                            DialogueTextTMP.text = "Can I get a Meat Smoothie?";
                        }

                        if (PandaMeal1)
                        {
                            FailedConvo = false;
                            DialogueImage.sprite = PandaSprite;

                            BambooHotdogAudio.Play();
                            NameTextTMP.text = "Panda";
                            DialogueTextTMP.text = "Can I get a Bamboo Hotdog?";
                        }
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (InteractScript.AdderInRange)
                    {
                        if (AdderMeal)
                        {
                            DialogueImageGO.SetActive(false);
                            AdderSpriteGO.SetActive(true);
                            FailedConvo = false;

                            Debug.Log("Adder Meal Time");
                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            MouseBurgerAudio.Play();
                            NameTextTMP.text = "Adder";
                            DialogueTextTMP.text = "Can I get a Mouse Burger?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.LeopardInRange && AdderDone)
                    {
                        if (LeopardDrink)
                        {
                            AdderSpriteGO.SetActive(false);
                            FailedConvo = false;
                            DialogueImage.sprite = LeopardSprite;
                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            MeatSmoothieAudio.Play();
                            NameTextTMP.text = "Leopard";
                            DialogueTextTMP.text = "Can I get a Meat Smoothie?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                        if (LeopardMeal)
                        {
                            DialogueImage.sprite = LeopardSprite;

                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            VenisonSteakAudio.Play();
                            NameTextTMP.text = "Leopard";
                            DialogueTextTMP.text = "Can I get a Venison Steak?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.PonyInRange)
                    {
                        if (PonyDrink)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            StrawberryandAppleSmoothieAudio.Play();
                            NameTextTMP.text = "Shetland Pony";
                            DialogueTextTMP.text = "Can I get a Strawberry and Apple Smoothie?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                        if (PonyMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            HaySaladAudio.Play();
                            NameTextTMP.text = "Shetland Pony";
                            DialogueTextTMP.text = "Can I get a Hay Salad?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.HedgehogInRange && PonyDone)
                    {
                        if (HedgehogDrink)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            AntSmoothieAudio.Play();
                            NameTextTMP.text = "Hedgehog";
                            DialogueTextTMP.text = "Can I get an Ant Smoothie?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                        if (HedgehogMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            WormSpaghettiAudio.Play();
                            NameTextTMP.text = "Hedgehog";
                            DialogueTextTMP.text = "Can I get Worm Spaghetti?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.GiraffeInRange && HedgehogDone)
                    {
                        if (GiraffeMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            LeafSaladAudio.Play();
                            NameTextTMP.text = "Giraffe";
                            DialogueTextTMP.text = "Can I get a Leaf Salad?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.FerretInRange)
                    {
                        if (FerretMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            BoneBrothAudio.Play();
                            NameTextTMP.text = "Ferret";
                            DialogueTextTMP.text = "Can I get Bone Broth?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                    }

                    if (InteractScript.KangarooInRange && FerretDone)
                    {
                        if (KangarooDrink)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            MelonSmoothieAudio.Play();
                            NameTextTMP.text = "Kangaroo";
                            DialogueTextTMP.text = "Can I get a Melon Smoothie?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                        if (KangarooMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            MossBurgerAudio.Play();
                            NameTextTMP.text = "Kangaroo";
                            DialogueTextTMP.text = "Can I get a Moss Burger?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.ChimpInRange && KangarooDone)
                    {
                        if (ChimpDrink)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            StrawberryandAppleSmoothieAudio.Play();
                            NameTextTMP.text = "Chimpanzee";
                            DialogueTextTMP.text = "Can I get a Strawberry and Apple Smoothie?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                        if (ChimpMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            FruitSaladAudio.Play();
                            NameTextTMP.text = "Chimpanzee";
                            DialogueTextTMP.text = "Can I get a Fruit Salad?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.BeaverInRange && ChimpDone)
                    {
                        if (BeaverMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            StickHotdogAudio.Play();
                            NameTextTMP.text = "Beaver";
                            DialogueTextTMP.text = "Can I get a Stick Hotdog?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.GemsbokInRange)
                    {
                        if (GemsbokDrink)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            MelonSmoothieAudio.Play();
                            NameTextTMP.text = "Gemsbok";
                            DialogueTextTMP.text = "Can I get a Melon Smoothie?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                        if (GemsbokMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            PoachedMelonAudio.Play();
                            NameTextTMP.text = "Gemsbok";
                            DialogueTextTMP.text = "Can I get a Poached Melon?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.IbexInRange && GemsbokDone)
                    {
                        if (IbexMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            LeafSaladAudio.Play();
                            NameTextTMP.text = "Ibex";
                            DialogueTextTMP.text = "Can I get a Leaf Salad?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.DuckInRange && IbexDone)
                    {
                        if (DuckMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            EscargotAudio.Play();
                            NameTextTMP.text = "Mandarin Duck";
                            DialogueTextTMP.text = "Can I get Escargot?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.PangolinInRange && DuckDone)
                    {
                        if (PangolinDrink)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            AntSmoothieAudio.Play();
                            NameTextTMP.text = "Pangolin";
                            DialogueTextTMP.text = "Can I get an Ant Smoothie?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                        if (PangolinMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            AntPastaAudio.Play();
                            NameTextTMP.text = "Pangolin";
                            DialogueTextTMP.text = "Can I get Ant Pasta?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.ChipmunkInRange && PangolinDone)
                    {
                        if (ChipmunkMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            RoastedMushroomAudio.Play();
                            NameTextTMP.text = "Chipmunk";
                            DialogueTextTMP.text = "Can I get Roasted Mushrooms?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.PlatypusInRange)
                    {
                        if (PlatypusMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            CrayfishTempuraAudio.Play();
                            NameTextTMP.text = "Platypus";
                            DialogueTextTMP.text = "Can I get Crayfish Tempura?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.BatInRange && PlatypusDone)
                    {
                        if (BatDrink)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            AntSmoothieAudio.Play();
                            NameTextTMP.text = "Lesser Horseshoe Bat";
                            DialogueTextTMP.text = "Can I get an Ant Smoothie";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                        if (BatMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            MothBiscuitAudio.Play();
                            NameTextTMP.text = "Lesser Horseshoe Bat";
                            DialogueTextTMP.text = "Can I get a Moth Biscuit?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.RaccoonInRange && BatDone)
                    {
                        if (RaccoonMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            ClamMisoSoupAudio.Play();
                            NameTextTMP.text = "Raccoon";
                            DialogueTextTMP.text = "Can I get Clam Miso Soup?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.AlpacaInRange && RaccoonDone)
                    {
                        if (AlpacaDrink)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            StrawberryandAppleSmoothieAudio.Play();
                            NameTextTMP.text = "Alpaca";
                            DialogueTextTMP.text = "Can I get a Strawberry and Apple Smoothie?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                        if (AlpacaMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            HaySaladAudio.Play();
                            NameTextTMP.text = "Alpaca";
                            DialogueTextTMP.text = "Can I get a Hay Salad?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.FoxInRange && AlpacaDone)
                    {
                        if (FoxMeal)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            MouseBurgerAudio.Play();
                            NameTextTMP.text = "Fox";
                            DialogueTextTMP.text = "Can I get a Mouse Burger?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if (InteractScript.PandaInRange && FoxDone)
                    {
                        if (PandaDrink2)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            MeatSmoothieAudio.Play();
                            NameTextTMP.text = "Panda";
                            DialogueTextTMP.text = "Can I get a Meat Smoothie?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }

                        if (PandaMeal2)
                        {
                            FailedConvo = false;

                            DialogueBox.SetActive(true);
                            DialogueOpen = true;

                            BambooHotdogAudio.Play();
                            NameTextTMP.text = "Panda";
                            DialogueTextTMP.text = "Can I get a Bamboo Hotdog?";
                            TickButtonGO.SetActive(true);
                            CrossButtonGO.SetActive(true);
                        }
                    }

                    if(FailedConvo)
                    {
                        TickButtonGO.SetActive(false);
                        CrossButtonGO.SetActive(false);
                    }
                    else
                    {
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }
            }
        }
    }
    //controls the tick button, if the player says yes
    public void TickButton()
    {
        if (DialogueOpen)
        {
            AbletoTalk = false;
            //pause all audio
            MeatSmoothieAudio.Pause();
            BambooHotdogAudio.Pause();
            AntSmoothieAudio.Pause();
            AntPastaAudio.Pause();
            WormSpaghettiAudio.Pause();
            BoneBrothAudio.Pause();
            HaySaladAudio.Pause();
            VenisonSteakAudio.Pause();
            MouseBurgerAudio.Pause();
            StrawberryandAppleSmoothieAudio.Pause();
            MossBurgerAudio.Pause();
            MelonSmoothieAudio.Pause();
            FruitSaladAudio.Pause();
            StickHotdogAudio.Pause();
            RoastedMushroomAudio.Pause();
            LeafSaladAudio.Pause();
            EscargotAudio.Pause();
            PoachedMelonAudio.Pause();
            CrayfishTempuraAudio.Pause();
            ClamMisoSoupAudio.Pause();
            MothBiscuitAudio.Pause();

            PandaYes.Play(); //play yes audio

            if (TutorialScript.TutorialImages == 8)
            {
                TutorialScript.NextTutorial();
            }

            DialogueTextTMP.text = "Yay!!!";
            //disable cross and tick buttons
            CrossButtonGO.SetActive(false);
            TickButtonGO.SetActive(false);

            
            //check what meal is active
            //change the players current order
            //enable and disable the UIUnused and UI so the player can access the ingredients
            //player unlocks new ingredients when they accept a meal with food they dont have yet
            //disable the customers think and relevant thought icon

            if (PandaDrink1)
            {
                Player.CurrentOrder = 0;
                MeatUIUnused.SetActive(false);
                MeatUI.SetActive(true);
                CrossButtonGO.SetActive(false);
                TickButtonGO.SetActive(false);
                ThoughtIcons[1].SetActive(false);
                ThinkBubble[1].SetActive(false);
                AbletoTalk = false;
            }

            if (PandaMeal1)
            {
                Player.CurrentOrder = 1;
                BambooUIUnused.SetActive(false);
                BreadUIUnused.SetActive(false);

                BambooUI.SetActive(true);
                BreadUI.SetActive(true);
                CrossButtonGO.SetActive(false);
                TickButtonGO.SetActive(false);
                ThoughtIcons[2].SetActive(false);
                ThinkBubble[1].SetActive(false);
                AbletoTalk = false;
                if (TutorialScript.TutorialImages == 21)
                {
                    TutorialScript.NextTutorial();
                }
            }

            if (AdderMeal)
            {
                Player.CurrentOrder = 2;
                ThoughtIcons[3].SetActive(false);
                ThinkBubble[2].SetActive(false);
                AbletoTalk = false;
                AdderSpriteGO.SetActive(false);

            }

            if (LeopardDrink && AdderDone)
            {
                Player.CurrentOrder = 3;
                ThoughtIcons[4].SetActive(false);
                ThinkBubble[3].SetActive(false);
                AbletoTalk = false;

            }
            if (LeopardMeal)
            {
                Player.CurrentOrder = 4;
                ThoughtIcons[5].SetActive(false);
                ThinkBubble[3].SetActive(false);
                AbletoTalk = false;

            }
            if (PonyDrink)
            {
                Player.CurrentOrder = 5;
                ThoughtIcons[6].SetActive(false);
                ThinkBubble[4].SetActive(false);
                StrawberryUIUnused.SetActive(false);
                AppleUIUnused.SetActive(false);
                StrawberryUI.SetActive(true);
                AppleUI.SetActive(true);
                AbletoTalk = false;

            }

            if (PonyMeal)
            {
                Player.CurrentOrder = 6;
                ThinkBubble[4].SetActive(false);
                ThoughtIcons[7].SetActive(false);
                HayUIUnused.SetActive(false);
                HayUI.SetActive(true);
                AbletoTalk = false;

            }
            if (HedgehogDrink && PonyDone)
            {
                Player.CurrentOrder = 7;
                ThinkBubble[5].SetActive(false);
                ThoughtIcons[8].SetActive(false);
                AntUIUnused.SetActive(false);
                AntUI.SetActive(true);
                AbletoTalk = false;

            }
            if (HedgehogMeal)
            {
                Player.CurrentOrder = 8;
                ThinkBubble[5].SetActive(false);
                ThoughtIcons[9].SetActive(false);
                WormsUIUnused.SetActive(false);
                WormsUI.SetActive(true);
                TomatoUIUnused.SetActive(false);
                TomatoUI.SetActive(true);
                AbletoTalk = false;

            }

            if (GiraffeMeal && HedgehogDone)
            {
                Player.CurrentOrder = 9;
                ThinkBubble[6].SetActive(false);
                ThoughtIcons[10].SetActive(false);
                LeafUIUnused.SetActive(false);
                LeafUI.SetActive(true);
                AbletoTalk = false;

            }
            if (FerretMeal)
            {
                Player.CurrentOrder = 10;
                ThinkBubble[7].SetActive(false);
                ThoughtIcons[11].SetActive(false);
                BoneUIUnused.SetActive(false);
                BoneUI.SetActive(true);
                AbletoTalk = false;
            }

            if (KangarooDrink && FerretDone)
            {
                Player.CurrentOrder = 11;
                ThinkBubble[8].SetActive(false);
                ThoughtIcons[12].SetActive(false);
                MelonUIUnused.SetActive(false);
                MelonUI.SetActive(true);
                AbletoTalk = false;

            }
            if (KangarooMeal)
            {
                ThinkBubble[8].SetActive(false);
                Player.CurrentOrder = 12;
                ThoughtIcons[13].SetActive(false);
                MossUIUnused.SetActive(false);
                MossUI.SetActive(true);
                AbletoTalk = false;
            }
            if (ChimpDrink && KangarooDone)
            {
                Player.CurrentOrder = 13;
                ThinkBubble[9].SetActive(false);
                ThoughtIcons[14].SetActive(false);
                AbletoTalk = false;
            }

            if (ChimpMeal)
            {
                ThinkBubble[9].SetActive(false);
                Player.CurrentOrder = 14;
                ThoughtIcons[15].SetActive(false);
                AbletoTalk = false;
            }

            if (BeaverMeal && ChimpDone)
            {
                ThinkBubble[10].SetActive(false);
                Player.CurrentOrder = 15;
                ThoughtIcons[16].SetActive(false);
                StickUIUnused.SetActive(false);
                StickUI.SetActive(true);
                AbletoTalk = false;
            }
            if (GemsbokDrink)
            {
                ThinkBubble[11].SetActive(false);
                Player.CurrentOrder = 16;
                ThoughtIcons[17].SetActive(false);
                AbletoTalk = false;
            }

            if (GemsbokMeal)
            {
                ThinkBubble[11].SetActive(false);
                Player.CurrentOrder = 17;
                ThoughtIcons[18].SetActive(false);
                SpiceUIUnused.SetActive(false);
                SpiceUI.SetActive(true);

                AbletoTalk = false;
            }
            if (IbexMeal && GemsbokDone)
            {
                ThinkBubble[12].SetActive(false);
                Player.CurrentOrder = 18;
                ThoughtIcons[16].SetActive(false);
                AbletoTalk = false;
            }
            if (DuckMeal && IbexDone)
            {
                ThinkBubble[13].SetActive(false);
                Player.CurrentOrder = 19;
                ThoughtIcons[20].SetActive(false);
                SnailUIUnused.SetActive(false);
                SnailUI.SetActive(true);
                AbletoTalk = false;
            }

            if (PangolinDrink && DuckDone)
            {
                Player.CurrentOrder = 20;
                ThinkBubble[14].SetActive(false);
                ThoughtIcons[21].SetActive(false);
                AbletoTalk = false;
            }

            if (PangolinMeal)
            {
                ThinkBubble[14].SetActive(false);
                Player.CurrentOrder = 21;
                ThoughtIcons[22].SetActive(false);
                PastaUIUnused.SetActive(false);
                PastaUI.SetActive(true);
                AbletoTalk = false;
            }

            if (ChipmunkMeal && PangolinDone)
            {
                ThinkBubble[15].SetActive(false);
                Player.CurrentOrder = 22;
                ThoughtIcons[23].SetActive(false);
                MushroomUIUnused.SetActive(false);
                MushroomUI.SetActive(true);
                AbletoTalk = false;
            }

            if (PlatypusMeal)
            {
                ThinkBubble[16].SetActive(false);
                Player.CurrentOrder = 23;
                ThoughtIcons[24].SetActive(false);
                FlourUIUnused.SetActive(false);
                FlourUI.SetActive(true);
                CrayfishUIUnused.SetActive(false);
                CrayfishUI.SetActive(true);
                AbletoTalk = false;
            }

            if (BatDrink && PlatypusDone)
            {
                ThinkBubble[17].SetActive(false);
                Player.CurrentOrder = 24;
                ThoughtIcons[25].SetActive(false);

                AbletoTalk = false;
            }
            if (BatMeal)
            {
                ThinkBubble[17].SetActive(false);
                Player.CurrentOrder = 25;
                ThoughtIcons[26].SetActive(false);
                MothUIUnused.SetActive(false);
                MothUI.SetActive(true);
                AbletoTalk = false;
            }
            if (RaccoonMeal && BatDone)
            {
                ThinkBubble[18].SetActive(false);
                Player.CurrentOrder = 26;
                ThoughtIcons[27].SetActive(false);
                ClamUIUnused.SetActive(false);
                ClamUI.SetActive(true);
                AbletoTalk = false;
            }

            if (AlpacaDrink && BatDone)
            {
                ThinkBubble[19].SetActive(false);
                Player.CurrentOrder = 27;
                ThoughtIcons[28].SetActive(false);
                AbletoTalk = false;
            }

            if (AlpacaMeal)
            {
                ThinkBubble[19].SetActive(false);
                Player.CurrentOrder = 28;
                ThoughtIcons[29].SetActive(false);
                AbletoTalk = false;
            }

            if (FoxMeal && AlpacaDone)
            {
                ThinkBubble[20].SetActive(false);
                Player.CurrentOrder = 29;
                ThoughtIcons[30].SetActive(false);
                AbletoTalk = false;
            }

            if (PandaDrink2 && FoxDone)
            {
                ThinkBubble[21].SetActive(false);
                Player.CurrentOrder = 30;
                ThoughtIcons[31].SetActive(false);
                AbletoTalk = false;
            }

            if (PandaMeal2)
            {
                ThinkBubble[21].SetActive(false);
                Player.CurrentOrder = 31;
                ThoughtIcons[32].SetActive(false);
                AbletoTalk = false;
            }
        }
    }
    //controls the cross button, if the player says no
    public void CrossButton()
    {
        if (DialogueOpen) //if the dialogue is open
        {
            //pause all audio
            MeatSmoothieAudio.Pause();
            BambooHotdogAudio.Pause();
            AntSmoothieAudio.Pause();
            AntPastaAudio.Pause();
            WormSpaghettiAudio.Pause();
            BoneBrothAudio.Pause();
            HaySaladAudio.Pause();
            VenisonSteakAudio.Pause();
            MouseBurgerAudio.Pause();
            StrawberryandAppleSmoothieAudio.Pause();
            MossBurgerAudio.Pause();
            MelonSmoothieAudio.Pause();
            FruitSaladAudio.Pause();
            StickHotdogAudio.Pause();
            RoastedMushroomAudio.Pause();
            LeafSaladAudio.Pause();
            EscargotAudio.Pause();
            PoachedMelonAudio.Pause();
            CrayfishTempuraAudio.Pause();
            ClamMisoSoupAudio.Pause();
            MothBiscuitAudio.Pause();

            //play No sound effect
            PandaNo.Play();

            DialogueTextTMP.text = "Oh... :(";
        }
    }

    IEnumerator DelayTime() //this coroutine is to prevent glitches when the player opens the dialogue
    {
        TimerRunning = true; //timer running is true
        yield return new WaitForSeconds(0.25f); //wait 0.25 seconds
        TimerRunning = false; //timer running is false
    }
}
