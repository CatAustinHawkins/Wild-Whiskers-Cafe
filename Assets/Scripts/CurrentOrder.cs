using UnityEngine;

public class CurrentOrder : MonoBehaviour
{

    public PlayerScript Player;

    public GameObject Order1;
    public GameObject Order2;
    public GameObject Order3;

    public bool OrderOpen;

    public void Clicked()
    {
        if(!OrderOpen)
        {
            if(Player.CurrentCustomer == 1)
            {
                Order1.SetActive(true);
                OrderOpen = true;
            }
            if(Player.CurrentCustomer == 2)
            {
                Order2.SetActive(true);
                OrderOpen = true;

            }
            if (Player.CurrentCustomer == 3)
            {
                Order3.SetActive(true);
                OrderOpen = true;

            }
        }
        else
        {
            if (Player.CurrentCustomer == 1)
            {
                Order1.SetActive(false);
                OrderOpen = false;

            }
            if (Player.Recipe2InProgress)
            {
                Order2.SetActive(false);
                OrderOpen = false;

            }
            if (Player.Recipe3InProgress)
            {
                Order3.SetActive(false);
                OrderOpen = false;

            }
        }
    }
}
