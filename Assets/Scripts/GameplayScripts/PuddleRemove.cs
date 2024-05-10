using UnityEngine;

//This script is on each puddle gameobject

public class PuddleRemove : MonoBehaviour
{
    public AudioSource Broom; //broom sweep sound effect

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Broom") //if the broom collides with the puddle 
        {
            Broom.Play(); //play the broom sweep sound effect
            gameObject.SetActive(false); //disable the puddle
        }
    }
}
