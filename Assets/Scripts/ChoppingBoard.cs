using UnityEngine;
using TMPro;

public class ChoppingBoard : MonoBehaviour
{
    public TextMeshProUGUI PlayerHolding;
    public PlayerScript Player;

    public CustomerTest Customer1;
    public CustomerTest Customer2;
    public CustomerTest Customer3;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Player.CurrentCustomer == 1)
            {
                PlayerHolding.text = "Holding: Bamboo Hotdog (ready to serve)";
            }
            if (Player.CurrentCustomer == 2)
            {
                PlayerHolding.text = "Holding: Venison Steak (ready to serve)";
            }
            if (Player.CurrentCustomer == 3)
            {
                PlayerHolding.text = "Holding: Mouse Burger (ready to serve)";
            }
        }
    }
}
