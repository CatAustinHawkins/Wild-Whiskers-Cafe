
using UnityEngine;

public class PuddleRemove : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Broom")
        {
            gameObject.SetActive(false);
        }
    }
}
