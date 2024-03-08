using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject Fish;
    public GameObject Overlay;

    public Tutorial TutorialScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Fishtank()
    {
        if (TutorialScript.TutorialImages == 5)
        {
            TutorialScript.NextTutorial();
        }
        Fish.SetActive(true);
        Overlay.SetActive(true);
    }
}
