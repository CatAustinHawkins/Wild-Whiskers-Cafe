using UnityEngine;
using System.Collections;

//This script is controls the fridge

public class Fridge : MonoBehaviour
{
    //what the player holds
    //what hand the player uses depends on what recipes the ingreidents are involved in.
    //for example, the player has to hold the strawberry in their left hand, and the apple in their right hand
    //otherwise, they would be unable to make the strawberry and apple smoothie if they were in the same hand
    //as they wouldnt be able to hold both ingredients at once

    public GameObject BambooIcon; //Left Hand
    public GameObject BreadIcon; //Right Hand 
    public GameObject MeatIcon; //Left Hand
    public GameObject StrawberryIcon; //Left Hand
    public GameObject AppleIcon; //Right Hand 
    public GameObject WormsIcon; //Right Hand 
    public GameObject TomatoIcon; //Left Hand
    public GameObject AntIcon; //Left Hand
    public GameObject HayIcon; //Right Hand 
    public GameObject LeafIcon; //Right Hand 
    public GameObject BoneIcon; //Right Hand 
    public GameObject MossIcon; //Left Hand
    public GameObject MelonIcon; //Left Hand
    public GameObject StickIcon; //Left Hand
    public GameObject SpiceIcon; //Right Hand 
    public GameObject SnailIcon; //Right Hand 
    public GameObject MushroomIcon; //Right Hand 
    public GameObject PastaIcon; //Right Hand 
    public GameObject CrayfishIcon; //Left Hand
    public GameObject FlourIcon; //Right Hand 
    public GameObject MothIcon; //Left Hand
    public GameObject ClamIcon; //Left Hand

    //whether the player is holding the ingredient or not
    public bool HoldingBamboo; 
    public bool HoldingBread; 
    public bool HoldingMeat;
    public bool HoldingStrawberry; 
    public bool HoldingApple; 
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

    public Tutorial TutorialScript; //tutorial script
    public Interact InteractScript; //interact script 

    public GameObject LeftHandUI; //left hand UI warning
    public GameObject RightHandUI; //right hand UI warning
    public GameObject BothHandUI; //both hands UI warning

    public void Update()
    {
        if (HoldingBamboo && HoldingBread && TutorialScript.TutorialImages == 25) // if the player is holding bamboo and bread, and the tutorial prompt is 25
        {
            TutorialScript.NextTutorial(); //show next tutorial prompt
        }
    }


    //each button is on its respective icon on the fridge
    public void BambooButton() 
    {
        if(!InteractScript.PlayerLeftHandFull) //check whether the player can hold the item
        {
            BambooIcon.SetActive(true); //when its clicked, enable the bamboo icon (which the player holds)
            HoldingBamboo = true; //set holding bamboo to true
            InteractScript.PlayerLeftHandFull = true; //set the players left hand to full
        }
        else
        {
            InteractScript.StartCoroutine(HandUITimer()); //if the players hand was full, display the warning
        }
        

    }

    //repeated

    public void BreadButton() 
    {
        if(InteractScript.PlayerRightHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            BreadIcon.SetActive(true); 
            HoldingBread = true; 
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

            InteractScript.PlayerLeftHandFull = true;

            if (TutorialScript.TutorialImages == 16)
            {
                TutorialScript.NextTutorial();
            }
        }

    }

    public void StrawberryButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            StartCoroutine(HandUITimer());
        }
        else
        {
            StrawberryIcon.SetActive(true);
            HoldingStrawberry = true;

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

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    //Hand warnings
    public IEnumerator HandUITimer()
    {
        if(InteractScript.PlayerLeftHandFull) //if the hand is full
        {
            LeftHandUI.SetActive(true); //display left hand ui warning
        }

        if(InteractScript.PlayerRightHandFull)
        {
            RightHandUI.SetActive(true); //display right hand ui warning
        }

        if(InteractScript.PlayerRightHandFull && InteractScript.PlayerLeftHandFull)
        {
            BothHandUI.SetActive(true); //display both hands ui warning
        }

        yield return new WaitForSecondsRealtime(3); //wait 3 seconds
        LeftHandUI.SetActive(false); //hide all warnings
        RightHandUI.SetActive(false);
        BothHandUI.SetActive(false);
    }
}
