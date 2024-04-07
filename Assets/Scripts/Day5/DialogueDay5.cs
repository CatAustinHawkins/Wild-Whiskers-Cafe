using UnityEngine;
using TMPro;
using System.Collections;
//new dialogue script that works the dialogue button

public class DialogueDay5 : MonoBehaviour
{
    public bool AbletoTalk;

    public bool PlatypusInRange; //if pandas in range
    public bool BatInRange;
    public bool RaccoonInRange;
    public bool AlpacaInRange;
    public bool FoxInRange;
    public bool PandaInRange;

    public GameObject DialogueBox; //dialogue box

    public bool TimerRunning;

    public bool DialogueOpen;

    public TextMeshProUGUI DialogueTextTMP;
    public TextMeshProUGUI NameTextTMP;

    public GameObject ThinkBubble;
    public GameObject CrayfishTempuraThought;
    public GameObject AntSmoothieThought;
    public GameObject MothBiscuitThought;
    public GameObject ClamMisoSoupThought;
    public GameObject StrawberryandAppleSmoothieThought;
    public GameObject HaySaladThought;
    public GameObject MouseBurgerThought;
    public GameObject MeatSmoothieThought;
    public GameObject BambooHotdogThought;

    public bool PlatypusMeal;
    public bool BatDrink;
    public bool BatMeal;
    public bool RaccoonMeal;
    public bool AlpacaDrink;
    public bool AlpacaMeal;
    public bool FoxMeal;
    public bool PandaDrink;
    public bool PandaMeal;

    public PlayerScript Player; //To access the players script
    public GameObject PlayerGO;

    public GameObject TickButtonGO;
    public GameObject CrossButtonGO;

    public AudioSource CrayfishTempura;
    public AudioSource MothBiscuit;
    public AudioSource AntSmoothie;
    public AudioSource ClamMisoSoup;
    public AudioSource HaySalad;
    public AudioSource StrawberryandAppleSmoothie;
    public AudioSource MouseBurger;
    public AudioSource MeatSmoothie;
    public AudioSource BambooHotdog;
    public AudioSource Yes;
    public AudioSource No;

    //player unlocks crayfish, flour, moth, clam
    public GameObject CrayfishUIUnused;
    public GameObject FlourUIUnused;
    public GameObject MothUIUnused;
    public GameObject ClamUIUnused;

    public GameObject CrayfishUI;
    public GameObject FlourUI;
    public GameObject MothUI;
    public GameObject ClamUI;


    public InteractDay5 InteractScript;
    public TextMeshProUGUI CustomerName;

    public void Start()
    {
        PlayerGO = GameObject.FindWithTag("Player");
        Player = PlayerGO.GetComponent<PlayerScript>();
    }

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
        }
    }


    public void DialogueButton()
    {

        Player.target = Player.transform.position;

        if (DialogueOpen)
        {
            DialogueBox.SetActive(false);
            DialogueOpen = false;

        }
        if (AbletoTalk)
        {
            if (!DialogueOpen)
            {
                if (PlatypusInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if(PlatypusMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        CrayfishTempura.Play();
                        CustomerName.text = "Platypus";
                        DialogueTextTMP.text = "Can I get Crayfish Tempura?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if(BatInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if(BatDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        AntSmoothie.Play();
                        CustomerName.text = "Lesser Horseshoe Bat";
                        DialogueTextTMP.text = "Can I get an Ant Smoothie";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (BatMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MothBiscuit.Play();
                        CustomerName.text = "Lesser Horseshoe Bat";
                        DialogueTextTMP.text = "Can I get a Moth Biscuit?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if(RaccoonInRange)
                {
                    if(RaccoonMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        ClamMisoSoup.Play();
                        CustomerName.text = "Raccoon";
                        DialogueTextTMP.text = "Can I get Clam Miso Soup?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if(AlpacaInRange)
                {
                    if (AlpacaDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        StrawberryandAppleSmoothie.Play();
                        CustomerName.text = "Alpaca";
                        DialogueTextTMP.text = "Can I get a Strawberry and Apple Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (AlpacaMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        HaySalad.Play();
                        CustomerName.text = "Alpaca";
                        DialogueTextTMP.text = "Can I get a Hay Salad?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (FoxInRange)
                {
                    if (FoxMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MouseBurger.Play();
                        CustomerName.text = "Fox";
                        DialogueTextTMP.text = "Can I get a Mouse Burger?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (PandaInRange)
                {
                    if (PandaDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MeatSmoothie.Play();
                        CustomerName.text = "Panda";
                        DialogueTextTMP.text = "Can I get a Meat Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                    if (PandaMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        BambooHotdog.Play();
                        CustomerName.text = "Panda";
                        DialogueTextTMP.text = "Can I get a Bamboo Hotdog?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }
            }
            else
            {
                DialogueBox.SetActive(false);
                DialogueOpen = false;
            }
        }

    }

    //controls the tick button
    public void TickButton()
    {
        Player.target = Player.transform.position;


        if (DialogueOpen)
        {
            CrayfishTempura.Pause();
            AntSmoothie.Pause();
            MothBiscuit.Pause();
            ClamMisoSoup.Pause();
            HaySalad.Pause();
            StrawberryandAppleSmoothie.Pause();
            MouseBurger.Pause();
            BambooHotdog.Pause();
            MeatSmoothie.Pause();
            Yes.Play();

            DialogueTextTMP.text = "Yay!!!";

            ThinkBubble.SetActive(false);
            CrossButtonGO.SetActive(false);
            TickButtonGO.SetActive(false);
            AbletoTalk = false;

            if (PlatypusMeal)
            {
                Player.CurrentOrder = 1;
                CrayfishTempuraThought.SetActive(false);
                FlourUIUnused.SetActive(false);
                FlourUI.SetActive(true);
                CrayfishUIUnused.SetActive(false);
                CrayfishUI.SetActive(true);
            }

            if (BatDrink)
            {
                Player.CurrentOrder = 2;
                AntSmoothieThought.SetActive(false);

            }
            if(BatMeal)
            {
                Player.CurrentOrder = 3;
                MothBiscuitThought.SetActive(false);
                MothUIUnused.SetActive(false);
                MothUI.SetActive(true);
            }
            if (RaccoonMeal)
            {
                Player.CurrentOrder = 4;
                ClamMisoSoupThought.SetActive(false);
                ClamUIUnused.SetActive(false);
                ClamUI.SetActive(true);
            }

            if (AlpacaDrink)
            {
                Player.CurrentOrder = 5;
                StrawberryandAppleSmoothieThought.SetActive(false);
            }

            if(AlpacaMeal)
            {
                Player.CurrentOrder = 6;
                HaySaladThought.SetActive(false);
            }

            if (FoxMeal)
            {
                Player.CurrentOrder = 7;
                MouseBurgerThought.SetActive(false);
            }

            if (PandaDrink)
            {
                Player.CurrentOrder = 8;
                MeatSmoothieThought.SetActive(false);
            }

            if (PandaMeal)
            {
                Player.CurrentOrder = 9;
                BambooHotdogThought.SetActive(false);
            }
        }

    }

    //controls the cross button
    public void CrossButton()
    {
        Player.target = Player.transform.position;

        if (DialogueOpen)
        {
            CrayfishTempura.Pause();
            AntSmoothie.Pause();
            MothBiscuit.Pause();
            ClamMisoSoup.Pause();
            HaySalad.Pause();
            StrawberryandAppleSmoothie.Pause();
            MouseBurger.Pause();
            BambooHotdog.Pause();
            MeatSmoothie.Pause();
            No.Play();
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
