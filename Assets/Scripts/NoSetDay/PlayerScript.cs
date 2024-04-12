using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

//Player Script - controls their movement and player image

public class PlayerScript : MonoBehaviour
{
    public float speed = 8;

    public GameObject playersetupscript; //the player setup script
    public PlayerSetup playersetup;

    public GameObject setupscript; //the player setup script
    public Setup setup;

    public string PlayerName;

    //the different player sprites
    public Sprite Player1;
    public Sprite Player2;
    public Sprite Player3;
    public Sprite Player4;
    public Sprite Player5;
    public Sprite Player6;
    public Sprite Player7;
    public Sprite Player8;
    public Vector3 target;

    public int PlayerAppearance;

    public SpriteRenderer spriterenderer;

    public TextMeshProUGUI PlayerNameIntro; //player name text 

    public int CurrentOrder = 0;

    public int gold;

    public TextMeshProUGUI goldtext;

    public bool ChangedRoom;

    public bool WashingUp;

    public GameObject TestSaveGO;
    public MainMenuSave TestScript;

    public bool PlayedBefore;


    void Start()
    {
        Load();
        DontDestroyOnLoad(this.gameObject); //dont destroy - so the player script can access it 


        target = transform.position;
        speed = 12;

        TestSaveGO = GameObject.FindWithTag("Test"); //find the player setup script
        TestScript = TestSaveGO.GetComponent<MainMenuSave>();

        if (!PlayedBefore)
        {
            playersetupscript = GameObject.FindWithTag("Setup"); //find the player setup script
            playersetup = playersetupscript.GetComponent<PlayerSetup>();

            TestSaveGO = GameObject.FindWithTag("Test"); //find the player setup script
            TestScript = TestSaveGO.GetComponent<MainMenuSave>();

            //setupscript = GameObject.FindWithTag("SetupOne"); //find the player setup script
            //setup = setupscript.GetComponent<Setup>();


            //change the player sprite image based on what the player chose
            if (playersetup.Choice1Selected)
            {
                spriterenderer.sprite = Player1;
                PlayerAppearance = 1;
                Save();
            }

            if (playersetup.Choice2Selected)
            {
                spriterenderer.sprite = Player2;
                PlayerAppearance = 2;
                Save();
            }

            if (playersetup.Choice3Selected)
            {
                spriterenderer.sprite = Player3;
                PlayerAppearance = 3;
                Save();
            }

            if (playersetup.Choice4Selected)
            {
                spriterenderer.sprite = Player4;
                PlayerAppearance = 4;
                Save();
            }

            if (playersetup.Choice5Selected)
            {
                spriterenderer.sprite = Player5;
                PlayerAppearance = 5;
                Save();
            }

            if (playersetup.Choice6Selected)
            {
                spriterenderer.sprite = Player6;
                PlayerAppearance = 6;
                Save();
            }

            if (playersetup.Choice7Selected)
            {
                spriterenderer.sprite = Player7;
                PlayerAppearance = 7;
                Save();
            }

            if (playersetup.Choice8Selected)
            {
                spriterenderer.sprite = Player8;
                PlayerAppearance = 8;
                Save();
            }

            PlayerName = playersetup.PlayerName; //set the players name

            PlayerNameIntro.text = "Hi " + PlayerName + "!";
        }
    }

    void Update()
    {
        goldtext.text = "Gold: " + gold.ToString() + "g";

        if (!WashingUp)
        {
            if (Input.GetMouseButtonDown(0))
            {

                if (EventSystem.current.IsPointerOverGameObject())
                {
                    Debug.Log("Clicked on the UI");
                    return;
                }
                else
                {

                    target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    target.z = transform.position.z;
                }

            }

            if (!ChangedRoom)
            {
                transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            }

            if (ChangedRoom)
            {
                target = transform.position;
            }
        }

        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        target = transform.position;

    }

    public void NewLevel()
    {
        TestScript.PlayerLevel++;
        TestScript.Save();
        Save();
    }

    public void WardrobeOption1()
    {
        spriterenderer.sprite = Player1;
        PlayerAppearance = 1;
        Save();
    }
    public void WardrobeOption2()
    {
        spriterenderer.sprite = Player2;
        PlayerAppearance = 2;
        Save();
    }
    public void WardrobeOption3()
    {
        spriterenderer.sprite = Player3;
        PlayerAppearance = 3;
        Save();
    }
    public void WardrobeOption4()
    {
        spriterenderer.sprite = Player4;
        PlayerAppearance = 4;
        Save();
    }
    public void WardrobeOption5()
    {
        spriterenderer.sprite = Player5;
        PlayerAppearance = 5;
        Save();
    }
    public void WardrobeOption6()
    {
        spriterenderer.sprite = Player6;
        PlayerAppearance = 6;
        Save();
    }
    public void WardrobeOption7()
    {
        spriterenderer.sprite = Player7;
        PlayerAppearance = 7;
        Save();
    }
    public void WardrobeOption8()
    {
        spriterenderer.sprite = Player8;
        PlayerAppearance = 8;
        Save();
    }

    public void Save()
    {
        PlayerPrefs.SetInt("PlayerSprite", PlayerAppearance);
        PlayerPrefs.SetInt("PlayerGold", gold);
        PlayerPrefs.SetString("PlayerName", name);

        PlayedBefore = true;
    }

    public void Load()
    {
        PlayerAppearance = PlayerPrefs.GetInt("PlayerSprite");
        gold = PlayerPrefs.GetInt("PlayerGold");
        name = PlayerPrefs.GetString("PlayerName");
    }
}
