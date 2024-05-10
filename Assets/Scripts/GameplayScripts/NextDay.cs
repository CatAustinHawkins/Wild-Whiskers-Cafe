using UnityEngine;
using TMPro;
using UnityEngine.UI;

/// <summary>
/// Script that controls when the next day starts
/// Spawns the relevant animal
/// Enables a new table, if on Day1, Day3 or Day5.
/// </summary>

public class NextDay : MonoBehaviour
{
    public TextMeshProUGUI HappinessText; //the text above the happiness bar

    public GameObject Table2GameObject; //table 2, spawns on day 1
    public GameObject Table3GameObject; //table 3, spawns on day 3
    public GameObject Table4GameObject; //table 4, spawns on day 5

    public GameObject AdderCustomer; //the adder customer from day 1
    public GameObject PonyCustomer; //the pony customer from day 2 
    public GameObject FerretCustomer; //the ferret customer from day 3
    public GameObject GemsbokCustomer; //the gemsbok customer from day 4
    public GameObject PlatypusCustomer; //the platypus customer from day 5

    public GameObject TutorialOverlay; //tutorial overlay at the end of the tutorial
    public GameObject Day1EndOverlay; //overlay at the end of day 1
    public GameObject Day2EndOverlay; //overlay at the end of day 2
    public GameObject Day3EndOverlay; //overlay at the end of day 3
    public GameObject Day4EndOverlay; //overlay at the end of day 4

    public Dialogue DialogueScript; //the dialogue script

    public GameObject TutorialPrompts; //the tutorial prompts

    public Interact InteractScript;

    public Slider HappinessBar; //the happiness bar

    public void StartDay1() //when day 1 starts
    {
        Table2GameObject.SetActive(true); //enable the second table

        AdderCustomer.SetActive(true); //enable the adder customer

        TutorialPrompts.SetActive(false); //hide the tutorial prompts, incase player didn't finish
        TutorialOverlay.SetActive(false); //hide the end of tutorial overlay

        DialogueScript.PandaMeal1 = false; //disable previous dialogue script meal, just in case
        DialogueScript.AdderMeal = true; //enable next dialogue script meal

        HappinessText.text = "Day 1"; //change the happiness text
        HappinessBar.value = 1; //reset the happiness value

        InteractScript.Day1 = true;
        InteractScript.DayEnd = false;
    }

    public void StartDay2() //when day 2 starts
    {
        PonyCustomer.SetActive(true); //enable the pony customer

        Day1EndOverlay.SetActive(false); //hide the end of day 1 overlay
        TutorialOverlay.SetActive(false); //hide the end of tutorial overlay

        DialogueScript.LeopardMeal = false; //disable previous dialogue script meal, just in case
        DialogueScript.PonyDrink = true; //enable next dialogue script meal

        HappinessText.text = "Day 2"; //change the happiness text
        HappinessBar.value = 1; //reset the happiness value

        InteractScript.Day2 = true;
        InteractScript.Day1 = false;
    }

    public void StartDay3() //when day 3 starts
    {
        Table3GameObject.SetActive(true); //enable the third table

        FerretCustomer.SetActive(true); //enable the ferret customer

        Day1EndOverlay.SetActive(false); //hide the end of day 1 overlay
        TutorialOverlay.SetActive(false); //hide the end of tutorial overlay
        Day2EndOverlay.SetActive(false); //hide the end of day 2 overlay

        DialogueScript.GiraffeMeal = false; //disable previous dialogue script meal, just in case
        DialogueScript.FerretMeal = true; //enable next dialogue script meal

        HappinessText.text = "Day 3"; //change the happiness text
        HappinessBar.value = 1; //reset the happiness value
        InteractScript.Day3 = true;
        InteractScript.Day2 = false;
    }

    public void StartDay4() //when day 4 starts
    {

        GemsbokCustomer.SetActive(true); //enable the gemsbok customer

        Day1EndOverlay.SetActive(false); //hide the end of day 1 overlay
        TutorialOverlay.SetActive(false); //hide the end of tutorial overlay
        Day2EndOverlay.SetActive(false); //hide the end of day 2 overlay
        Day3EndOverlay.SetActive(false); //hide the end of day 3 overlay

        DialogueScript.BeaverMeal = false; //disable previous dialogue script meal, just in case
        DialogueScript.GemsbokDrink = true; //enable next dialogue script meal

        HappinessText.text = "Day 4"; //change the happiness text
        HappinessBar.value = 1; //reset the happiness value
        InteractScript.Day4 = true;
        InteractScript.Day3 = false;
    }

    public void StartDay5() //when day 5 starts
    {
        Table4GameObject.SetActive(true); //enable the fourth table

        PlatypusCustomer.SetActive(true); //enable the platypus customer

        Day1EndOverlay.SetActive(false); //hide the end of day 1 overlay
        TutorialOverlay.SetActive(false); //hide the end of tutorial overlay
        Day2EndOverlay.SetActive(false); //hide the end of day 2 overlay
        Day3EndOverlay.SetActive(false); //hide the end of day 3 overlay
        Day4EndOverlay.SetActive(false); //hide the end of day 4 overlay

        DialogueScript.ChipmunkMeal = false; //disable previous dialogue script meal, just in case
        DialogueScript.PlatypusMeal = true; //enable next dialogue script meal

        HappinessText.text = "Day 5"; //change the happiness text
        HappinessBar.value = 1; //reset the happiness value

        InteractScript.Day5 = true;
        InteractScript.Day4 = false;
    }
}
