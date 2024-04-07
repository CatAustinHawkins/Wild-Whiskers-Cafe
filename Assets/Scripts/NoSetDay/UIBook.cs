using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//UI book script control
public class UIBook : MonoBehaviour
{

    public AudioSource ButtonClick;
    public GameObject ButtonSource;

    public Image IngredientsChoice;
    public Image RecipeChoice;
    public Image AnimalsChoice;
    public Image ShopChoice;
    public Image GuideChoice;

    public GameObject UIBookImage;

    //Arrays for each UIBook page

    public GameObject[] IngredientsPages;
    public int Icurrentpage;

    public GameObject[] RecipePages;
    public int Rcurrentpage;

    public GameObject[] AnimalPages;
    public int Acurrentpage;

    public GameObject[] ShopPages;
    public int Scurrentpage;

    public GameObject[] GuidePages;
    public int Gcurrentpage;

    public bool UIBookOpen;

    public GameObject[] Pages;
    public int CurrentPage;

    public GameObject IngredientsSection;
    public GameObject RecipeSection;
    public GameObject AnimalsSection;
    public GameObject ShopSection;
    public GameObject GuideSection;

    public bool IngredientsOpen;
    public bool RecipesOpen;
    public bool AnimalsOpen;
    public bool ShopsOpen;
    public bool GuidesOpen;

    public bool TimerRunning;

    public Tutorial TutorialScript;

    public PlayerScript player;

    public void Start()
    {
        ButtonSource = GameObject.FindWithTag("ButtonSound");
        ButtonClick = ButtonSource.GetComponent<AudioSource>();
    }
    public void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) && !TimerRunning && CurrentPage > 0)
        {
            if (TutorialScript.TutorialImages == 3)
            {
                TutorialScript.NextTutorial();
            }
            ButtonClick.Play();

            StartCoroutine(DelayTime());

            CurrentPage--;

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

        if (Input.GetKey(KeyCode.DownArrow) && !TimerRunning && CurrentPage < 5)
        {
            ButtonClick.Play();

            if (TutorialScript.TutorialImages == 3)
            {
                TutorialScript.NextTutorial();
            }
            StartCoroutine(DelayTime());

            CurrentPage++;

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

        if (Input.GetKey(KeyCode.RightArrow) && !TimerRunning)
        {
            ButtonClick.Play();

            if (TutorialScript.TutorialImages == 3)
            {
                TutorialScript.NextTutorial();
            }
            StartCoroutine(DelayTime());

            if(IngredientsOpen && Icurrentpage < 3)
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

        if (Input.GetKey(KeyCode.LeftArrow) && !TimerRunning)
        {
            ButtonClick.Play();

            if (TutorialScript.TutorialImages == 3)
            {
                TutorialScript.NextTutorial();
            }
            StartCoroutine(DelayTime());

            if(IngredientsOpen && Icurrentpage > 0)
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
            ButtonClick.Play();

            UIBookButton();
            StartCoroutine(DelayTime());
        }
    }

    //open and close the UI book
    public void UIBookButton()
    {
        ButtonClick.Play();

        player.target = player.transform.position;
        if(TutorialScript.TutorialImages == 2 || TutorialScript.TutorialImages == 6)
        {
            TutorialScript.NextTutorial();
        }

        if(!UIBookOpen)
        {
            UIBookImage.SetActive(true);
            UIBookOpen = true;
        }
        else
        {
            UIBookImage.SetActive(false);
            UIBookOpen = false;
        }
    }

    //Switch UI book pages
    public void IngredientsNextPage()
    {
        ButtonClick.Play();

        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsPages[Icurrentpage].SetActive(false);
        Icurrentpage++;
        IngredientsPages[Icurrentpage].SetActive(true);
    }

    public void IngredientsPreviousPage()
    {
        ButtonClick.Play();

        IngredientsPages[Icurrentpage].SetActive(false);
        Icurrentpage--;
        IngredientsPages[Icurrentpage].SetActive(true);
    }

    public void RecipeNextPage()
    {
        ButtonClick.Play();

        RecipePages[Rcurrentpage].SetActive(false);
        Rcurrentpage++;
        RecipePages[Rcurrentpage].SetActive(true);
    }

    public void RecipePreviousPage()
    {
        ButtonClick.Play();

        RecipePages[Rcurrentpage].SetActive(false);
        Rcurrentpage = Rcurrentpage--;
        RecipePages[Rcurrentpage].SetActive(true);
    }

    public void AnimalNextPage()
    {
        ButtonClick.Play();

        AnimalPages[Acurrentpage].SetActive(false);
        Acurrentpage++;
        AnimalPages[Acurrentpage].SetActive(true);
    }
    public void AnimalPreviousPage()
    {
        ButtonClick.Play();

        AnimalPages[Acurrentpage].SetActive(false);
        Acurrentpage--;
        AnimalPages[Acurrentpage].SetActive(true);
    }

    public void ShopNextPage()
    {
        ButtonClick.Play();

        ShopPages[Scurrentpage].SetActive(false);
        Scurrentpage++;
        ShopPages[Scurrentpage].SetActive(true);
    }
    public void ShopPreviousPage()
    {
        ButtonClick.Play();

        ShopPages[Scurrentpage].SetActive(false);
        Scurrentpage--;
        ShopPages[Scurrentpage].SetActive(true);
    }

    public void GuideNextPage()
    {
        ButtonClick.Play();

        GuidePages[Gcurrentpage].SetActive(false);
        Gcurrentpage++;
        GuidePages[Gcurrentpage].SetActive(true);
    }

    public void GuidePreviousPage()
    {
        ButtonClick.Play();

        GuidePages[Gcurrentpage].SetActive(false);
        Gcurrentpage--;
        GuidePages[Gcurrentpage].SetActive(true);
    }


    //Open each section, and change the colour of each button to reflect which section is open.
    public void OpenIngredients()
    {
        ButtonClick.Play();

        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsSection.SetActive(true);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        GuideSection.SetActive(false);

        IngredientsChoice.color = new Color32(171, 171, 171, 255);
        RecipeChoice.color = new Color32(255, 255, 255, 255);
        AnimalsChoice.color = new Color32(255, 255, 255, 255);
        ShopChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(255, 255, 255, 255);

        IngredientsOpen = true;
        RecipesOpen = false;
        AnimalsOpen = false;
        ShopsOpen = false;
        GuidesOpen = false;
    }
    public void OpenRecipes()
    {
        ButtonClick.Play();

        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(true);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        GuideSection.SetActive(false);

        RecipeChoice.color = new Color32(171, 171, 171, 255);
        IngredientsChoice.color = new Color32(255, 255, 255, 255);
        AnimalsChoice.color = new Color32(255, 255, 255, 255);
        ShopChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(255, 255, 255, 255);

        IngredientsOpen = false;
        RecipesOpen = true;
        AnimalsOpen = false;
        ShopsOpen = false;
        GuidesOpen = false;
    }

    public void OpenAnimals()
    {
        ButtonClick.Play();

        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(true);
        ShopSection.SetActive(false);
        GuideSection.SetActive(false);


        AnimalsChoice.color = new Color32(171, 171, 171, 255);
        RecipeChoice.color = new Color32(255, 255, 255, 255);
        IngredientsChoice.color = new Color32(255, 255, 255, 255);
        ShopChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(255, 255, 255, 255);

        IngredientsOpen = false;
        RecipesOpen = false;
        AnimalsOpen = true;
        ShopsOpen = false;
        GuidesOpen = false;
    }

    public void OpenShop()
    {
        ButtonClick.Play();

        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }

        if (TutorialScript.TutorialImages == 4)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(true);
        GuideSection.SetActive(false);

        ShopChoice.color = new Color32(171, 171, 171, 255);
        RecipeChoice.color = new Color32(255, 255, 255, 255);
        AnimalsChoice.color = new Color32(255, 255, 255, 255);
        IngredientsChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(255, 255, 255, 255);

        IngredientsOpen = false;
        RecipesOpen = false;
        AnimalsOpen = false;
        ShopsOpen = true;
        GuidesOpen = false;
    }

    public void OpenGuide()
    {
        ButtonClick.Play();

        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        GuideSection.SetActive(true);

        RecipeChoice.color = new Color32(255, 255, 255, 255);
        AnimalsChoice.color = new Color32(255, 255, 255, 255);
        IngredientsChoice.color = new Color32(255, 255, 255, 255);
        ShopChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(171, 171, 171, 255);

        IngredientsOpen = false;
        RecipesOpen = false;
        AnimalsOpen = false;
        ShopsOpen = false;
        GuidesOpen = true;
    }

    IEnumerator DelayTime()
    {
        TimerRunning = true;
        yield return new WaitForSeconds(0.25f);
        TimerRunning = false;
    }
}
