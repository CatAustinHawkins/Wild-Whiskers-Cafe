using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{

    public GameObject[] TutorialImageArray;
    public int TutorialImages;
    public CustomerTest customertestscript;

    public TextMeshProUGUI TutorialButtonText;

    public void NextTutorial()
    {

        if (TutorialImages == 9)
        {
            TutorialButtonText.text = "End Tutorial";
        }

        if (TutorialImages == 10)
        {
            Destroy(gameObject);
            customertestscript.DayBegin = true;
        }

        TutorialImageArray[TutorialImages].SetActive(false);

        TutorialImages++;

        TutorialImageArray[TutorialImages].SetActive(true);
    }
}
