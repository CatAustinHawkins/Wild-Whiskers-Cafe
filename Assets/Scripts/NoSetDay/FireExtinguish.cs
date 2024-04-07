using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguish : MonoBehaviour
{
    //on the fires

    public bool OvenFire;
    public GameObject FireControl;

    public Interact InteractScript;
    public InteractDay1 InteractDay1Script;


    public bool Tutorial;
    public bool Day1;
    public bool Day2;
    public bool Day3;
    public bool Day4;
    public bool Day5;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FireExtinguisher" && OvenFire && Tutorial)
        {
            FireControl.SetActive(false);
            gameObject.SetActive(false);
            InteractScript.OnFire = false;
            InteractScript.FireGone();
        }
        if (other.tag == "FireExtinguisher" && OvenFire && Day1)
        {
            FireControl.SetActive(false);
            gameObject.SetActive(false);
            //InteractDay1Script.OnFire = false;
            //InteractDay1Script.FireGone();
        }
        if (other.tag == "FireExtinguisher")
        {
            gameObject.SetActive(false);
        }
    }



}
