
using UnityEngine;

public class PuddleRemove : MonoBehaviour
{
    public AudioSource Broom;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Broom")
        {
            Broom.Play();
            gameObject.SetActive(false);
        }
    }
}
