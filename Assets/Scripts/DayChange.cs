using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DayChange : MonoBehaviour
{

    //Functions for each day 
    //enable ingredient visible
    //update animal page
    //update recipe page

    //in the book - animals
    public Image[] AnimalsBook;
    public Image[] MealsBook;
    public Image[] DrinksBook;

    //in the book - recipes
    public GameObject[] LockedRecipesBook;

    //in the fridge
    public GameObject[] LockedIngredientsFridge; //destroy locked
    public GameObject[] UnlockedIngredientsFridge; //show unlocked

    public GameObject[] LITextFridge; //destroy locked
    public GameObject[] UITextFridge; //show unlocked
     
    //in the book - animals
    public TextMeshProUGUI[] AnimalName;
    public TextMeshProUGUI[] AnimalDiet;

    public void Start()
    {
        Day2();
    }

    public void Day2()
    {
        //Shetland Pony and Hay Patties
        AnimalsBook[0].color = (Color.white);
        MealsBook[0].color = (Color.white);

        //Hay Patties
        Destroy(LockedRecipesBook[0]);

        //Hay
        Destroy(LockedIngredientsFridge[0]);
        Destroy(LITextFridge[0]);

        UnlockedIngredientsFridge[0].SetActive(true);
        UITextFridge[0].SetActive(true);

        //Flour
        Destroy(LockedIngredientsFridge[1]);
        Destroy(LITextFridge[1]);

        UnlockedIngredientsFridge[1].SetActive(true);
        UITextFridge[1].SetActive(true);

        AnimalName[0].text = "Shetland Pony";
        AnimalDiet[0].text = "Herbivore";
    }

    public void Day3() //LesserHorseshoeBat Unlocked and Moth and Moth Biscuits unlocked
    {
        //Lesser Horseshoe Bat and Moth Biscuits
        AnimalsBook[0].color = (Color.white);
        MealsBook[0].color = (Color.white);

        //Hay Patties
        Destroy(LockedRecipesBook[0]);

        //Hay
        Destroy(LockedIngredientsFridge[0]);
        Destroy(LITextFridge[0]);

        UnlockedIngredientsFridge[0].SetActive(true);
        UITextFridge[0].SetActive(true);

        //Flour
        Destroy(LockedIngredientsFridge[1]);
        Destroy(LITextFridge[1]);

        UnlockedIngredientsFridge[1].SetActive(true);
        UITextFridge[1].SetActive(true);

        AnimalName[0].text = "Shetland Pony";
        AnimalDiet[0].text = "Herbivore";
    }

    public void Day4() //Panda Unlocked and Bamboo and Bread / Bamboo Hotdog unlocked
    {

    }

    public void Day5() //Adder Unlocked and Mouse Burger unlocked
    {

    }

    public void Day6() //Giraffe Unlocked and Leaf and Pastry / Leaf Crunch unlocked
    {

    }

    public void Day7() //Hedgehog Unlocked and Worm and Pasta and Tomato / Worm Spaghetti unlocked
    {

    }

    public void Day8() //Bobcat Unlocked and Sausage and Spices / SausageRoll unlocked
    {

    }

    public void Day9() //RedKangaroo Unlocked and Moss / Moss Burger unlocked
    {

    }

    public void Day10() //Chimpanzeee Unlocked and Fruit and Apple / Fruit Salad and Fruit Smoothie unlocked
    {

    }

    public void Day11() //Platypus Unlocked and Crayfish / Crayfish Tempura unlocked
    {

    }

    public void Day12() //Ibex Unlocked and Leaf Salad unlocked
    {

    }

    public void Day13() //Brown Bear Unlocked and Salmon unlocked
    {

    }

    public void Day14() //Pangolin Unlocked and Ant / Ant Spaghetti and Ant Smoothie unlocked
    {

    }

    public void Day15() //Beaver Unlocked and Stick / Stick Hotdog unlocked
    {

    }

    public void Day16() //Mandarin Duck Unlocked and Snails / Escargot unlocked
    {

    }

    public void Day17() //Gemsbok Unlocked and Melon / Poached Melon and Melon Smoothie unlocked
    {

    }

    public void Day18() //Chipmunk Unlocked and Mushrooms / Roasted Mushrooms unlocked
    {

    }

    public void Day19() //Alpaca Unlocked and Hay Salad unlocked
    {

    }

    public void Day20() //Raccoon Unlocked and Clams / Clam Soup unlocked
    {

    }

    public void Day21() //Ferret Unlocked and Bones / Bone Broth unlocked
    {

    }

    public void Day22() //Fox Unlocked and Kebab unlocked
    {

    }
}
