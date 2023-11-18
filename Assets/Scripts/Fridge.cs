using UnityEngine;
using TMPro;

public class Fridge : MonoBehaviour
{
    public TextMeshProUGUI PlayerHolding;
    public PlayerScript Player;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(Player.CurrentCustomer == 1) 
            {
                PlayerHolding.text = "Holding: Bamboo, Hotdog Bun";
            }
            if (Player.CurrentCustomer == 2)
            {
                PlayerHolding.text = "Holding: Venison Steak";
            }
            if (Player.CurrentCustomer == 3)
            {
                PlayerHolding.text = "Holding: Mouse Burger, Burger Bun";
            }
        }
    }

}
