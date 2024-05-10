using UnityEngine;

//This script is on each fire gameobject

public class FireExtinguish : MonoBehaviour
{
    public bool OvenFire; //is the fire on the oven 
    public GameObject FireControl; //the fire manager

    public Interact InteractScript; //the interact script

    public AudioSource FireSound; //the fire sound effect

    public void OnEnable() //when the fire gameobject is enabled
    {
        FireSound.Play(); //play the fire sound effect
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FireExtinguisher" && OvenFire) //if the fire extinguisher is overlapping, and the fire is on the oven
        {
            FireControl.SetActive(false); //disable the fire manager - no more fire spreads
            gameObject.SetActive(false); //disable the current fire
            InteractScript.OnFire = false; //inform the interact script that the fire is off
            FireSound.Pause(); //pause the fire sound effect
            InteractScript.FireGone(); //call the function FireGone on the interact script
        }
        if (other.tag == "FireExtinguisher") //if the fire extinguisher is overlapping
        {
            FireSound.Pause(); //pause the fire sound effect
            gameObject.SetActive(false); //disable the current fire
        }
    }
}
