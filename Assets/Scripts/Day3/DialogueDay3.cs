using UnityEngine;
using TMPro;
using System.Collections;
//new dialogue script that works the dialogue button

public class DialogueDay3 : MonoBehaviour
{
    public bool AbletoTalk;

    public bool FerretInRange; //if pandas in range
    public bool KangarooInRange;
    public bool ChimpInRange;
    public bool BeaverInRange;

    public GameObject DialogueBox; //dialogue box

    public bool TimerRunning;

    public bool DialogueOpen;

    public TextMeshProUGUI DialogueTextTMP;
    public TextMeshProUGUI NameTextTMP;

    public GameObject ThinkBubble;
    public GameObject StrawberryandAppleSmoothieThought;
    public GameObject BoneBrothThought;
    public GameObject MossBurgerThought;
    public GameObject MelonSmoothieThought;
    public GameObject FruitSaladThought;
    public GameObject StickHotdogThought;

    public bool FerretMeal;
    public bool KangarooDrink;
    public bool KangarooMeal;
    public bool ChimpDrink;
    public bool ChimpMeal;
    public bool BeaverMeal;

    public PlayerScript Player; //To access the players script
    public GameObject PlayerGO;

    public GameObject TickButtonGO;
    public GameObject CrossButtonGO;

    public AudioSource StrawberryandAppleSmoothie;
    public AudioSource MossBurger;
    public AudioSource MelonSmoothie;
    public AudioSource FruitSalad;
    public AudioSource BoneBroth;
    public AudioSource StickHotdog;
    public AudioSource Yes;
    public AudioSource No;

    //player unlocks bone, moss, stick, melon
    public GameObject BoneUIUnused;
    public GameObject MossUIUnused;
    public GameObject StickUIUnused;
    public GameObject MelonUIUnused;

    public GameObject BoneUI;
    public GameObject MossUI;
    public GameObject StickUI;
    public GameObject MelonUI;


    public InteractDay3 InteractScript;
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
                if (FerretInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if(FerretMeal)
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

                if(KangarooInRange) //CALL FROM THE INTERACT SCRIPT
                {
                    if(KangarooDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        MelonSmoothie.Play();
                        CustomerName.text = "Kangaroo";
                        DialogueTextTMP.text = "Can I get a Melon Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if(KangarooMeal)
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

                if(ChimpInRange)
                {
                    if(ChimpDrink)
                    {
                        DialogueBox.SetActive(true); //enable the panda dialogue asking for the bamboo hotdog
                        DialogueOpen = true;

                        StrawberryandAppleSmoothie.Play();
                        CustomerName.text = "Chimpanzee";
                        DialogueTextTMP.text = "Can I get a Strawberry and Apple Smoothie?";
                        TickButtonGO.SetActive(true);
                        CrossButtonGO.SetActive(true);
                    }

                    if(ChimpMeal)
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

                if(BeaverInRange)
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
            BoneBroth.Pause();
            MelonSmoothie.Pause();
            MossBurger.Pause();
            FruitSalad.Pause();
            StickHotdog.Pause();
            Yes.Play();

            DialogueTextTMP.text = "Yay!!!";

            ThinkBubble.SetActive(false);
            CrossButtonGO.SetActive(false);
            TickButtonGO.SetActive(false);
            AbletoTalk = false;

            if (FerretMeal)
            {
                Player.CurrentOrder = 1;
                BoneBrothThought.SetActive(false);
                BoneUIUnused.SetActive(false);
                BoneUI.SetActive(true);
            }

            if (KangarooDrink)
            {
                Player.CurrentOrder = 2;
                MelonSmoothieThought.SetActive(false);
                MelonUIUnused.SetActive(false);
                MelonUI.SetActive(true);

            }
            if(KangarooMeal)
            {
                Player.CurrentOrder = 3;
                MossBurgerThought.SetActive(false);
                MossUIUnused.SetActive(false);
                MossUI.SetActive(true);
            }
            if (ChimpDrink)
            {
                Player.CurrentOrder = 4;
                StrawberryandAppleSmoothieThought.SetActive(false);
            }

            if (ChimpMeal)
            {
                Player.CurrentOrder = 5;
                FruitSaladThought.SetActive(false);
            }

            if(BeaverMeal)
            {
                Player.CurrentOrder = 6;
                StickHotdogThought.SetActive(false);
                StickUIUnused.SetActive(false);
                StickUI.SetActive(true);
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
            BoneBroth.Pause();
            MelonSmoothie.Pause();
            MossBurger.Pause();
            FruitSalad.Pause();
            StickHotdog.Pause();
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
