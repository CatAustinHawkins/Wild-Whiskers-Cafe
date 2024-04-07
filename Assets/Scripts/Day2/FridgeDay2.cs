using UnityEngine;
using System.Collections;

//This script is on the fridge

public class FridgeDay2 : MonoBehaviour
{
    public GameObject BambooIcon; //the Bamboo Icon gameobject
    public GameObject BreadIcon; //the Bread Icon gameobject
    public GameObject MeatIcon;
    public GameObject StrawberryIcon;
    public GameObject AppleIcon;
    public GameObject WormsIcon;
    public GameObject TomatoIcon;
    public GameObject AntIcon;
    public GameObject HayIcon;
    public GameObject LeafIcon;

    public bool HoldingBamboo; //if the player is holding bamboo or not
    public bool HoldingBread; //if the player is holding bread or not
    public bool HoldingMeat;
    public bool HoldingStrawberry; //if the player is holding bamboo or not
    public bool HoldingApple; //if the player is holding bread or not
    public bool HoldingWorms;
    public bool HoldingTomato;
    public bool HoldingAnt;
    public bool HoldingHay;
    public bool HoldingLeaf;

    public Interact InteractScriptDay2;

    public GameObject LeftHandUI;
    public GameObject RightHandUI;
    public GameObject BothHandUI;

    public GameObject HoldingBambooGO; //if the player is holding bamboo or not
    public GameObject HoldingBreadGO; //if the player is holding bread or not
    public GameObject HoldingMeatGO;
    public GameObject HoldingStrawberryGO; //if the player is holding bamboo or not
    public GameObject HoldingAppleGO; //if the player is holding bread or not
    public GameObject HoldingWormsGO;
    public GameObject HoldingTomatoGO;
    public GameObject HoldingAntGO; //if the player is holding bread or not
    public GameObject HoldingHayGO;
    public GameObject HoldingLeafGO;


    public void BambooButton() //This button is on the bamboo icon 
    {
        if(!InteractScriptDay2.PlayerLeftHandFull)
        {
            BambooIcon.SetActive(true); //when its clicked, enable the bamboo icon (which the player holds)
            HoldingBamboo = true; //set holding bamboo to true
            InteractScriptDay2.PlayerLeftHandFull = true;
            HoldingBambooGO.SetActive(true);
        }
        else
        {
            InteractScriptDay2.StartCoroutine(HandUITimer());
        }
        

    }

    public void BreadButton() //This button is on the bread icon
    {
        if(InteractScriptDay2.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            BreadIcon.SetActive(true); //when its clicked, enable the bread icon (which the player holds)
            HoldingBread = true; //set holding bread to true
            HoldingBreadGO.SetActive(true);

            InteractScriptDay2.PlayerRightHandFull = true;
        }

    }

    public void MeatButton()
    {
        if (InteractScriptDay2.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MeatIcon.SetActive(true);
            HoldingMeat = true;
            HoldingMeatGO.SetActive(true);

            InteractScriptDay2.PlayerLeftHandFull = true;
        }
    }
    public void StrawberryButton()
    {
        if (InteractScriptDay2.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            StrawberryIcon.SetActive(true);
            HoldingStrawberry = true;
            HoldingStrawberryGO.SetActive(true);

            InteractScriptDay2.PlayerLeftHandFull = true;
        }
    }

    public void AppleButton()
    {
        if (InteractScriptDay2.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            AppleIcon.SetActive(true);
            HoldingApple = true;
            HoldingAppleGO.SetActive(true);

            InteractScriptDay2.PlayerRightHandFull = true;
        }
    }
    public void HayButton()
    {
        if (InteractScriptDay2.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            HayIcon.SetActive(true);
            HoldingHay = true;
            HoldingHayGO.SetActive(true);

            InteractScriptDay2.PlayerRightHandFull = true;
        }
    }
    public void AntButton()
    {
        if (InteractScriptDay2.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            AntIcon.SetActive(true);
            HoldingAnt = true;
            HoldingAntGO.SetActive(true);

            InteractScriptDay2.PlayerLeftHandFull = true;
        }
    }
    public void WormButton()
    {
        if (InteractScriptDay2.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            WormsIcon.SetActive(true);
            HoldingWorms = true;
            HoldingWormsGO.SetActive(true);

            InteractScriptDay2.PlayerRightHandFull = true;
        }
    }
    public void TomatoButton()
    {
        if (InteractScriptDay2.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            TomatoIcon.SetActive(true);
            HoldingTomato = true;
            HoldingTomatoGO.SetActive(true);

            InteractScriptDay2.PlayerLeftHandFull = true;
        }
    }
    public void LeafButton()
    {
        if (InteractScriptDay2.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            LeafIcon.SetActive(true);
            HoldingLeaf = true;
            HoldingLeafGO.SetActive(true);

            InteractScriptDay2.PlayerRightHandFull = true;
        }
    }

    public IEnumerator HandUITimer()
    {
        if(InteractScriptDay2.PlayerLeftHandFull)
        {
            LeftHandUI.SetActive(true);
        }

        if(InteractScriptDay2.PlayerRightHandFull)
        {
            RightHandUI.SetActive(true);
        }

        if(InteractScriptDay2.PlayerRightHandFull && InteractScriptDay2.PlayerLeftHandFull)
        {
            BothHandUI.SetActive(true);
        }

        yield return new WaitForSecondsRealtime(3);
        LeftHandUI.SetActive(false);
        RightHandUI.SetActive(false);
        BothHandUI.SetActive(false);
    }
}
