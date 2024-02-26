using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguish : MonoBehaviour
{
    //on the fires

    public bool OvenFire;
    public GameObject FireControl;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FireExtinguisher" && OvenFire)
        {
            FireControl.SetActive(false);
            gameObject.SetActive(false);
        }
        if (other.tag == "FireExtinguisher")
        {
            gameObject.SetActive(false);
        }
    }


}
