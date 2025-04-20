using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTruckFridge : MonoBehaviour
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
    public GameObject AntIcon; //Left Hand
    public GameObject MossIcon; //Left Hand
    public GameObject StickIcon; //Left Hand
    public GameObject FlourIcon; //Right Hand 
    public GameObject MothIcon; //Left Hand
    public GameObject SausageIcon; //LeftHand
    public GameObject PastryIcon; //RightHand

    //whether the player is holding the ingredient or not
    public bool HoldingBamboo;
    public bool HoldingBread;
    public bool HoldingMeat;
    public bool HoldingStrawberry;
    public bool HoldingApple;
    public bool HoldingAnt;
    public bool HoldingMoss;
    public bool HoldingStick;
    public bool HoldingFlour;
    public bool HoldingMoth;
    public bool HoldingSausage;
    public bool HoldingPastry;

    public FoodTruckInteract InteractScript; //interact script 



    //each button is on its respective icon on the fridge
    public void BambooButton()
    {
        if (InteractScript.PlayerLeftHandFull) //check whether the player can hold the item
        {
            InteractScript.HandTimer(); //if the players hand was full, display the warning
        }
        else
        {
            BambooIcon.SetActive(true); //when its clicked, enable the bamboo icon (which the player holds)
            HoldingBamboo = true; //set holding bamboo to true
            InteractScript.PlayerLeftHandFull = true; //set the players left hand to full
        }
    }

    //repeated

    public void BreadButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            InteractScript.HandTimer();
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
            InteractScript.HandTimer();
        }
        else
        {
            MeatIcon.SetActive(true);
            HoldingMeat = true;

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void StrawberryButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            InteractScript.HandTimer();
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
            InteractScript.HandTimer();
        }
        else
        {
            AppleIcon.SetActive(true);
            HoldingApple = true;

            InteractScript.PlayerRightHandFull = true;
        }
    }

    public void AntButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            InteractScript.HandTimer();
        }
        else
        {
            AntIcon.SetActive(true);
            HoldingAnt = true;

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void MossButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            InteractScript.HandTimer();
        }
        else
        {
            MossIcon.SetActive(true);
            HoldingMoss = true;

            InteractScript.PlayerLeftHandFull = true;
        }
    }


    public void StickButton()
    {
        if (InteractScript.PlayerLeftHandFull)
        {
            InteractScript.HandTimer();
        }
        else
        {
            StickIcon.SetActive(true);
            HoldingStick = true;

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void FlourButton()
    {
        if (InteractScript.PlayerRightHandFull)
        {
            InteractScript.HandTimer();
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
            InteractScript.HandTimer();
        }
        else
        {
            MothIcon.SetActive(true);
            HoldingMoth = true;

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void SausageButton()
    {
        if(InteractScript.PlayerLeftHandFull)
        {
            InteractScript.HandTimer();
        }
        else
        {
            SausageIcon.SetActive(true);
            HoldingSausage = true;

            InteractScript.PlayerLeftHandFull = true;
        }
    }

    public void PastryButton()
    {
        if(InteractScript.PlayerRightHandFull)
        {
            InteractScript.HandTimer();
        }
        else
        {
            PastryIcon.SetActive(true);
            HoldingPastry = true;

            InteractScript.PlayerRightHandFull = true;
        }
    }

}
