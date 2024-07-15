using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

//Player Script - controls their movement and player avatar

public class PlayerScript : MonoBehaviour
{
    public float speed = 14; //speed of the player when they move

    public GameObject PlayerSetup; //the player setup gameobject
    public PlayerSetup PlayerSetupScript; //the player setup script

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

    public Vector3 target; //their target position

    public int PlayerAppearance; //the apperance they set 

    public SpriteRenderer spriterenderer; //the players SpriteRenderer, for when they change appearance

    public TextMeshProUGUI PlayerNameIntro; //player name text 

    public int CurrentOrder = 0; //the player's current order, used by the current order script

    public int gold = 50; //their gold count

    public TextMeshProUGUI goldtext; //gold textmeshpro object used in shop cookbook section

    public bool WashingUp; //if the player is washing up or not

    public bool PlayedBefore; //if the player has played before

    public GameObject TutorialPrompts;

    void Start()
    {
       // Load(); //load any saved data

        if (!PlayedBefore) //if the player hasn't played before
        {
            PlayerSetup = GameObject.FindWithTag("Setup"); //find the player setup script
            PlayerSetupScript = PlayerSetup.GetComponent<PlayerSetup>();

            //change the player sprite image based on what the player chose and save
            if (PlayerSetupScript.Choice1Selected)
            {
                spriterenderer.sprite = Player1;
                PlayerAppearance = 1;
                Save();
            }

            if (PlayerSetupScript.Choice2Selected)
            {
                spriterenderer.sprite = Player2;
                PlayerAppearance = 2;
                Save();
            }

            if (PlayerSetupScript.Choice3Selected)
            {
                spriterenderer.sprite = Player3;
                PlayerAppearance = 3;
                Save();
            }

            if (PlayerSetupScript.Choice4Selected)
            {
                spriterenderer.sprite = Player4;
                PlayerAppearance = 4;
                Save();
            }

            if (PlayerSetupScript.Choice5Selected)
            {
                spriterenderer.sprite = Player5;
                PlayerAppearance = 5;
                Save();
            }

            if (PlayerSetupScript.Choice6Selected)
            {
                spriterenderer.sprite = Player6;
                PlayerAppearance = 6;
                Save();
            }

            if (PlayerSetupScript.Choice7Selected)
            {
                spriterenderer.sprite = Player7;
                PlayerAppearance = 7;
                Save();
            }

            if (PlayerSetupScript.Choice8Selected)
            {
                spriterenderer.sprite = Player8;
                PlayerAppearance = 8;
                Save();
            }

            PlayerName = PlayerSetupScript.PlayerName; //set the players name based on what they chose on setup

            PlayerNameIntro.text = $"Hi {PlayerName}!"; //change the player name on the intro to the name they chose
        }
    }

    void Update()
    {
        goldtext.text = "Gold: " + gold.ToString() + "g"; //continiously update the players gold count for the Shop Cookbook UI
        
        if (Input.GetKey(KeyCode.Escape)) //if the player presses escape
        {
            SceneManager.LoadScene("MainMenu"); //open main menu, where they can close the game
        }

        if (WashingUp) return; // if the player isn't washing up

        if (Input.GetMouseButtonDown(0)) //if they hold down the left (0) mouse button
        {
            if (EventSystem.current.IsPointerOverGameObject()) //if they arent clicking UI
            {
                Debug.Log("Clicked on the UI");
                return;
            }
            else
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition); //find where they clicked
                target.z = transform.position.z; //set the target.z value to the players tranform.position.z value, as the player won't move in the Z axis
            }

        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime); //move the player
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        target = transform.position; //if the player collides with anything, stop their movement
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Puddle")
        {
            speed = 7; //if the player collides with a puzzle, halve their speed
        }

    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Puddle")
        {
            speed = 14; //when the player leaves the puddles collision, reset their speeed 
        }

    }

    //change the player sprite image based on what the player chose and save
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

    //saves their gold, appearance, and name
    public void Save()
    {
        PlayerPrefs.SetInt("PlayerSprite", PlayerAppearance);
        PlayerPrefs.SetInt("PlayerGold", gold);
        PlayerPrefs.SetString("PlayerName", name);

        PlayedBefore = true;
    }

    //loads their gold, appearance, and name
    /*
    public void Load()
    {
        PlayerAppearance = PlayerPrefs.GetInt("PlayerSprite");
        gold = PlayerPrefs.GetInt("PlayerGold");
        name = PlayerPrefs.GetString("PlayerName");
    }
    */
}
