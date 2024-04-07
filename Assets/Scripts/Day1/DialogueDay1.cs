using UnityEngine;
using TMPro;
using System.Collections;
//new dialogue script that works the dialogue button

public class DialogueDay1 : MonoBehaviour
{
    public bool AbletoTalk;

    public bool AdderInRange; //if pandas in range
    public bool LeopardInRange;

    public GameObject DialogueBox; //dialogue box

    public bool TimerRunning;

    public bool DialogueOpen;

    public TextMeshProUGUI DialogueTextTMP;
    public TextMeshProUGUI NameTextTMP;

    public GameObject ThinkBubble;
    public GameObject MeatSmoothieThought;
    public GameObject MouseBurgerThought;
    public GameObject VensionSteakThought;

    public bool AdderMeal;
    public bool LeopardDrink;
    public bool LeopardMeal;

    public PlayerScript Player; //To access the players script
    public GameObject PlayerGO;

    public GameObject TickButtonGO;
    public GameObject CrossButtonGO;

    public AudioSource VenisonSteak;
    public AudioSource MeatSmoothie;
    public AudioSource MouseBurger;
    public AudioSource Yes;
    public AudioSource No;

    public InteractDay1 InteractScript;

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
                if (AdderInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if(AdderMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MouseBurger.Play();
                        CustomerName.text = "Adder";
                        DialogueTextTMP.text = "Can I get a Mouse Burger?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if(LeopardInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if(LeopardDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MeatSmoothie.Play();
                        CustomerName.text = "Leopard";
                        DialogueTextTMP.text = "Can I get a Meat Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if(LeopardMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        VenisonSteak.Play();
                        CustomerName.text = "Leopard";
                        DialogueTextTMP.text = "Can I get a Venison Steak?";
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
            VenisonSteak.Pause();
            MouseBurger.Pause();
            MeatSmoothie.Pause();
            Yes.Play();

            DialogueTextTMP.text = "Yay!!!";

            ThinkBubble.SetActive(false);
            CrossButtonGO.SetActive(false);
            TickButtonGO.SetActive(false);
            AbletoTalk = false;

            if (AdderMeal)
            {
                Player.CurrentOrder = 1;
                MouseBurgerThought.SetActive(false);
            }

            if (LeopardDrink)
            {
                Player.CurrentOrder = 2;
                MeatSmoothieThought.SetActive(false);

            }
            if(LeopardMeal)
            {
                Player.CurrentOrder = 3;
                VensionSteakThought.SetActive(false);

            }
        }

    }

    //controls the cross button
    public void CrossButton()
    {
        Player.target = Player.transform.position;

        if (DialogueOpen)
        {
            MeatSmoothie.Pause();
            MouseBurger.Pause();
            VenisonSteak.Pause();
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
