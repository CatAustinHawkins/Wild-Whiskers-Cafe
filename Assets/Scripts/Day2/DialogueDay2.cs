using UnityEngine;
using TMPro;
using System.Collections;
//new dialogue script that works the dialogue button

public class DialogueDay2 : MonoBehaviour
{
    public bool AbletoTalk;

    public bool PonyInRange; //if pandas in range
    public bool HedgehogInRange;
    public bool GiraffeInRange;

    public GameObject DialogueBox; //dialogue box

    public bool TimerRunning;

    public bool DialogueOpen;

    public TextMeshProUGUI DialogueTextTMP;
    public TextMeshProUGUI NameTextTMP;

    public GameObject ThinkBubble;
    public GameObject StrawberryandAppleSmoothieThought;
    public GameObject HaySaladThought;
    public GameObject AntSmoothieThought;
    public GameObject WormSpaghettiThought;
    public GameObject LeafSaladThought;

    public bool PonyDrink;
    public bool PonyMeal;
    public bool HedgehogDrink;
    public bool HedgehogMeal;
    public bool GiraffeMeal;

    public PlayerScript Player; //To access the players script
    public GameObject PlayerGO;

    public GameObject TickButtonGO;
    public GameObject CrossButtonGO;

    public AudioSource StrawberryandAppleSmoothie;
    public AudioSource HaySalad;
    public AudioSource AntSmoothie;
    public AudioSource WormSpaghetti;
    public AudioSource LeafSalad;
    public AudioSource Yes;
    public AudioSource No;

    //player unlocks strawberry, apple, worms, tomato, ant, hay and leaf 
    public GameObject StrawberryUIUnused;
    public GameObject AppleUIUnused;
    public GameObject WormsUIUnused;
    public GameObject TomatoUIUnused;
    public GameObject AntUIUnused;
    public GameObject HayUIUnused;
    public GameObject LeafUIUnused;

    public GameObject StrawberryUI;
    public GameObject AppleUI;
    public GameObject WormsUI;
    public GameObject TomatoUI;
    public GameObject AntUI;
    public GameObject HayUI;
    public GameObject LeafUI;

    public InteractDay2 InteractScript;
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
                if (PonyInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if(PonyDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        StrawberryandAppleSmoothie.Play();
                        CustomerName.text = "Shetland Pony";
                        DialogueTextTMP.text = "Can I get a Strawberry and Apple Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if(PonyMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        HaySalad.Play();
                        CustomerName.text = "Shetland Pony";
                        DialogueTextTMP.text = "Can I get a Hay Salad?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if(HedgehogInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if(HedgehogDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        AntSmoothie.Play();
                        CustomerName.text = "Hedgehog";
                        DialogueTextTMP.text = "Can I get an Ant Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if(HedgehogMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        WormSpaghetti.Play();
                        CustomerName.text = "Hedgehog";
                        DialogueTextTMP.text = "Can I get Worm Spaghetti?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if(GiraffeInRange)
                {
                    if(GiraffeMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        LeafSalad.Play();
                        CustomerName.text = "Giraffe";
                        DialogueTextTMP.text = "Can I get a Leaf Salad?";
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
            StrawberryandAppleSmoothie.Pause();
            AntSmoothie.Pause();
            HaySalad.Pause();
            LeafSalad.Pause();
            WormSpaghetti.Pause();
            Yes.Play();

            DialogueTextTMP.text = "Yay!!!";

            ThinkBubble.SetActive(false);
            CrossButtonGO.SetActive(false);
            TickButtonGO.SetActive(false);
            AbletoTalk = false;

            if (PonyDrink)
            {
                Player.CurrentOrder = 1;
                StrawberryandAppleSmoothieThought.SetActive(false);
                StrawberryUIUnused.SetActive(false);
                AppleUIUnused.SetActive(false);
                StrawberryUI.SetActive(true);
                AppleUI.SetActive(true);
            }

            if (PonyMeal)
            {
                Player.CurrentOrder = 2;
                HaySaladThought.SetActive(false);
                HayUIUnused.SetActive(false);
                HayUI.SetActive(true);

            }
            if(HedgehogDrink)
            {
                Player.CurrentOrder = 3;
                AntSmoothieThought.SetActive(false);
                AntUIUnused.SetActive(false);
                AntUI.SetActive(true);
            }
            if (HedgehogMeal)
            {
                Player.CurrentOrder = 4;
                WormSpaghettiThought.SetActive(false);
                WormsUIUnused.SetActive(false);
                WormsUI.SetActive(true);
                TomatoUIUnused.SetActive(false);
                TomatoUI.SetActive(true);
            }

            if (GiraffeMeal)
            {
                Player.CurrentOrder = 5;
                LeafSaladThought.SetActive(false);
                LeafUIUnused.SetActive(false);
                LeafUI.SetActive(true);
            }
        }

    }

    //controls the cross button
    public void CrossButton()
    {
        Player.target = Player.transform.position;

        if (DialogueOpen)
        {
            StrawberryandAppleSmoothie.Pause();
            AntSmoothie.Pause();
            HaySalad.Pause();
            LeafSalad.Pause();
            WormSpaghetti.Pause();
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
