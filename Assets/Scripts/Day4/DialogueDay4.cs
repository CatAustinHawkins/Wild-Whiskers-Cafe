using UnityEngine;
using TMPro;
using System.Collections;
//new dialogue script that works the dialogue button

public class DialogueDay4 : MonoBehaviour
{
    public bool AbletoTalk;

    public bool GemsbokInRange; //if pandas in range
    public bool IbexInRange;
    public bool DuckInRange;
    public bool PangolinInRange;
    public bool ChipmunkInRange;

    public GameObject DialogueBox; //dialogue box

    public bool TimerRunning;

    public bool DialogueOpen;

    public TextMeshProUGUI DialogueTextTMP;
    public TextMeshProUGUI NameTextTMP;

    public GameObject ThinkBubble;
    public GameObject MelonSmoothieThought;
    public GameObject PoachedMelonThought;
    public GameObject LeafSaladThought;
    public GameObject EscargotThought;
    public GameObject AntSmoothieThought;
    public GameObject AntPastaThought;
    public GameObject RoastedMushroomThought;

    public bool GemsbokDrink;
    public bool GemsbokMeal;
    public bool IbexMeal;
    public bool DuckMeal;
    public bool PangolinDrink;
    public bool PangolinMeal;
    public bool ChipmunkMeal;

    public PlayerScript Player; //To access the players script
    public GameObject PlayerGO;

    public GameObject TickButtonGO;
    public GameObject CrossButtonGO;

    public AudioSource MelonSmoothie;
    public AudioSource PoachedMelon;
    public AudioSource LeafSalad;
    public AudioSource Escargot;
    public AudioSource AntSmoothie;
    public AudioSource AntPasta;
    public AudioSource RoastedMushroom;
    public AudioSource Yes;
    public AudioSource No;

    //player unlocks spice, snail, mushroom, pasta
    public GameObject SpiceUIUnused;
    public GameObject SnailUIUnused;
    public GameObject MushroomUIUnused;
    public GameObject PastaUIUnused;

    public GameObject SpiceUI;
    public GameObject SnailUI;
    public GameObject MushroomUI;
    public GameObject PastaUI;


    public InteractDay4 InteractScript;
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
                if (GemsbokInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if(GemsbokDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MelonSmoothie.Play();
                        CustomerName.text = "Gemsbok";
                        DialogueTextTMP.text = "Can I get a Melon Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (GemsbokMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        PoachedMelon.Play();
                        CustomerName.text = "Gemsbok";
                        DialogueTextTMP.text = "Can I get a Poached Melon?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if(IbexInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if(IbexMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        LeafSalad.Play();
                        CustomerName.text = "Ibex";
                        DialogueTextTMP.text = "Can I get a Leaf Salad?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if(DuckInRange)
                {
                    if(DuckMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        Escargot.Play();
                        CustomerName.text = "Mandarin Duck";
                        DialogueTextTMP.text = "Can I get Escargot?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if(PangolinInRange)
                {
                    if (PangolinDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        AntSmoothie.Play();
                        CustomerName.text = "Pangolin";
                        DialogueTextTMP.text = "Can I get an Ant Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (PangolinMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        AntPasta.Play();
                        CustomerName.text = "Pangolin";
                        DialogueTextTMP.text = "Can I get Ant Pasta?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (ChipmunkInRange)
                {
                    if (ChipmunkMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        RoastedMushroom.Play();
                        CustomerName.text = "Chipmunk";
                        DialogueTextTMP.text = "Can I get Roasted Mushrooms?";
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
            MelonSmoothie.Pause();
            PoachedMelon.Pause();
            LeafSalad.Pause();
            Escargot.Pause();
            AntPasta.Pause();
            AntSmoothie.Pause();
            RoastedMushroom.Pause();
            Yes.Play();

            DialogueTextTMP.text = "Yay!!!";

            ThinkBubble.SetActive(false);
            CrossButtonGO.SetActive(false);
            TickButtonGO.SetActive(false);
            AbletoTalk = false;

            if (GemsbokDrink)
            {
                Player.CurrentOrder = 1;
                MelonSmoothieThought.SetActive(false);
            }

            if (GemsbokMeal)
            {
                Player.CurrentOrder = 2;
                PoachedMelonThought.SetActive(false);
                SpiceUIUnused.SetActive(false);
                SpiceUI.SetActive(true);

            }
            if(IbexMeal)
            {
                Player.CurrentOrder = 3;
                LeafSaladThought.SetActive(false);
            }
            if (DuckMeal)
            {
                Player.CurrentOrder = 4;
                EscargotThought.SetActive(false);
                SnailUIUnused.SetActive(false);
                SnailUI.SetActive(true);
            }

            if (PangolinDrink)
            {
                Player.CurrentOrder = 5;
                AntSmoothieThought.SetActive(false);
            }

            if(PangolinMeal)
            {
                Player.CurrentOrder = 6;
                AntPastaThought.SetActive(false);
                PastaUIUnused.SetActive(false);
                PastaUI.SetActive(true);
            }

            if (ChipmunkMeal)
            {
                Player.CurrentOrder = 7;
                RoastedMushroomThought.SetActive(false);
                MushroomUIUnused.SetActive(false);
                MushroomUI.SetActive(true);
            }
        }

    }

    //controls the cross button
    public void CrossButton()
    {
        Player.target = Player.transform.position;

        if (DialogueOpen)
        {
            MelonSmoothie.Pause();
            PoachedMelon.Pause();
            LeafSalad.Pause();
            Escargot.Pause();
            AntPasta.Pause();
            AntSmoothie.Pause();
            RoastedMushroom.Pause();
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
