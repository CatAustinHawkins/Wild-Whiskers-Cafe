using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguish : MonoBehaviour
{
    //on the fires

    public bool OvenFire;
    public GameObject FireControl;

    public Interact InteractScript;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FireExtinguisher" && OvenFire)
        {
            FireControl.SetActive(false);
            gameObject.SetActive(false);
            InteractScript.OnFire = false;
            InteractScript.FireGone();
        }
        if (other.tag == "FireExtinguisher")
        {
            gameObject.SetActive(false);
        }
    }



}
