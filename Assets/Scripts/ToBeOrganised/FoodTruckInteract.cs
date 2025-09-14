using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTruckInteract : MonoBehaviour
{

    public FoodTruckOverlap OverlapScript;
    public GameObject POGO;

    public FoodTruckMeal FoodTruckMealScript;

    public bool PlayerLeftHandFull;
    //Broom
    //Bamboo
    //bamboo hotdog

    public bool PlayerRightHandFull;
    //Bread
    //DirtyPlate
    //FireExtinguish
    //MeatSmoothie
    //bamboo hotdog
    //trashbag
    //meat

    public GameObject LeftHandUI;
    public GameObject RightHandUI;
    public GameObject BothHandUI;

    // Start is called before the first frame update
    void Start()
    {
        POGO = GameObject.FindWithTag("Player"); //find the player setup script
        OverlapScript = POGO.GetComponent<FoodTruckOverlap>();
    }

    // Update is called once per frame
    public void Interact()
    {
        if(OverlapScript.BinOverlapping)
        {
            Bin();
        }

        if(OverlapScript.FridgeOverlapping)
        {
            Fridge();
        }

        if (OverlapScript.BlenderOverlapping)
        {
            Blender();
        }

        if (OverlapScript.SinkOverlapping)
        {
            Sink();
        }

        if (OverlapScript.ChoppingBoardOverlapping)
        {
            ChoppingBoard();
        }

        if(OverlapScript.FireExtinguisherOverlapping)
        {
            FireExtinguisher();
        }

        if(OverlapScript.BroomOverlapping)
        {
            Broom();
        }

        if(OverlapScript.DirtyPlateOverlapping)
        {
            DirtyPlate();
        }

        if(OverlapScript.CustomerOrderOverlapping)
        {
            FoodTruckMealScript.DialogueTime();
        }

        if(OverlapScript.OvenOverlapping)
        {
            Oven();
        }
    }

    public void Bin()
    {

    }

    public void Fridge()
    {

    }

    public void Blender()
    {

    }

    public void Sink()
    {

    }

    public void ChoppingBoard()
    {

    }

    public void FireExtinguisher()
    {

    }

    public void Broom()
    {

    }

    public void DirtyPlate()
    {

    }

    public void CustomerOrder()
    {

    }

    public void Oven()
    {

    }

    public void HandTimer()
    {
        StartCoroutine(HandUITimer());
    }

    public IEnumerator HandUITimer()
    {
        if (PlayerLeftHandFull) //if the hand is full
        {
            LeftHandUI.SetActive(true); //display left hand ui warning
        }

        if (PlayerRightHandFull)
        {
            RightHandUI.SetActive(true); //display right hand ui warning
        }

        if (PlayerRightHandFull && PlayerLeftHandFull)
        {
            BothHandUI.SetActive(true); //display both hands ui warning
        }

        yield return new WaitForSecondsRealtime(3); //wait 3 seconds
        LeftHandUI.SetActive(false); //hide all warnings
        RightHandUI.SetActive(false);
        BothHandUI.SetActive(false);
    }
}
