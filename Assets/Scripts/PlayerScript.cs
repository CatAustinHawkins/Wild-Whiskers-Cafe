using UnityEngine;
using TMPro;

//Player Script - controls their movement and player image

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;

    public GameObject playersetupscript; //the player setup script
    public PlayerSetup playersetup;

    public string PlayerName;

    //the different player sprites
    public Sprite Player1;
    public Sprite Player2;
    public Sprite Player3;
    public Sprite Player4;

    public SpriteRenderer spriterenderer;

    public TextMeshProUGUI PlayerNameIntro; //player name text 

    public int CurrentCustomer = 0;

    public int gold;


    void Start()
    {

        playersetupscript = GameObject.FindWithTag("Setup"); //find the player setup script
        playersetup = playersetupscript.GetComponent<PlayerSetup>();


        rb2d = GetComponent<Rigidbody2D>();

        //change the player sprite image based on what the player chose
        if(playersetup.Choice1Selected)
        {
            spriterenderer.sprite = Player1;
        }

        if (playersetup.Choice2Selected)
        {
            spriterenderer.sprite = Player2;
        }

        if (playersetup.Choice3Selected)
        {
            spriterenderer.sprite = Player3;
        }

        if (playersetup.Choice4Selected)
        {
            spriterenderer.sprite = Player4;
        }

        PlayerName = playersetup.PlayerName; //set the players name

        PlayerNameIntro.text = "Hi " + PlayerName + "!"; 
    }

    void Update()
    {
        //movement control
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb2d.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
    }

}
