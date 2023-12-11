using UnityEngine;
using TMPro;

public class Fridge : MonoBehaviour
{
    public GameObject BambooIcon;
    public GameObject BreadIcon;

    public bool HoldingBamboo;
    public bool HoldingBread;

    public void BambooButton()
    {
        BambooIcon.SetActive(true);
        HoldingBamboo = true;
    }

    public void BreadButton()
    {
        BreadIcon.SetActive(true);
        HoldingBread = true;
    }

}
