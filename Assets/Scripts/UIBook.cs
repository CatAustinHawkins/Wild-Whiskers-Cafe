using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//UI book script control
public class UIBook : MonoBehaviour
{


    private IEnumerator coroutine;


    public Image IngredientsChoice;
    public Image RecipeChoice;
    public Image AnimalsChoice;
    public Image ShopChoice;
    public Image OptionsChoice;
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

    public GameObject[] OptionsPages;
    public int Ocurrentpage;

    public GameObject[] GuidePages;
    public int Gcurrentpage;

    public bool UIBookOpen;

    public GameObject[] Pages;
    public int CurrentPage;

    public GameObject IngredientsSection;
    public GameObject RecipeSection;
    public GameObject AnimalsSection;
    public GameObject ShopSection;
    public GameObject OptionsSection;
    public GameObject GuideSection;

    public bool IngredientsOpen;
    public bool RecipesOpen;
    public bool AnimalsOpen;
    public bool ShopsOpen;
    public bool OptionsOpen;
    public bool GuidesOpen;

    public bool TimerRunning;

    public Tutorial TutorialScript;

    public PlayerScript player;
    public void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) && !TimerRunning && CurrentPage > 0)
        {
            if (TutorialScript.TutorialImages == 3)
            {
                TutorialScript.NextTutorial();
            }

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

                case 5:
                    OpenOptions();
                    break;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow) && !TimerRunning && CurrentPage < 5)
        {
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

                case 5:
                    OpenOptions();
                    break;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow) && !TimerRunning)
        {
            if (TutorialScript.TutorialImages == 3)
            {
                TutorialScript.NextTutorial();
            }
            StartCoroutine(DelayTime());

            if(IngredientsOpen && Icurrentpage < 6)
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

            if (GuidesOpen && Gcurrentpage < -1)
            {
                GuidePages[Gcurrentpage].SetActive(false);
                Gcurrentpage++;
                GuidePages[Gcurrentpage].SetActive(true);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow) && !TimerRunning)
        {
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

        if(Input.GetKey(KeyCode.Escape) && UIBookOpen)
        {
            UIBookButton();
        }

        if(Input.GetKey(KeyCode.Alpha1) && !TimerRunning)
        {
            UIBookButton();
            StartCoroutine(DelayTime());
        }
    }

    //open and close the UI book
    public void UIBookButton()
    {

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
        IngredientsPages[Icurrentpage].SetActive(false);
        Icurrentpage--;
        IngredientsPages[Icurrentpage].SetActive(true);
    }

    public void RecipeNextPage()
    {
        RecipePages[Rcurrentpage].SetActive(false);
        Rcurrentpage++;
        RecipePages[Rcurrentpage].SetActive(true);
    }

    public void RecipePreviousPage()
    {
        RecipePages[Rcurrentpage].SetActive(false);
        Rcurrentpage = Rcurrentpage--;
        RecipePages[Rcurrentpage].SetActive(true);
    }

    public void AnimalNextPage()
    {
        AnimalPages[Acurrentpage].SetActive(false);
        Acurrentpage++;
        AnimalPages[Acurrentpage].SetActive(true);
    }
    public void AnimalPreviousPage()
    {
        AnimalPages[Acurrentpage].SetActive(false);
        Acurrentpage--;
        AnimalPages[Acurrentpage].SetActive(true);
    }

    public void ShopNextPage()
    {
        ShopPages[Scurrentpage].SetActive(false);
        Ocurrentpage++;
        ShopPages[Scurrentpage].SetActive(true);
    }
    public void ShopPreviousPage()
    {
        ShopPages[Scurrentpage].SetActive(false);
        Scurrentpage--;
        ShopPages[Scurrentpage].SetActive(true);
    }

    public void OptionNextPage()
    {
        OptionsPages[Ocurrentpage].SetActive(false);
        Ocurrentpage++;
        OptionsPages[Ocurrentpage].SetActive(true);
    }
    public void OptionPreviousPage()
    {
        OptionsPages[Ocurrentpage].SetActive(false);
        Ocurrentpage--;
        OptionsPages[Ocurrentpage].SetActive(true);
    }

    public void GuideNextPage()
    {
        GuidePages[Gcurrentpage].SetActive(false);
        Gcurrentpage++;
        GuidePages[Gcurrentpage].SetActive(true);
    }

    public void GuidePreviousPage()
    {
        GuidePages[Gcurrentpage].SetActive(false);
        Gcurrentpage--;
        GuidePages[Gcurrentpage].SetActive(true);
    }


    //Open each section, and change the colour of each button to reflect which section is open.
    public void OpenIngredients()
    {
        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsSection.SetActive(true);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        OptionsSection.SetActive(false);
        GuideSection.SetActive(false);

        IngredientsChoice.color = new Color32(171, 171, 171, 255);
        RecipeChoice.color = new Color32(255, 255, 255, 255);
        AnimalsChoice.color = new Color32(255, 255, 255, 255);
        ShopChoice.color = new Color32(255, 255, 255, 255);
        OptionsChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(255, 255, 255, 255);

        IngredientsOpen = true;
        RecipesOpen = false;
        AnimalsOpen = false;
        ShopsOpen = false;
        OptionsOpen = false;
        GuidesOpen = false;
    }
    public void OpenRecipes()
    {
        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(true);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        OptionsSection.SetActive(false);
        GuideSection.SetActive(false);

        RecipeChoice.color = new Color32(171, 171, 171, 255);
        IngredientsChoice.color = new Color32(255, 255, 255, 255);
        AnimalsChoice.color = new Color32(255, 255, 255, 255);
        ShopChoice.color = new Color32(255, 255, 255, 255);
        OptionsChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(255, 255, 255, 255);

        IngredientsOpen = false;
        RecipesOpen = true;
        AnimalsOpen = false;
        ShopsOpen = false;
        OptionsOpen = false;
        GuidesOpen = false;
    }

    public void OpenAnimals()
    {
        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(true);
        ShopSection.SetActive(false);
        OptionsSection.SetActive(false);
        GuideSection.SetActive(false);


        AnimalsChoice.color = new Color32(171, 171, 171, 255);
        RecipeChoice.color = new Color32(255, 255, 255, 255);
        IngredientsChoice.color = new Color32(255, 255, 255, 255);
        ShopChoice.color = new Color32(255, 255, 255, 255);
        OptionsChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(255, 255, 255, 255);

        IngredientsOpen = false;
        RecipesOpen = false;
        AnimalsOpen = true;
        ShopsOpen = false;
        OptionsOpen = false;
        GuidesOpen = false;
    }

    public void OpenShop()
    {
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
        OptionsSection.SetActive(false);
        GuideSection.SetActive(false);

        ShopChoice.color = new Color32(171, 171, 171, 255);
        RecipeChoice.color = new Color32(255, 255, 255, 255);
        AnimalsChoice.color = new Color32(255, 255, 255, 255);
        IngredientsChoice.color = new Color32(255, 255, 255, 255);
        OptionsChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(255, 255, 255, 255);

        IngredientsOpen = false;
        RecipesOpen = false;
        AnimalsOpen = false;
        ShopsOpen = true;
        OptionsOpen = false;
        GuidesOpen = false;
    }

    public void OpenOptions()
    {
        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        OptionsSection.SetActive(true);
        GuideSection.SetActive(false);

        OptionsChoice.color = new Color32(171, 171, 171, 255);
        RecipeChoice.color = new Color32(255, 255, 255, 255);
        AnimalsChoice.color = new Color32(255, 255, 255, 255);
        IngredientsChoice.color = new Color32(255, 255, 255, 255);
        ShopChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(255, 255, 255, 255);

        IngredientsOpen = false;
        RecipesOpen = false;
        AnimalsOpen = false;
        ShopsOpen = false;
        OptionsOpen = true;
        GuidesOpen = false;
    }

    public void OpenGuide()
    {
        if (TutorialScript.TutorialImages == 3)
        {
            TutorialScript.NextTutorial();
        }
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        OptionsSection.SetActive(false);
        GuideSection.SetActive(true);

        OptionsChoice.color = new Color32(255, 255, 255, 255);
        RecipeChoice.color = new Color32(255, 255, 255, 255);
        AnimalsChoice.color = new Color32(255, 255, 255, 255);
        IngredientsChoice.color = new Color32(255, 255, 255, 255);
        ShopChoice.color = new Color32(255, 255, 255, 255);
        GuideChoice.color = new Color32(171, 171, 171, 255);

        IngredientsOpen = false;
        RecipesOpen = false;
        AnimalsOpen = false;
        ShopsOpen = false;
        OptionsOpen = false;
        GuidesOpen = true;
    }

    IEnumerator DelayTime()
    {
        TimerRunning = true;
        yield return new WaitForSeconds(0.25f);
        TimerRunning = false;
    }
}
