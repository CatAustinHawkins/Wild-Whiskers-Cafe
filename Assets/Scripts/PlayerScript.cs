using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    public GameObject DialogueBox;

    public GameObject playersetupscript;

    public PlayerSetup playersetup;

    public string PlayerName;

    public Sprite Player1;
    public Sprite Player2;
    public Sprite Player3;
    public Sprite Player4;

    public SpriteRenderer spriterenderer;

    public TextMeshProUGUI PlayerNameIntro;

    //new work
    public bool Recipe1InProgress;
    //player needs to go to fridge and the chopping board

    public bool Recipe2InProgress;
    //player needs to go to the fridge, then the oven, the chopping board

    public bool Recipe3InProgress;
    //player needs to go the fridge, the oven, then the chopping board

    public int CurrentCustomer = 1;

    void Start()
    {

        playersetupscript = GameObject.FindWithTag("Setup");
        playersetup = playersetupscript.GetComponent<PlayerSetup>();


        rb2d = GetComponent<Rigidbody2D>();

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

        PlayerName = playersetup.PlayerName;

        PlayerNameIntro.text = "Hi " + PlayerName + "!";
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb2d.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);

    }



}
