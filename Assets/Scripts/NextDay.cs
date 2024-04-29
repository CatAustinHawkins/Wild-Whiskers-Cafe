using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

/// <summary>
/// Script that controls when the next day starts
/// Spawns the relevant animal
/// Enables a new table, if on Day1, Day3 or Day5.
/// </summary>

public class NextDay : MonoBehaviour
{
    public TextMeshProUGUI HappinessText;

    public GameObject Table2GameObject;
    public GameObject Table3GameObject;
    public GameObject Table4GameObject;

    public GameObject AdderCustomer;
    public GameObject PonyCustomer;
    public GameObject FerretCustomer;
    public GameObject GemsbokCustomer;
    public GameObject PlatypusCustomer;

    public GameObject TutorialOverlay;
    public GameObject Day1EndOverlay;
    public GameObject Day2EndOverlay;
    public GameObject Day3EndOverlay;
    public GameObject Day4EndOverlay;

    public Dialogue DialogueScript;

    public void StartDay1()
    {
        Table2GameObject.SetActive(true);
        AdderCustomer.SetActive(true);
        TutorialOverlay.SetActive(false);
        HappinessText.text = "Day 1";
        DialogueScript.PandaDrink1 = false;
        DialogueScript.PandaMeal1 = false;
        DialogueScript.AdderMeal = true;
    }

    public void StartDay2()
    {
        PonyCustomer.SetActive(true);
        Day1EndOverlay.SetActive(false);
        HappinessText.text = "Day 2";
        DialogueScript.LeopardDrink = false;
        DialogueScript.LeopardMeal = false;
        DialogueScript.PonyDrink = true;

    }

    public void StartDay3()
    {
        Table3GameObject.SetActive(true);
        FerretCustomer.SetActive(true);
        Day2EndOverlay.SetActive(false);
        HappinessText.text = "Day 3";

    }

    public void StartDay4()
    {
        GemsbokCustomer.SetActive(true);
        Day3EndOverlay.SetActive(false);
        HappinessText.text = "Day 4";

    }

    public void StartDay5()
    {
        Table4GameObject.SetActive(true);
        PlatypusCustomer.SetActive(true);
        Day4EndOverlay.SetActive(false);
        HappinessText.text = "Day 5";

    }

}
