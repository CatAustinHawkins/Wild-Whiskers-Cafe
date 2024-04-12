using UnityEngine;
using System.Collections;

//This script is on the fridge

public class Fridge : MonoBehaviour
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
    public GameObject CrayfishIcon;
    public GameObject FlourIcon;
    public GameObject MothIcon;
    public GameObject ClamIcon;

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
    public bool HoldingCrayfish;
    public bool HoldingFlour;
    public bool HoldingMoth;
    public bool HoldingClam;

    public Tutorial TutorialScript;
    public Interact InteractScript;

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
    public GameObject HoldingCrayfishGO;
    public GameObject HoldingFlourGO;
    public GameObject HoldingMothGO;
    public GameObject HoldingClamGO;

    public void Update()
    {
        if (HoldingBamboo && HoldingBread && TutorialScript.TutorialImages == 25) /////
        {
            TutorialScript.NextTutorial();
        }
    }


    public void BambooButton() //This button is on the bamboo icon 
    {
        if(!InteractScript.PlayerLeftHandFull)
        {
            BambooIcon.SetActive(true); //when its clicked, enable the bamboo icon (which the player holds)
            HoldingBamboo = true; //set holding bamboo to true
            InteractScript.PlayerLeftHandFull = true;
            HoldingBambooGO.SetActive(true);
        }
        else
        {
            InteractScript.StartCoroutine(HandUITimer());
        }
        

    }

    public void BreadButton() //This button is on the bread icon
    {
        if(InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            BreadIcon.SetActive(true); //when its clicked, enable the bread icon (which the player holds)
            HoldingBread = true; //set holding bread to true
            HoldingBreadGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }

    }

    public void MeatButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MeatIcon.SetActive(true);
            HoldingMeat = true;
            HoldingMeatGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;

            if (TutorialScript.TutorialImages == 16)
            {
                TutorialScript.NextTutorial();
            }
        }

    }

    public void StrawberryButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            StrawberryIcon.SetActive(true);
            HoldingStrawberry = true;
            HoldingStrawberryGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void AppleButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            AppleIcon.SetActive(true);
            HoldingApple = true;
            HoldingAppleGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }
    }
    public void HayButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            HayIcon.SetActive(true);
            HoldingHay = true;
            HoldingHayGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }
    }
    public void AntButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            AntIcon.SetActive(true);
            HoldingAnt = true;
            HoldingAntGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;
        }
    }
    public void WormButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            WormsIcon.SetActive(true);
            HoldingWorms = true;
            HoldingWormsGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }
    }
    public void TomatoButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            TomatoIcon.SetActive(true);
            HoldingTomato = true;
            HoldingTomatoGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;
        }
    }
    public void LeafButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            LeafIcon.SetActive(true);
            HoldingLeaf = true;
            HoldingLeafGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }
    }

    public void BoneButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            BoneIcon.SetActive(true);
            HoldingBone = true;
            HoldingBoneGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }
    }

    public void MossButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MossIcon.SetActive(true);
            HoldingMoss = true;
            HoldingMossGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void MelonButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MelonIcon.SetActive(true);
            HoldingMelon = true;
            HoldingMelonGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void StickButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            StickIcon.SetActive(true);
            HoldingStick = true;
            HoldingStickGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void SpiceButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            SpiceIcon.SetActive(true);
            HoldingSpice = true;
            HoldingSpiceGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }
    }

    public void SnailButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            SnailIcon.SetActive(true);
            HoldingSnail = true;
            HoldingSnailGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }
    }

    public void MushroomButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MushroomIcon.SetActive(true);
            HoldingMushroom = true;
            HoldingMushroomGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }
    }

    public void PastaButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            PastaIcon.SetActive(true);
            HoldingPasta = true;
            HoldingPastaGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }
    }

    public void CrayfishButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            CrayfishIcon.SetActive(true);
            HoldingCrayfish = true;
            HoldingCrayfishGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void FlourButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            FlourIcon.SetActive(true);
            HoldingFlour = true;
            HoldingFlourGO.SetActive(true);

            InteractScript.PlayerRightHandFull = true;
        }
    }
    public void MothButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            MothIcon.SetActive(true);
            HoldingMoth = true;
            HoldingMothGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void ClamButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            ClamIcon.SetActive(true);
            HoldingClam = true;
            HoldingClamGO.SetActive(true);

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public IEnumerator HandUITimer()
    {
        if(InteractScript.PlayerLeftHandFull)
        {
            LeftHandUI.SetActive(true);
        }

        if(InteractScript.PlayerRightHandFull)
        {
            RightHandUI.SetActive(true);
        }

        if(InteractScript.PlayerRightHandFull && InteractScript.PlayerLeftHandFull)
        {
            BothHandUI.SetActive(true);
        }

        yield return new WaitForSecondsRealtime(3);
        LeftHandUI.SetActive(false);
        RightHandUI.SetActive(false);
        BothHandUI.SetActive(false);
    }
}
