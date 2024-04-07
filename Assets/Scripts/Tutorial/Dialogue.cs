using UnityEngine;
using TMPro;
using System.Collections;
//new dialogue script that works the dialogue button

public class Dialogue : MonoBehaviour
{
    public bool AbletoTalk;

    public bool PandaInRange; //if pandas in range

    public GameObject DialogueBox; //dialogue box

    public bool TimerRunning;

    public bool DialogueOpen;

    public TextMeshProUGUI DialogueTextTMP;
    public TextMeshProUGUI NameTextTMP;
    public Tutorial TutorialScript;

    public GameObject ThinkBubble;
    public GameObject MeatSmoothieThought;
    public GameObject BambooHotdogThought;
    public GameObject MouseBurgerThought;
    public GameObject VensionSteakThought;
    public GameObject StrawberryandAppleSmoothieThought;
    public GameObject BoneBrothThought;
    public GameObject MossBurgerThought;
    public GameObject MelonSmoothieThought;
    public GameObject FruitSaladThought;
    public GameObject StickHotdogThought;

    public bool MealTime;
    public bool FerretMeal;
    public bool KangarooDrink;
    public bool KangarooMeal;
    public bool ChimpDrink;
    public bool ChimpMeal;
    public bool BeaverMeal;

    public PlayerScript Player; //To access the players script
    public GameObject PlayerGO;

    public GameObject BambooUIUnused;
    public GameObject BreadUIUnused;
    public GameObject MeatUIUnused;
    public GameObject BoneUIUnused;
    public GameObject MossUIUnused;
    public GameObject StickUIUnused;
    public GameObject MelonUIUnused;


    public GameObject BambooUI;
    public GameObject BreadUI;
    public GameObject MeatUI;
    public GameObject BoneUI;
    public GameObject MossUI;
    public GameObject StickUI;
    public GameObject MelonUI;


    public GameObject TickButtonGO;
    public GameObject CrossButtonGO;

    public AudioSource VenisonSteakAudio;
    public AudioSource MeatSmoothieAudio;
    public AudioSource MouseBurgerAudio;
    public AudioSource BambooHotdogAudio;
    public AudioSource StrawberryandAppleSmoothieAudio;
    public AudioSource MossBurgerAudio;
    public AudioSource MelonSmoothieAudio;
    public AudioSource FruitSalaAudiod;
    public AudioSource BoneBrothAudio;
    public AudioSource StickHotdogAudio;
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

    Day 3

    */
    public void Start()
    {
        PlayerGO = GameObject.FindWithTag("Player");
        Player = PlayerGO.GetComponent<PlayerScript>();
    }
    public void Update()
    {


        if(AbletoTalk)
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
            Debug.Log("Test2");

            DialogueBox.SetActive(false);
            DialogueOpen = false;
            if (TutorialScript.TutorialImages == 9)
            {
                TutorialScript.NextTutorial();
            }
        }
    }


    //same as interact script
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "PandaCustomer")
        {
            PandaInRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "PandaCustomer")
        {
            PandaInRange = false;
            DialogueBox.SetActive(false);
            DialogueOpen = false;
        }
    }

    public void DialogueButton()
    {

        Player.target = Player.transform.position;

        if (DialogueOpen)
        {
            Debug.Log("Test2");

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
                //TUTORIAL
                if (PandaInRange)
                {
                    if (TutorialScript.TutorialImages == 7)
                    {
                        TutorialScript.NextTutorial();
                        PandaMS.Play();
                    }
                    DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                    DialogueOpen = true;

                    if (MealTime)
                    {
                        PandaBH.Play();
                        DialogueTextTMP.text = "Can I get a Bamboo Hotdog?";
                    }
                    TickButtonGO.SetActive(true);
                    CrossButtonGO.SetActive(true);
                }

                if (FerretInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (FerretMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        BoneBroth.Play();
                        CustomerName.text = "Ferret";
                        DialogueTextTMP.text = "Can I get Bone Broth?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                }

                if (KangarooInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if (KangarooDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MelonSmoothie.Play();
                        CustomerName.text = "Kangaroo";
                        DialogueTextTMP.text = "Can I get a Melon Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (KangarooMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MossBurger.Play();
                        CustomerName.text = "Kangaroo";
                        DialogueTextTMP.text = "Can I get a Moss Burger?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (ChimpInRange)
                {
                    if (ChimpDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        StrawberryandAppleSmoothie.Play();
                        CustomerName.text = "Chimpanzee";
                        DialogueTextTMP.text = "Can I get a Strawberry and Apple Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if (ChimpMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        StrawberryandAppleSmoothie.Play();
                        CustomerName.text = "Chimpanzee";
                        DialogueTextTMP.text = "Can I get a Fruit Salad?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }

                if (BeaverInRange)
                {
                    if (BeaverMeal)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        StrawberryandAppleSmoothie.Play();
                        CustomerName.text = "Beaver";
                        DialogueTextTMP.text = "Can I get a Stick Hotdog?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }
                }
            }
        }
            else
            {
                DialogueBox.SetActive(false);
                DialogueOpen = false;
                if (TutorialScript.TutorialImages == 9)
                {
                    TutorialScript.NextTutorial();
                }

                
            }


        }

    }

    //controls the tick button
    public void TickButton()
    {
        Player.target = Player.transform.position;


        if (DialogueOpen)
        {
            PandaMS.Pause();
            PandaBH.Pause();
            PandaYes.Play();
            if (PandaInRange)
            {
                if (TutorialScript.TutorialImages == 8)
                {
                    TutorialScript.NextTutorial();
                }
                ThinkBubble.SetActive(false);
                DialogueTextTMP.text = "Yay!!!";
                CrossButtonGO.SetActive(false);
                TickButtonGO.SetActive(false);
            }

            if(MealTime)
            {
                Player.CurrentOrder = 2;
                BambooUIUnused.SetActive(false);
                BreadUIUnused.SetActive(false);

                BambooUI.SetActive(true);
                BreadUI.SetActive(true);
                CrossButtonGO.SetActive(false);
                TickButtonGO.SetActive(false);
                BambooHotdogThought.SetActive(false);
                ThinkBubble.SetActive(false);
                AbletoTalk = false;
                if (TutorialScript.TutorialImages == 21)
                {
                    TutorialScript.NextTutorial();
                }
            }
            else
            {
                Player.CurrentOrder = 1;
                MeatUIUnused.SetActive(false);
                MeatUI.SetActive(true);
                CrossButtonGO.SetActive(false);
                TickButtonGO.SetActive(false);
                MeatSmoothieThought.SetActive(false);
                ThinkBubble.SetActive(false);
                AbletoTalk = false;


            }
        }

    }

    //controls the cross button
    public void CrossButton()
    {
        Player.target = Player.transform.position;

        if (DialogueOpen)
        {
            PandaMS.Pause();
            PandaBH.Pause();
            PandaNo.Play();
            if (PandaInRange)
            {
                DialogueTextTMP.text = "Oh... :(";
            }
        }
    }

    IEnumerator DelayTime()
    {
        TimerRunning = true;
        yield return new WaitForSeconds(0.25f);
        TimerRunning = false;
    }
}
