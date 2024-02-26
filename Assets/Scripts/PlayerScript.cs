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
    public Sprite Player5;
    public Sprite Player6;
    public Sprite Player7;
    public Sprite Player8;
    public Vector3 target;

    public SpriteRenderer spriterenderer;

    public TextMeshProUGUI PlayerNameIntro; //player name text 

    public int CurrentCustomer = 0;

    public int gold;

    public bool ChangedRoom;
    void Start()
    {
        target = transform.position;

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

        if (playersetup.Choice5Selected)
        {
            spriterenderer.sprite = Player5;
        }

        if (playersetup.Choice6Selected)
        {
            spriterenderer.sprite = Player6;
        }

        if (playersetup.Choice7Selected)
        {
            spriterenderer.sprite = Player7;
        }

        if (playersetup.Choice8Selected)
        {
            spriterenderer.sprite = Player8;
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

        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        if(!ChangedRoom)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }

        if (ChangedRoom)
        {
            target = transform.position;
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            target = transform.position;

        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        target = transform.position;

    }
}
