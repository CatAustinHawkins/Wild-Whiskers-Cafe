using UnityEngine;
using TMPro;
using System.Collections;
//new dialogue script that works the dialogue button

public class Dialogue : MonoBehaviour
{
    public bool AbletoTalk;

    public GameObject DialogueBox; //dialogue box

    public bool TimerRunning;

    public bool DialogueOpen;

    public TextMeshProUGUI DialogueTextTMP;
    public TextMeshProUGUI NameTextTMP;
    public Tutorial TutorialScript;

    public GameObject[] ThinkBubble;
    [Header("Thought GameObjects")]
    public GameObject[] ThoughtIcons;

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
    //tutorial panda drink and meal

    //Player
    public PlayerScript Player; //To access the players script
    public Interact InteractScript;

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

    public GameObject TickButtonGO;
    public GameObject CrossButtonGO;

    [Header("Audio")]
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

    /*Tutorial
    Panda Orders Meat Smoothie and Bamboo Hotdog

    Day 1
    Adder Orders Mouse Burger
    Leopard Orders Meat Smoothie and Venison Steak

    Day 2
    Pony Orders Strawberry and Apple Smoothie and Hay Salad
    Hedgehog Orders Ant Smoothie and Worm Spaghetti
    Giraffe Orders Hay Salad

    Day 3
    Ferret Orders Bone Broth
    Kangaroo Orders Melon Smoothie and Moss Burger
    Chimp Orders Strawberry and Apple Smoothie and Fruit Salad
    Beaver Orders Stick Hotdog

    Day 4
    Gemsbok Orders Melon Smoothie and Poached Melon
    Ibex Orders Leaf Salad
    Duck Orders Escargot
    Pangolin Orders Ant Smoothie and Ant Pasta
    Chipmunk Orders Roasted Mushroom

    Day 5
    Platypus Orders Crayfish Tempura 
    Bat Orders Ant Smoothie and Moth Biscuit
    Raccoon Orders Clam Miso Soup
    Alpaca Orders Strawberry and Apple Smoothie and Hay Salad
    Fox Orders Mouse Burger
    Panda Orders Meat Smoothie and Bamboo Hotdog
    */

    public void Update()
    {


        if (AbletoTalk)
        {
            if (Input.GetKey(KeyCode.E) && !TimerRunning)
            {
                DialogueButton();
                Debug.Log("Test1");
                StartCoroutine(DelayTime());
            }

            if (Input.GetKey(KeyCode.Y) && !TimerRunning)
            {
                TickButton();
                StartCoroutine(DelayTime());
            }

            if (Input.GetKey(KeyCode.N) && !TimerRunning)
            {
                CrossButton();
                StartCoroutine(DelayTime());
            }
        }

        if (Input.GetKey(KeyCode.E) && DialogueOpen && !TimerRunning && !AbletoTalk)
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
            if (TutorialScript.TutorialImages == 9)
            {
                TutorialScript.NextTutorial();
            }
        }
    }

    /*
    //same as interact script
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PandaCustomer")
        {
            InteractScript.PandaInRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "PandaCustomer")
        {
            InteractScript.PandaInRange = false;
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }
    }
    */
    public void DialogueButton()
    {

        Player.target = Player.transform.position;

        if (DialogueOpen)
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
            if (TutorialScript.TutorialImages == 9)
            {
                TutorialScript.NextTutorial();
            }
        }
        if (AbletoTalk)
        {
            if (!DialogueOpen)
            {
                DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                DialogueOpen = true;

                //TUTORIAL
                if (InteractScript.PandaInRange)
                {
                    if (PandaDrink1)
                    {
                        if (TutorialScript.TutorialImages == 7)
                        {
                            TutorialScript.NextTutorial();
                        }
                        MeatSmoothieAudio.Play();

                        NameTextTMP.text = "Panda";
                        DialogueTextTMP.text = "Can I get a Meat Smoothie?";
                    }

                    if (PandaMeal1)
                    {
                        BambooHotdogAudio.Play();
                        NameTextTMP.text = "Panda";
                        DialogueTextTMP.text = "Can I get a Bamboo Hotdog?";
                    }
                    TickButtonGO.SetActive(true);
                    CrossButtonGO.SetActive(true);
                }

                if (InteractScript.AdderInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (AdderMeal)
                    {
                        Debug.Log("Adder Meal Time");
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MouseBurgerAudio.Play();
                        NameTextTMP.text = "Adder";
                        DialogueTextTMP.text = "Can I get a Mouse Burger?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.LeopardInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (LeopardDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MeatSmoothieAudio.Play();
                        NameTextTMP.text = "Leopard";
                        DialogueTextTMP.text = "Can I get a Meat Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (LeopardMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        VenisonSteakAudio.Play();
                        NameTextTMP.text = "Leopard";
                        DialogueTextTMP.text = "Can I get a Venison Steak?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.PonyInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (PonyDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        StrawberryandAppleSmoothieAudio.Play();
                        NameTextTMP.text = "Shetland Pony";
                        DialogueTextTMP.text = "Can I get a Strawberry and Apple Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (PonyMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        HaySaladAudio.Play();
                        NameTextTMP.text = "Shetland Pony";
                        DialogueTextTMP.text = "Can I get a Hay Salad?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.HedgehogInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (HedgehogDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        AntSmoothieAudio.Play();
                        NameTextTMP.text = "Hedgehog";
                        DialogueTextTMP.text = "Can I get an Ant Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (HedgehogMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        WormSpaghettiAudio.Play();
                        NameTextTMP.text = "Hedgehog";
                        DialogueTextTMP.text = "Can I get Worm Spaghetti?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.GiraffeInRange)
                {
                    if (GiraffeMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        LeafSaladAudio.Play();
                        NameTextTMP.text = "Giraffe";
                        DialogueTextTMP.text = "Can I get a Leaf Salad?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.FerretInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (FerretMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        BoneBrothAudio.Play();
                        NameTextTMP.text = "Ferret";
                        DialogueTextTMP.text = "Can I get Bone Broth?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                }

                if (InteractScript.KangarooInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (KangarooDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MelonSmoothieAudio.Play();
                        NameTextTMP.text = "Kangaroo";
                        DialogueTextTMP.text = "Can I get a Melon Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (KangarooMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MossBurgerAudio.Play();
                        NameTextTMP.text = "Kangaroo";
                        DialogueTextTMP.text = "Can I get a Moss Burger?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.ChimpInRange)
                {
                    if (ChimpDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        StrawberryandAppleSmoothieAudio.Play();
                        NameTextTMP.text = "Chimpanzee";
                        DialogueTextTMP.text = "Can I get a Strawberry and Apple Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (ChimpMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        FruitSaladAudio.Play();
                        NameTextTMP.text = "Chimpanzee";
                        DialogueTextTMP.text = "Can I get a Fruit Salad?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.BeaverInRange)
                {
                    if (BeaverMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        StickHotdogAudio.Play();
                        NameTextTMP.text = "Beaver";
                        DialogueTextTMP.text = "Can I get a Stick Hotdog?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }
                if (InteractScript.GemsbokInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (GemsbokDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MelonSmoothieAudio.Play();
                        NameTextTMP.text = "Gemsbok";
                        DialogueTextTMP.text = "Can I get a Melon Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (GemsbokMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        PoachedMelonAudio.Play();
                        NameTextTMP.text = "Gemsbok";
                        DialogueTextTMP.text = "Can I get a Poached Melon?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.IbexInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (IbexMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        LeafSaladAudio.Play();
                        NameTextTMP.text = "Ibex";
                        DialogueTextTMP.text = "Can I get a Leaf Salad?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.DuckInRange)
                {
                    if (DuckMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        EscargotAudio.Play();
                        NameTextTMP.text = "Mandarin Duck";
                        DialogueTextTMP.text = "Can I get Escargot?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.PangolinInRange)
                {
                    if (PangolinDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        AntSmoothieAudio.Play();
                        NameTextTMP.text = "Pangolin";
                        DialogueTextTMP.text = "Can I get an Ant Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (PangolinMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        AntPastaAudio.Play();
                        NameTextTMP.text = "Pangolin";
                        DialogueTextTMP.text = "Can I get Ant Pasta?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.ChipmunkInRange)
                {
                    if (ChipmunkMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        RoastedMushroomAudio.Play();
                        NameTextTMP.text = "Chipmunk";
                        DialogueTextTMP.text = "Can I get Roasted Mushrooms?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }
                if (InteractScript.PlatypusInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (PlatypusMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        CrayfishTempuraAudio.Play();
                        NameTextTMP.text = "Platypus";
                        DialogueTextTMP.text = "Can I get Crayfish Tempura?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.BatInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (BatDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        AntSmoothieAudio.Play();
                        NameTextTMP.text = "Lesser Horseshoe Bat";
                        DialogueTextTMP.text = "Can I get an Ant Smoothie";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (BatMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MothBiscuitAudio.Play();
                        NameTextTMP.text = "Lesser Horseshoe Bat";
                        DialogueTextTMP.text = "Can I get a Moth Biscuit?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.RaccoonInRange)
                {
                    if (RaccoonMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        ClamMisoSoupAudio.Play();
                        NameTextTMP.text = "Raccoon";
                        DialogueTextTMP.text = "Can I get Clam Miso Soup?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.AlpacaInRange)
                {
                    if (AlpacaDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        StrawberryandAppleSmoothieAudio.Play();
                        NameTextTMP.text = "Alpaca";
                        DialogueTextTMP.text = "Can I get a Strawberry and Apple Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (AlpacaMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        HaySaladAudio.Play();
                        NameTextTMP.text = "Alpaca";
                        DialogueTextTMP.text = "Can I get a Hay Salad?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.FoxInRange)
                {
                    if (FoxMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MouseBurgerAudio.Play();
                        NameTextTMP.text = "Fox";
                        DialogueTextTMP.text = "Can I get a Mouse Burger?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (InteractScript.PandaInRange)
                {
                    if (PandaDrink2)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MeatSmoothieAudio.Play();
                        NameTextTMP.text = "Panda";
                        DialogueTextTMP.text = "Can I get a Meat Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (PandaMeal2)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        BambooHotdogAudio.Play();
                        NameTextTMP.text = "Panda";
                        DialogueTextTMP.text = "Can I get a Bamboo Hotdog?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }
            }
        }
        
        if (DialogueOpen)
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;
            if (TutorialScript.TutorialImages == 9)
            {
                TutorialScript.NextTutorial();
            }
        }
    }
    //controls the tick button
    public void TickButton()
    {
        Player.target = Player.transform.position;


        if (DialogueOpen)
        {
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
            PandaYes.Play();

            if (TutorialScript.TutorialImages == 8)
            {
                TutorialScript.NextTutorial();
            }
            DialogueTextTMP.text = "Yay!!!";
            CrossButtonGO.SetActive(false);
            TickButtonGO.SetActive(false);

            if (PandaMeal1)
            {
                Player.CurrentOrder = 2;
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

            if (PandaDrink1)
            {
                Player.CurrentOrder = 1;
                MeatUIUnused.SetActive(false);
                MeatUI.SetActive(true);
                CrossButtonGO.SetActive(false);
                TickButtonGO.SetActive(false);
                ThoughtIcons[1].SetActive(false);
                ThinkBubble[1].SetActive(false);
                AbletoTalk = false;
            }

            if (AdderMeal)
            {
                Player.CurrentOrder = 3;
                ThoughtIcons[3].SetActive(false);
                ThinkBubble[2].SetActive(false);

            }

            if (LeopardDrink)
            {
                Player.CurrentOrder = 4;
                ThoughtIcons[4].SetActive(false);
                ThinkBubble[3].SetActive(false);

            }
            if (LeopardMeal)
            {
                Player.CurrentOrder = 5;
                ThoughtIcons[5].SetActive(false);
                ThinkBubble[4].SetActive(false);
            }
            if (PonyDrink)
            {
                Player.CurrentOrder = 6;
                ThoughtIcons[6].SetActive(false);
                StrawberryUIUnused.SetActive(false);
                AppleUIUnused.SetActive(false);
                StrawberryUI.SetActive(true);
                AppleUI.SetActive(true);
            }

            if (PonyMeal)
            {
                Player.CurrentOrder = 7;
                ThoughtIcons[7].SetActive(false);
                HayUIUnused.SetActive(false);
                HayUI.SetActive(true);

            }
            if (HedgehogDrink)
            {
                Player.CurrentOrder = 8;
                ThoughtIcons[8].SetActive(false);
                AntUIUnused.SetActive(false);
                AntUI.SetActive(true);
            }
            if (HedgehogMeal)
            {
                Player.CurrentOrder = 9;
                ThoughtIcons[9].SetActive(false);
                WormsUIUnused.SetActive(false);
                WormsUI.SetActive(true);
                TomatoUIUnused.SetActive(false);
                TomatoUI.SetActive(true);
            }

            if (GiraffeMeal)
            {
                Player.CurrentOrder = 10;
                ThoughtIcons[10].SetActive(false);
                LeafUIUnused.SetActive(false);
                LeafUI.SetActive(true);
            }
            if (FerretMeal)
            {
                Player.CurrentOrder = 11;
                ThoughtIcons[11].SetActive(false);
                BoneUIUnused.SetActive(false);
                BoneUI.SetActive(true);
            }

            if (KangarooDrink)
            {
                Player.CurrentOrder = 12;
                ThoughtIcons[12].SetActive(false);
                MelonUIUnused.SetActive(false);
                MelonUI.SetActive(true);

            }
            if (KangarooMeal)
            {
                Player.CurrentOrder = 13;
                ThoughtIcons[13].SetActive(false);
                MossUIUnused.SetActive(false);
                MossUI.SetActive(true);
            }
            if (ChimpDrink)
            {
                Player.CurrentOrder = 14;
                ThoughtIcons[14].SetActive(false);
            }

            if (ChimpMeal)
            {
                Player.CurrentOrder = 15;
                ThoughtIcons[15].SetActive(false);
            }

            if (BeaverMeal)
            {
                Player.CurrentOrder = 16;
                ThoughtIcons[16].SetActive(false);
                StickUIUnused.SetActive(false);
                StickUI.SetActive(true);
            }
            if (GemsbokDrink)
            {
                Player.CurrentOrder = 17;
                ThoughtIcons[17].SetActive(false);
            }

            if (GemsbokMeal)
            {
                Player.CurrentOrder = 18;
                ThoughtIcons[18].SetActive(false);
                SpiceUIUnused.SetActive(false);
                SpiceUI.SetActive(true);

            }
            if (IbexMeal)
            {
                Player.CurrentOrder = 19;
                ThoughtIcons[16].SetActive(false);
            }
            if (DuckMeal)
            {
                Player.CurrentOrder = 20;
                ThoughtIcons[20].SetActive(false);
                SnailUIUnused.SetActive(false);
                SnailUI.SetActive(true);
            }

            if (PangolinDrink)
            {
                Player.CurrentOrder = 21;
                ThoughtIcons[21].SetActive(false);
            }

            if (PangolinMeal)
            {
                Player.CurrentOrder = 22;
                ThoughtIcons[22].SetActive(false);
                PastaUIUnused.SetActive(false);
                PastaUI.SetActive(true);
            }

            if (ChipmunkMeal)
            {
                Player.CurrentOrder = 23;
                ThoughtIcons[23].SetActive(false);
                MushroomUIUnused.SetActive(false);
                MushroomUI.SetActive(true);
            }

            if (PlatypusMeal)
            {
                Player.CurrentOrder = 24;
                ThoughtIcons[24].SetActive(false);
                FlourUIUnused.SetActive(false);
                FlourUI.SetActive(true);
                CrayfishUIUnused.SetActive(false);
                CrayfishUI.SetActive(true);
            }

            if (BatDrink)
            {
                Player.CurrentOrder = 25;
                ThoughtIcons[25].SetActive(false);

            }
            if (BatMeal)
            {
                Player.CurrentOrder = 26;
                ThoughtIcons[26].SetActive(false);
                MothUIUnused.SetActive(false);
                MothUI.SetActive(true);
            }
            if (RaccoonMeal)
            {
                Player.CurrentOrder = 27;
                ThoughtIcons[27].SetActive(false);
                ClamUIUnused.SetActive(false);
                ClamUI.SetActive(true);
            }

            if (AlpacaDrink)
            {
                Player.CurrentOrder = 28;
                ThoughtIcons[28].SetActive(false);
            }

            if (AlpacaMeal)
            {
                Player.CurrentOrder = 29;
                ThoughtIcons[29].SetActive(false);
            }

            if (FoxMeal)
            {
                Player.CurrentOrder = 30;
                ThoughtIcons[30].SetActive(false);
            }

            if (PandaDrink2)
            {
                Player.CurrentOrder = 31;
                ThoughtIcons[31].SetActive(false);
            }

            if (PandaMeal2)
            {
                Player.CurrentOrder = 32;
                ThoughtIcons[32].SetActive(false);
            }
        }
    }
//controls the cross button
    public void CrossButton()
    {
        Player.target = Player.transform.position;

        if (DialogueOpen)
        {
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
            PandaNo.Play();

            DialogueTextTMP.text = "Oh... :(";
        }
    }

    IEnumerator DelayTime()
    {
        TimerRunning = true;
        yield return new WaitForSeconds(0.25f);
        TimerRunning = false;
    }
}
