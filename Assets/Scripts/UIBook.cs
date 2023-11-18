using UnityEngine;

public class UIBook : MonoBehaviour
{

    public GameObject UIBookImage;

    public GameObject[] IngredientsPages;
    public int Icurrentpage;
    public int Ipreviouspage;

    public GameObject[] RecipePages;
    public int Rcurrentpage;
    public int Rpreviouspage;

    public GameObject[] AnimalPages;
    public int Acurrentpage;
    public int Apreviouspage;

    public GameObject[] ShopPages;
    public int Scurrentpage;
    public int Spreviouspage;

    public GameObject[] OptionsPages;
    public int Ocurrentpage;
    public int Opreviouspage;

    public bool UIBookOpen;

    public GameObject IngredientsSection;
    public GameObject RecipeSection;
    public GameObject AnimalsSection;
    public GameObject ShopSection;
    public GameObject OptionsSection;

    public void UIBookButton()
    {
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

    public void IngredientsNextPage()
    {
        IngredientsPages[0].SetActive(false);
        Icurrentpage++;
        IngredientsPages[1].SetActive(true);
    }

    public void IngredientsPreviousPage()
    {
        IngredientsPages[Icurrentpage].SetActive(false);
        Ipreviouspage = Icurrentpage - 1;
        IngredientsPages[Ipreviouspage].SetActive(true);
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
        Rpreviouspage = Rcurrentpage--;
        RecipePages[Rpreviouspage].SetActive(true);
    }

    public void AnimalNextPage()
    {
        AnimalPages[0].SetActive(false);
        Acurrentpage++;
        AnimalPages[1].SetActive(true);
    }
    public void AnimalPreviousPage()
    {
        AnimalPages[Acurrentpage].SetActive(false);
        Apreviouspage = Acurrentpage--;
        AnimalPages[Apreviouspage].SetActive(true);
    }

    public void ShopNextPage()
    {
        OptionsPages[0].SetActive(false);
        Ocurrentpage++;
        OptionsPages[1].SetActive(true);
    }
    public void ShopPreviousPage()
    {
        ShopPages[Scurrentpage].SetActive(false);
        Spreviouspage = Scurrentpage--;
        ShopPages[Spreviouspage].SetActive(true);
    }

    public void OptionNextPage()
    {
        OptionsPages[0].SetActive(false);
        Ocurrentpage++;
        OptionsPages[1].SetActive(true);
    }
    public void OptionPreviousPage()
    {
        OptionsPages[Ocurrentpage].SetActive(false);
        Opreviouspage = Ocurrentpage--;
        OptionsPages[Opreviouspage].SetActive(true);
    }

    public void OpenIngredients()
    {
        IngredientsSection.SetActive(true);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        OptionsSection.SetActive(false);
    }
    public void OpenRecipes()
    {
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(true);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        OptionsSection.SetActive(false);
    }

    public void OpenAnimals()
    {
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(true);
        ShopSection.SetActive(false);
        OptionsSection.SetActive(false);
    }

    public void OpenShop()
    {
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(true);
        OptionsSection.SetActive(false);
    }

    public void OpenOptions()
    {
        IngredientsSection.SetActive(false);
        RecipeSection.SetActive(false);
        AnimalsSection.SetActive(false);
        ShopSection.SetActive(false);
        OptionsSection.SetActive(true);
    }
}
