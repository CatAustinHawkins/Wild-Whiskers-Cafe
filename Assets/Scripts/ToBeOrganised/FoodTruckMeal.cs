using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoodTruckMeal : MonoBehaviour
{

    //Random Choose A Number for which animal orders
    //update the dialogue image and text
    //Check what diet that animal eats
    //random what they order


    public int Animals;
    public GameObject DialogueBox;

    public TextMeshProUGUI AnimalName;
    public Image AnimalImage;

    public TextMeshProUGUI OrderText;

    public AudioSource[] AnimalDialogueNoise;

    public Sprite[] AnimalSprites;

    public GameObject[] MealGuides;
    //2 = STEAK

    public GameObject Bubble;

    public bool carnivore;
    public bool herbivore;
    public bool insectivore;

    public int previousmaths1;
    public int previousmaths2;
    public int previousmaths3;
    public int previousmaths4;
    public int previousmaths5;

    public int maths1;
    public int maths2;
    public int maths3;
    public int maths4;
    public int maths5;

    public bool cooldown;


    //Meal Bools
    public bool FruitSalad;
    public bool FruitSmoothie;
    public bool MossBurger;
    public bool BambooHotdog;
    public bool StickHotdog;
    public bool MeatSmoothie;
    public bool SausageRoll;
    public bool MouseBurger;
    public bool AntSmoothie;
    public bool MothBiscuit;
    public bool Steak;

    public int CurrentOrderValue;

    // Start is called before the first frame update
    void Start()
    {
        AnimalRandom();
    }


    public void DialogueTime()
    {
        AnimalCheck();
        StartCoroutine(PauseCooldown());
        Bubble.SetActive(false);
        DialogueBox.SetActive(true);
    }

    void AnimalRandom()
    {
        maths1 = Random.Range(0, 24);

        while(maths1 == previousmaths1)
        {
            maths1 = Random.Range(0, 24);
        }

        previousmaths1 = maths1;

        Animals = maths1;

        Bubble.SetActive(true);
        StartCoroutine(Testing());
    }


    //Herbivore List: Shetland Pony, Giraffe, Red Kangaroo, Beaver, Gemsbok, Ibex, Alpaca - 7
    //Carnivore List: Bob Cat, Platypus, Ferret, Adder, Leopard - 5
    //Insectivore List: Pangolin, Lesser Horseshoe Bat - 2
    //Omnivore List: Fox, Brown Bear, Raccoon, Chipmunk, Mandarin Duck, Chimpanzee, Hedgehog, Panda - 8 


    void AnimalCheck()
    {
        MealGuides[0].SetActive(false);
        MealGuides[1].SetActive(false);
        MealGuides[2].SetActive(false);
        MealGuides[3].SetActive(false);
        MealGuides[4].SetActive(false);
        MealGuides[5].SetActive(false);
        MealGuides[6].SetActive(false);
        MealGuides[7].SetActive(false);
        MealGuides[8].SetActive(false);
        MealGuides[9].SetActive(false);
        MealGuides[10].SetActive(false);


        switch (Animals)
        {
            case 0:
                Debug.Log("Pangolin");
                AnimalName.text = "Pangolin";
                AnimalImage.sprite = AnimalSprites[0];
                Insect();
                break;
            case 1:
                Debug.Log("Lesser Horseshoe Bat");
                AnimalName.text = "Lesser Horseshoe Bat";
                AnimalImage.sprite = AnimalSprites[1];
                Insect();
                break;
            case 2:
                Debug.Log("Bob Cat");
                AnimalName.text = "Bob Cat";
                AnimalImage.sprite = AnimalSprites[2];
                Carn();
                break;
            case 3:
                Debug.Log("Platypus");
                AnimalName.text = "Platypus";
                AnimalImage.sprite = AnimalSprites[3];
                Carn();
                break;
            case 4:
                Debug.Log("Ferret");
                AnimalName.text = "Ferret";
                AnimalImage.sprite = AnimalSprites[4];
                Carn();
                break;
            case 5:
                Debug.Log("Adder");
                AnimalName.text = "Adder";
                AnimalImage.sprite = AnimalSprites[5];
                Carn();
                break;
            case 6:
                Debug.Log("Leopard");
                AnimalName.text = "Leopard";
                AnimalImage.sprite = AnimalSprites[6];
                Carn();
                break;
            case 7:
                Debug.Log("Shetland Pony");
                AnimalName.text = "Shetland Pony";
                AnimalImage.sprite = AnimalSprites[7];
                Herb();
                break;
            case 8:
                Debug.Log("Giraffe");
                AnimalName.text = "Giraffe";
                AnimalImage.sprite = AnimalSprites[8];
                Herb();
                break;
            case 9:
                Debug.Log("Red Kangaroo");
                AnimalName.text = "Red Kangaroo";
                AnimalImage.sprite = AnimalSprites[9];
                Herb();
                break;
            case 10:
                Debug.Log("Beaver");
                AnimalName.text = "Beaver";
                AnimalImage.sprite = AnimalSprites[10];
                Herb();
                break;
            case 11:
                Debug.Log("Gemsbok");
                AnimalName.text = "Gemsbok";
                AnimalImage.sprite = AnimalSprites[11];
                Herb();
                break;
            case 12:
                Debug.Log("Ibex");
                AnimalName.text = "Ibex";
                AnimalImage.sprite = AnimalSprites[12];
                Herb();
                break;
            case 13:
                Debug.Log("Alpaca");
                AnimalName.text = "Alpaca";
                AnimalImage.sprite = AnimalSprites[13];
                Herb();
                break;
            case 14:
                Debug.Log("Fox");
                AnimalName.text = "Fox";
                AnimalImage.sprite = AnimalSprites[14];
                Omni();
                break;
            case 15:
                Debug.Log("Brown Bear");
                AnimalName.text = "Brown Bear";
                AnimalImage.sprite = AnimalSprites[15];
                Omni();
                break;
            case 16:
                Debug.Log("Raccoon");
                AnimalName.text = "Raccoon";
                AnimalImage.sprite = AnimalSprites[16];
                Omni();
                break;
            case 17:
                Debug.Log("Chipmunk");
                AnimalName.text = "Chipmunk";
                AnimalImage.sprite = AnimalSprites[17];
                Omni();
                break;
            case 18:
                Debug.Log("Mandarin Duck");
                AnimalName.text = "Mandarin Duck";
                AnimalImage.sprite = AnimalSprites[18];
                Omni();
                break;
            case 19:
                Debug.Log("Chimpanzee");
                AnimalName.text = "Chimpanzee";
                AnimalImage.sprite = AnimalSprites[19];
                Omni();
                break;
            case 20:
                Debug.Log("Hedgehog");
                AnimalName.text = "Hedgehog";
                AnimalImage.sprite = AnimalSprites[20];
                Omni();
                break;
            case 21:
                Debug.Log("Panda");
                AnimalName.text = "Panda";
                AnimalImage.sprite = AnimalSprites[21];
                Omni();
                break;

        }
    }

    //Herbivores can order Fruit Salad, Fruit Smoothie, Moss Burger, Bamboo Hotdog, Stick Hotdog
    //5 things
    public void Herb()
    {
        maths2 = Random.Range(0, 5);

        while (maths2 == previousmaths2)
        {
            maths2 = Random.Range(0, 5);
        }

        previousmaths2 = maths2;

        switch (maths2)
        {
            case 0:
                Debug.Log("Fruit Salad");
                OrderText.text = "Can I get a Fruit Salad please?";
                MealGuides[0].SetActive(true);
                FruitSalad = true;
                break;

            case 1:
                Debug.Log("Fruit Smoothie");
                OrderText.text = "Can I get a Fruit Smoothie please?";
                MealGuides[1].SetActive(true);
                FruitSmoothie = true;
                break;

            case 2:
                Debug.Log("Moss Burger");
                OrderText.text = "Can I get a Moss Burger please?";
                MealGuides[3].SetActive(true);
                MossBurger = true;
                break;

            case 3:
                Debug.Log("Bamboo Hotdog");
                OrderText.text = "Can I get a Bamboo Hotdog please?";
                MealGuides[4].SetActive(true);
                BambooHotdog = true;
                break;

            case 4:
                Debug.Log("Stick Hotdog");
                OrderText.text = "Can I get a Bamboo Hotdog please?";
                MealGuides[5].SetActive(true);
                StickHotdog = true;
                break;
        }
    }

    //Carnivores can order Meat Smoothie, Sausage Roll, Mouse Burger, Steak
    //4 things
    public void Carn()
    {
        maths3 = Random.Range(0, 4);

        while (maths3 == previousmaths3)
        {
            maths3 = Random.Range(0, 4);
        }

        previousmaths3 = maths3;

        switch (maths3)
        {
            case 0:
                Debug.Log("Meat Smoothie");
                OrderText.text = "Can I get a Meat Smoothie please?";
                MealGuides[6].SetActive(true);
                MeatSmoothie = true;
                break;

            case 1:
                Debug.Log("Sausage Roll");
                OrderText.text = "Can I get a Sausage Roll please?";
                MealGuides[8].SetActive(true);
                SausageRoll = true;
                break;

            case 2:
                Debug.Log("Mouse Burger");
                OrderText.text = "Can I get a Mouse Burger please?";
                MealGuides[7].SetActive(true);
                MouseBurger = true;
                break;

            case 3:
                Debug.Log("Steak");
                OrderText.text = "Can I get a Steak please?";
                MealGuides[2].SetActive(true);
                Steak = true;
                break;
        }
    }

    //Insectivores can order Ant Smoothie or Moth Biscuit
    //2 things
    public void Insect()
    {
        maths4 = Random.Range(0, 2);

        while (maths4 == previousmaths4)
        {
            maths4 = Random.Range(0, 2);
        }

        previousmaths4 = maths4;

        switch (maths4)
        {
            case 0:
                Debug.Log("Ant Smoothie");
                OrderText.text = "Can I get a Ant Smoothie please?";
                MealGuides[9].SetActive(true);
                AntSmoothie = true;
                break;

            case 1:
                Debug.Log("Moth Biscuit");
                OrderText.text = "Can I get a Moth Biscuit please?";
                MealGuides[10].SetActive(true);
                MothBiscuit = true;
                break;
        }
    }

    //Omnivores can order Fruit Salad, Fruit Smoothie, Moss Burger, Bamboo Hotdog, Stick Hotdog, Meat Smoothie, Sausage Roll, Mouse Burger, Ant Smoothie, Moth Biscuit, Steak
    //11 things
    public void Omni()
    {
        maths5 = Random.Range(0, 10);

        while (maths5 == previousmaths5)
        {
            maths5 = Random.Range(0, 10);
        }

        previousmaths5 = maths5;

        switch (maths5)
        {
            case 0:
                Debug.Log("Meat Smoothie");
                OrderText.text = "Can I get a Meat Smoothie please?";
                MealGuides[6].SetActive(true);
                MeatSmoothie = true;
                break;

            case 1:
                Debug.Log("Sausage Roll");
                OrderText.text = "Can I get a Sausage Roll please?";
                MealGuides[8].SetActive(true);
                SausageRoll = true;
                break;

            case 2:
                Debug.Log("Mouse Burger");
                OrderText.text = "Can I get a Mouse Burger please?";
                MealGuides[7].SetActive(true);
                MouseBurger = true;
                break;

            case 3:
                Debug.Log("Ant Smoothie");
                OrderText.text = "Can I get a Ant Smoothie please?";
                MealGuides[9].SetActive(true);
                AntSmoothie = true;
                break;

            case 4:
                Debug.Log("Moth Biscuit");
                OrderText.text = "Can I get a Moth Biscuit please?";
                MealGuides[10].SetActive(true);
                MothBiscuit = true;
                break;

            case 5:
                Debug.Log("Fruit Salad");
                OrderText.text = "Can I get a Fruit Salad please?";
                MealGuides[0].SetActive(true);
                FruitSalad = true;
                break;

            case 6:
                Debug.Log("Fruit Smoothie");
                OrderText.text = "Can I get a Fruit Smoothie please?";
                MealGuides[1].SetActive(true);
                FruitSmoothie = true;
                break;

            case 7:
                Debug.Log("Moss Burger");
                OrderText.text = "Can I get a Moss Burger please?";
                MealGuides[3].SetActive(true);
                MossBurger = true;
                break;

            case 8:
                Debug.Log("Bamboo Hotdog");
                OrderText.text = "Can I get a Bamboo Hotdog please?";
                MealGuides[4].SetActive(true);
                BambooHotdog = true;
                break;

            case 9:
                Debug.Log("Stick Hotdog");
                OrderText.text = "Can I get a Stick Hotdog please?";
                MealGuides[5].SetActive(true);
                StickHotdog = true;
                break;

            case 10:
                Debug.Log("Steak");
                OrderText.text = "Can I get a Steak please?";
                MealGuides[2].SetActive(true);
                Steak = true;
                break;
        }
    }

    IEnumerator Testing()
    {
        yield return new WaitForSeconds(25f);
        AnimalRandom();
    }

    IEnumerator PauseCooldown()
    {
        cooldown = true;
        yield return new WaitForSeconds(2f);
        cooldown = false;
    }
}
