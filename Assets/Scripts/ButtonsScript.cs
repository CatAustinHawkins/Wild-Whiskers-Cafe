using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{

    public CustomerTest customertestscript;
    public GameObject StartDayWindow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        customertestscript.DayBegin = true;
        StartDayWindow.SetActive(false);
    }
}
