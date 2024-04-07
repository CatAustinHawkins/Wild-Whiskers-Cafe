using UnityEngine;
using System.Collections;

//This script is on the fridge

public class FridgeDay4 : MonoBehaviour
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
    public GameObject BoneIcon;
    public GameObject MossIcon;
    public GameObject MelonIcon;
    public GameObject StickIcon;
    public GameObject SpiceIcon;
    public GameObject SnailIcon;
    public GameObject MushroomIcon;
    public GameObject PastaIcon;

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
    public bool HoldingBone;
    public bool HoldingMoss;
    public bool HoldingMelon;
    public bool HoldingStick;
    public bool HoldingSpice;
    public bool HoldingSnail;
    public bool HoldingMushroom;
    public bool HoldingPasta;

    public Interact InteractScriptDay4;

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
    public GameObject HoldingBoneGO;
    public GameObject HoldingMossGO;
    public GameObject HoldingMelonGO;
    public GameObject HoldingStickGO;
    public GameObject HoldingSpiceGO;
    public GameObject HoldingSnailGO;
    public GameObject HoldingMushroomGO;
    public GameObject HoldingPastaGO;



    public void BambooButton() //This button is on the bamboo icon 
    {
        if (!InteractScriptDay4.PlayerLeftHandFull)
        {
            BambooIcon.SetActive(true); //when its clicked, enable the bamboo icon (which the player holds)
            HoldingBamboo = true; //set holding bamboo to true
            InteractScriptDay4.PlayerLeftHandFull = true;
            HoldingBambooGO.SetActive(true);
        }
        else
        {
            InteractScriptDay4.StartCoroutine(HandUITimer());
        }


    }

    public void BreadButton() //This button is on the bread icon
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            BreadIcon.SetActive(true); //when its clicked, enable the bread icon (which the player holds)
            HoldingBread = true; //set holding bread to true
            HoldingBreadGO.SetActive(true);

            InteractScriptDay4.PlayerRightHandFull = true;
        }

    }

    public void MeatButton()
    {
        if (InteractScriptDay4.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MeatIcon.SetActive(true);
            HoldingMeat = true;
            HoldingMeatGO.SetActive(true);

            InteractScriptDay4.PlayerLeftHandFull = true;
        }
    }
    public void StrawberryButton()
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            StrawberryIcon.SetActive(true);
            HoldingStrawberry = true;
            HoldingStrawberryGO.SetActive(true);

            InteractScriptDay4.PlayerLeftHandFull = true;
        }
    }

    public void AppleButton()
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            AppleIcon.SetActive(true);
            HoldingApple = true;
            HoldingAppleGO.SetActive(true);

            InteractScriptDay4.PlayerRightHandFull = true;
        }
    }
    public void HayButton()
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            HayIcon.SetActive(true);
            HoldingHay = true;
            HoldingHayGO.SetActive(true);

            InteractScriptDay4.PlayerRightHandFull = true;
        }
    }
    public void AntButton()
    {
        if (InteractScriptDay4.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            AntIcon.SetActive(true);
            HoldingAnt = true;
            HoldingAntGO.SetActive(true);

            InteractScriptDay4.PlayerLeftHandFull = true;
        }
    }
    public void WormButton()
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            WormsIcon.SetActive(true);
            HoldingWorms = true;
            HoldingWormsGO.SetActive(true);

            InteractScriptDay4.PlayerRightHandFull = true;
        }
    }
    public void TomatoButton()
    {
        if (InteractScriptDay4.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            TomatoIcon.SetActive(true);
            HoldingTomato = true;
            HoldingTomatoGO.SetActive(true);

            InteractScriptDay4.PlayerLeftHandFull = true;
        }
    }
    public void LeafButton()
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            LeafIcon.SetActive(true);
            HoldingLeaf = true;
            HoldingLeafGO.SetActive(true);

            InteractScriptDay4.PlayerRightHandFull = true;
        }
    }

    public void BoneButton()
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            BoneIcon.SetActive(true);
            HoldingBone = true;
            HoldingBoneGO.SetActive(true);

            InteractScriptDay4.PlayerRightHandFull = true;
        }
    }

    public void MossButton()
    {
        if (InteractScriptDay4.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MossIcon.SetActive(true);
            HoldingMoss = true;
            HoldingMossGO.SetActive(true);

            InteractScriptDay4.PlayerLeftHandFull = true;
        }
    }

    public void MelonButton()
    {
        if (InteractScriptDay4.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MelonIcon.SetActive(true);
            HoldingMelon = true;
            HoldingMelonGO.SetActive(true);

            InteractScriptDay4.PlayerLeftHandFull = true;
        }
    }

    public void StickButton()
    {
        if (InteractScriptDay4.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            StickIcon.SetActive(true);
            HoldingStick = true;
            HoldingStickGO.SetActive(true);

            InteractScriptDay4.PlayerLeftHandFull = true;
        }
    }

    public void SpiceButton()
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            SpiceIcon.SetActive(true);
            HoldingSpice = true;
            HoldingSpiceGO.SetActive(true);

            InteractScriptDay4.PlayerRightHandFull = true;
        }
    }

    public void SnailButton()
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            SnailIcon.SetActive(true);
            HoldingSnail = true;
            HoldingSnailGO.SetActive(true);

            InteractScriptDay4.PlayerRightHandFull = true;
        }
    }

    public void MushroomButton()
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MushroomIcon.SetActive(true);
            HoldingMushroom = true;
            HoldingMushroomGO.SetActive(true);

            InteractScriptDay4.PlayerRightHandFull = true;
        }
    }

    public void PastaButton()
    {
        if (InteractScriptDay4.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            PastaIcon.SetActive(true);
            HoldingPasta = true;
            HoldingPastaGO.SetActive(true);

            InteractScriptDay4.PlayerRightHandFull = true;
        }
    }
    public IEnumerator HandUITimer()
    {
        if(InteractScriptDay4.PlayerLeftHandFull)
        {
            LeftHandUI.SetActive(true);
        }

        if(InteractScriptDay4.PlayerRightHandFull)
        {
            RightHandUI.SetActive(true);
        }

        if(InteractScriptDay4.PlayerRightHandFull && InteractScriptDay4.PlayerLeftHandFull)
        {
            BothHandUI.SetActive(true);
        }

        yield return new WaitForSecondsRealtime(3);
        LeftHandUI.SetActive(false);
        RightHandUI.SetActive(false);
        BothHandUI.SetActive(false);
    }
}
