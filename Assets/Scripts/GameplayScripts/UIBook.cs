using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//UI book script control, occasionally referred to as Cookbook
public class UIBook : MonoBehaviour
{
    public AudioSource ButtonClick; //button click sound effect
    public GameObject ButtonSource; //gameobject that stores the button click sound

    public Image IngredientsChoice; //ingredients button
    public Image RecipeChoice; //recipe button
    public Image AnimalsChoice; //animals button
    public Image ShopChoice; //shop button
    public Image GuideChoice; //guide button

    public GameObject UIBookImage; //the UI book gameobject

    //Arrays for each UIBook page

    public GameObject[] IngredientsPages; //an array of the ingredient pages
    public int Icurrentpage; //the current ingredients page open

    public GameObject[] RecipePages; //an array of the recipe pages
    public int Rcurrentpage; //the current recipe page open

    public GameObject[] AnimalPages; //an array of the animal pages
    public int Acurrentpage; //the current animal page open

    public GameObject[] ShopPages; //an array of the shop pages
    public int Scurrentpage; //the current shop page open

    public GameObject[] GuidePages; //an array of the guide pages
    public int Gcurrentpage; //the current guide page open

    public bool UIBookOpen; //is the ui book open

    public GameObject[] Pages; //an array of all the page headings 
    public int CurrentPage; //the current page open

    public GameObject IngredientsSection; //ingredients page
    public GameObject RecipeSection; //recipe page
    public GameObject AnimalsSection; //animals page
    public GameObject ShopSection; //shop page
    public GameObject GuideSection; //guide page
    
    public bool IngredientsOpen; //is the ingredients page open 
    public bool RecipesOpen;  //is the recipes page open 
    public bool AnimalsOpen; //is the animals page open 
    public bool ShopsOpen; //is the shops page open 
    public bool GuidesOpen; //is the guides page open 

    public bool TimerRunning; //timer running bool

    public Tutorial TutorialScript; //tutorial script access

    public void Start()
    {
        ButtonSource = GameObject.FindWithTag("ButtonSound"); //locate buttonsource gameobject
        ButtonClick = ButtonSource.GetComponent<AudioSource>(); //locate audio source component 
    }
    public void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) && !TimerRunning && CurrentPage > 0) //if the player presses the up arrow, the timer isnt running, and the current page is more than 0 
        {
            if (TutorialScript.TutorialImages == 3)//if current tutorial prompt is 3
            {
                TutorialScript.NextTutorial(); //show the next tutorial
            }
            ButtonClick.Play();//play button click noise

            StartCoroutine(DelayTime()); //start the delay time coroutine

            CurrentPage--;

            //the player is going Up a page 
            switch (CurrentPage)
            {
                case 0: 
                    OpenIngredients();
                    break;

                case 1: 
                    OpenRecipes();
                    break;

                case 2:
                    OpenAnimals();
                    break;

                case 3:
                    OpenShop();
                    break;

                case 4:
                    OpenGuide();
                    break;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow) && !TimerRunning && CurrentPage < 5)//if the player presses the down arrow, the timer isnt running, and the current page is less than 5
        {
            ButtonClick.Play();//play button click noise

            if (TutorialScript.TutorialImages == 3)//if current tutorial prompt is 3
            {
                TutorialScript.NextTutorial(); //show the next tutorial
            }
            StartCoroutine(DelayTime()); //start the delay time coroutine

            CurrentPage++;

            //the player is going Down a page
            switch (CurrentPage)
            {
                case 0:
                    OpenIngredients();
                    break;

                case 1:
                    OpenRecipes();
                    break;

                case 2:
                    OpenAnimals();
                    break;

                case 3:
                    OpenShop();
                    break;

                case 4:
                    OpenGuide();
                    break;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow) && !TimerRunning) //if the player presses the right arrow, and the timer isnt running
        {
            //opens the next page, if possible

            ButtonClick.Play();//play button click noise

            if (TutorialScript.TutorialImages == 3)//if current tutorial prompt is 3
            {
                TutorialScript.NextTutorial(); //show the next tutorial
            }
            StartCoroutine(DelayTime()); //start the delay time coroutine

            //check whether they can open the next page
            if (IngredientsOpen && Icurrentpage < 3)
            {
                IngredientsPages[Icurrentpage].SetActive(false);
                Icurrentpage++;
                IngredientsPages[Icurrentpage].SetActive(true);
            }

            if (RecipesOpen && Rcurrentpage < 2)
            {
                RecipePages[Rcurrentpage].SetActive(false);
                Rcurrentpage++;
                RecipePages[Rcurrentpage].SetActive(true);
            }

            if (AnimalsOpen && Acurrentpage < 9)
            {
                AnimalPages[Acurrentpage].SetActive(false);
                Acurrentpage++;
                AnimalPages[Acurrentpage].SetActive(true);
            }

            if (ShopsOpen && Scurrentpage < 1)
            {
                ShopPages[Scurrentpage].SetActive(false);
                Scurrentpage++;
                ShopPages[Scurrentpage].SetActive(true);
            }

            if (GuidesOpen && Gcurrentpage < 2)
            {
                GuidePages[Gcurrentpage].SetActive(false);
                Gcurrentpage++;
                GuidePages[Gcurrentpage].SetActive(true);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow) && !TimerRunning) //if the player presses the left arrow, and the timer isnt running
        {
            //opens the previous page, if possible

            ButtonClick.Play();//play button click noise

            if (TutorialScript.TutorialImages == 3)//if current tutorial prompt is 3
            {
                TutorialScript.NextTutorial(); //show the next tutorial
            }
            StartCoroutine(DelayTime()); //start the delay time coroutine

            //check whether they can open the previous page

            if (IngredientsOpen && Icurrentpage > 0)
            {
                IngredientsPages[Icurrentpage].SetActive(false);
                Icurrentpage--;
                IngredientsPages[Icurrentpage].SetActive(true);
            }

            if (RecipesOpen && Rcurrentpage > 0)
            {
                RecipePages[Rcurrentpage].SetActive(false);
                Rcurrentpage--;
                RecipePages[Rcurrentpage].SetActive(true);
            }

            if (AnimalsOpen && Acurrentpage > 0)
            {
                AnimalPages[Acurrentpage].SetActive(false);
                Acurrentpage--;
                AnimalPages[Acurrentpage].SetActive(true);
            }

            if (ShopsOpen && Scurrentpage > 0)
            {
                ShopPages[Scurrentpage].SetActive(false);
                Scurrentpage--;
                ShopPages[Scurrentpage].SetActive(true);
            }

            if (GuidesOpen && Gcurrentpage > 0)
            {
                GuidePages[Gcurrentpage].SetActive(false);
                Gcurrentpage--;
                GuidePages[Gcurrentpage].SetActive(true);
            }
        }

        if(Input.GetKey(KeyCode.Q) && !TimerRunning)
        {
            ButtonClick.Play();//play button click noise

            UIBookButton();
            StartCoroutine(DelayTime()); //start the delay time coroutine
        }
    }

    //open and close the UI book
    public void UIBookButton()
    {
        ButtonClick.Play();//play button click noise

        if(TutorialScript.TutorialImages == 2 || TutorialScript.TutorialImages == 6)//if current tutorial prompt is 2 or 6
        {
            TutorialScript.NextTutorial(); //show the next tutorial
        }

        if(!UIBookOpen) //if the book isnt open
        {
            UIBookImage.SetActive(true); //enable the book object
            UIBookOpen = true; //set the book open to true
        }
        else //if it is open
        {
            UIBookImage.SetActive(false); //disable the book object
            UIBookOpen = false; //set the book open to false
        }
    }

    //Switch UI book pages - each function is on an arrow key gameobject on the book UI
    public void IngredientsNextPage()
    {
        ButtonClick.Play();//play button click noise

        if (TutorialScript.TutorialImages == 3)//if current tutorial prompt is 3
        {
            TutorialScript.NextTutorial(); //show the next tutorial
        }

        IngredientsPages[Icurrentpage].SetActive(false);
        Icurrentpage++;
        IngredientsPages[Icurrentpage].SetActive(true);
    }

    public void IngredientsPreviousPage()
    {
        ButtonClick.Play();//play button click noise

        IngredientsPages[Icurrentpage].SetActive(false);
        Icurrentpage--;
        IngredientsPages[Icurrentpage].SetActive(true);
    }

    public void RecipeNextPage()
    {
        ButtonClick.Play();//play button click noise

        RecipePages[Rcurrentpage].SetActive(false);
        Rcurrentpage++;
        RecipePages[Rcurrentpage].SetActive(true);
    }

    public void RecipePreviousPage()
    {
        ButtonClick.Play();//play button click noise

        RecipePages[Rcurrentpage].SetActive(false);
        Rcurrentpage--;
        RecipePages[Rcurrentpage].SetActive(true);
    }

    public void AnimalNextPage()
    {
        ButtonClick.Play();//play button click noise

        AnimalPages[Acurrentpage].SetActive(false);
        Acurrentpage++;
        AnimalPages[Acurrentpage].SetActive(true);
    }
    public void AnimalPreviousPage()
    {
        ButtonClick.Play();//play button click noise

        AnimalPages[Acurrentpage].SetActive(false);
        Acurrentpage--;
        AnimalPages[Acurrentpage].SetActive(true);
    }

    public void ShopNextPage()
    {
        ButtonClick.Play();//play button click noise

        ShopPages[Scurrentpage].SetActive(false);
        Scurrentpage++;
        ShopPages[Scurrentpage].SetActive(true);
    }
    public void ShopPreviousPage()
    {
        ButtonClick.Play();//play button click noise

        ShopPages[Scurrentpage].SetActive(false);
        Scurrentpage--;
        ShopPages[Scurrentpage].SetActive(true);
    }

    public void GuideNextPage()
    {
        ButtonClick.Play();//play button click noise

        GuidePages[Gcurrentpage].SetActive(false);
        Gcurrentpage++;
        GuidePages[Gcurrentpage].SetActive(true);
    }

    public void GuidePreviousPage()
    {
        ButtonClick.Play();//play button click noise

        GuidePages[Gcurrentpage].SetActive(false);
        Gcurrentpage--;
        GuidePages[Gcurrentpage].SetActive(true);
    }


    //Open each section, and change the colour of each button to reflect which section is open.
    public void OpenIngredients()
    {
        ButtonClick.Play();//play button click noise

        if (TutorialScript.TutorialImages == 3)//if current tutorial prompt is 3
        {
            TutorialScript.NextTutorial(); //show the next tutorial
        }

        IngredientsSection.SetActive(true); //enable the ingredients section
        RecipeSection.SetActive(false); //disable others
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        GuideSection.SetActive(false);

        IngredientsChoice.color = new Color32(171, 171, 171, 255); //change the ingredients button colour, to show it is selected
        RecipeChoice.color = Color.white; //set the others to white
        AnimalsChoice.color = Color.white;
        ShopChoice.color = Color.white;
        GuideChoice.color = Color.white;

        IngredientsOpen = true;
        RecipesOpen = false;
        AnimalsOpen = false;
        ShopsOpen = false;
        GuidesOpen = false;
    }
    public void OpenRecipes()
    {
        ButtonClick.Play();//play button click noise

        if (TutorialScript.TutorialImages == 3)//if current tutorial prompt is 3
        {
            TutorialScript.NextTutorial(); //show the next tutorial
        }

        RecipeSection.SetActive(true); //enable the recipe section
        IngredientsSection.SetActive(false); //disable others
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        GuideSection.SetActive(false);

        RecipeChoice.color = new Color32(171, 171, 171, 255); //change the ingredients button colour, to show it is selected
        IngredientsChoice.color = Color.white; //set the others to white
        AnimalsChoice.color = Color.white;
        ShopChoice.color = Color.white;
        GuideChoice.color = Color.white;

        RecipesOpen = true;
        IngredientsOpen = false;
        AnimalsOpen = false;
        ShopsOpen = false;
        GuidesOpen = false;
    }

    public void OpenAnimals()
    {
        ButtonClick.Play();//play button click noise

        if (TutorialScript.TutorialImages == 3)//if current tutorial prompt is 3
        {
            TutorialScript.NextTutorial(); //show the next tutorial
        }

        AnimalsSection.SetActive(true); //enable the animals section
        IngredientsSection.SetActive(false); //disable others
        RecipeSection.SetActive(false);
        ShopSection.SetActive(false);
        GuideSection.SetActive(false);


        AnimalsChoice.color = new Color32(171, 171, 171, 255); //change the ingredients button colour, to show it is selected
        RecipeChoice.color = Color.white; //set the others to white
        IngredientsChoice.color = Color.white;
        ShopChoice.color = Color.white;
        GuideChoice.color = Color.white;

        AnimalsOpen = true;
        IngredientsOpen = false;
        RecipesOpen = false;
        ShopsOpen = false;
        GuidesOpen = false;
    }

    public void OpenShop()
    {
        ButtonClick.Play();//play button click noise

        if (TutorialScript.TutorialImages == 3)//if current tutorial prompt is 3
        {
            TutorialScript.NextTutorial(); //show the next tutorial
        }

        if (TutorialScript.TutorialImages == 4)//if current tutorial prompt is 4
        {
            TutorialScript.NextTutorial(); //show the next tutorial
        }

        ShopSection.SetActive(true); //enable the shop section
        IngredientsSection.SetActive(false); //disable others
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        GuideSection.SetActive(false);

        ShopChoice.color = new Color32(171, 171, 171, 255); //change the ingredients button colour, to show it is selected
        RecipeChoice.color = Color.white; //set the others to white
        AnimalsChoice.color = Color.white;
        IngredientsChoice.color = Color.white;
        GuideChoice.color = Color.white;
      
        ShopsOpen = true;
        IngredientsOpen = false;
        RecipesOpen = false;
        AnimalsOpen = false;
        GuidesOpen = false;
    }

    public void OpenGuide()
    {
        ButtonClick.Play();//play button click noise

        if (TutorialScript.TutorialImages == 3)//if current tutorial prompt is 3
        {
            TutorialScript.NextTutorial(); //show the next tutorial
        }

        GuideSection.SetActive(true); //enable the guide section
        IngredientsSection.SetActive(false); //disable others
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);

        GuideChoice.color = new Color32(171, 171, 171, 255); //change the ingredients button colour, to show it is selected
        RecipeChoice.color = Color.white; //set the others to white
        AnimalsChoice.color = Color.white;
        IngredientsChoice.color = Color.white;
        ShopChoice.color = Color.white;

        GuidesOpen = true;
        IngredientsOpen = false;
        RecipesOpen = false;
        AnimalsOpen = false;
        ShopsOpen = false;
    }

    IEnumerator DelayTime() //this coroutine is to prevent glitches when the player opens the cookbook
    {
        TimerRunning = true; //timer running is true
        yield return new WaitForSeconds(0.25f); //wait 0.25 seconds
        TimerRunning = false; //timer running is false
    }
}
