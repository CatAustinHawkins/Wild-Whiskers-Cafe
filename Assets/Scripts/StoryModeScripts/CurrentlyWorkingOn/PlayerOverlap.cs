using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INCOMPLETE

public class PlayerOverlap : MonoBehaviour
{
    public GameObject[] Overlaps;

    public bool SinkOverlapping;
    public bool FireExtinguisherOverlapping;
    public bool BinOverlapping;
    public bool OvenOverlapping;
    public bool ChoppingBoardOverlapping;
    public bool FridgeOverlapping;
    public bool BroomOverlapping;
    public bool BlenderOverlapping;
    public bool KitchenExitOverlapping;
    public bool PlatePlace1Overlapping;
    public bool PlatePlace2Overlapping;
    public bool Puddle1Overlapping;
    public bool Puddle2Overlapping;
    public bool Puddle3Overlapping;
    public bool Puddle4Overlapping;
    public bool Puddle5Overlapping;
    public bool DirtyPlateOverlapping;
    public bool FireSinkOverlapping;
    public bool FireOvenOverlapping;
    public bool FireBlenderOverlapping;
    public bool FirePlatePlaceOverlapping;
    public bool FireBroomOverlapping;
    public bool FireFridgeOverlapping;
    public bool FireChoppingBoardOverlapping;


    public bool TrashBagOverlapping;

    public int CurrentOverlap;
    public int i; 

    //Adder, Alpaca, Alzy, Bat, Beaver, Breadcrumb, Duck, Ferret, Fox, Gemsbok, Giraffe, Hedgehog, Ibex, Kangaroo, Leopard, Monkey, Panda, Pangolin, Playtpus, Raccoon, Pony
    public bool AdderOverlapping;
    public bool AlpacaOverlapping;
    public bool AlzyOverlapping;
    public bool BatOverlapping;
    public bool BeaverOverlapping;
    public bool BreadcrumbOverlapping;
    public bool DuckOverlapping;
    public bool FerretOverlapping;
    public bool FoxOverlapping;
    public bool GemsbokOverlapping;
    public bool GiraffeOverlapping;
    public bool HedgehogOverlapping;
    public bool IbexOverlapping;
    public bool KangarooOverlapping;
    public bool LeopardOverlapping;
    public bool MonkeyOverlapping;
    public bool PandaOverlapping;
    public bool PangolinOverlapping;
    public bool PlatypusOverlapping;
    public bool RaccoonOverlapping;
    public bool PonyOverlapping;

    public bool Cooldown;

    public void Switching()
    {
        while(i < 4)
        {
            Overlaps[i].SetActive(false);
            i++;
        }

        Overlaps[CurrentOverlap].SetActive(true);
        i = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Cooldown == false)
        {
            StartCoroutine(CooldownCheck());

            if (other.tag == "Sink")
            {
                SinkOverlapping = true;
                CurrentOverlap = 1;
                Switching();
            }

            if (other.tag == "FireExtinguisher")
            {
                CurrentOverlap = 2;
                FireExtinguisherOverlapping = true;
                Switching();
            }

            if (other.tag == "TrashBin")
            {

                BinOverlapping = true;
            }

            if (other.tag == "Oven")
            {

                OvenOverlapping = true;
            }

            if (other.tag == "ChoppingBoard")
            {

                ChoppingBoardOverlapping = true;
            }

            if (other.tag == "Fridge")
            {

                FridgeOverlapping = true;
            }

            if (other.tag == "Broom")
            {

                BroomOverlapping = true;
            }

            if (other.tag == "Blender")
            {
                CurrentOverlap = 3;
                BlenderOverlapping = true;
                Switching();

            }

            if (other.tag == "KitchenExit")
            {

                KitchenExitOverlapping = true;
            }

            if (other.tag == "PlatePlace1")
            {
                 PlatePlace1Overlapping = true;
            }

            if (other.tag == "PlatePlace2")
            {
                  PlatePlace2Overlapping = true;
            }

            //customers in cafe room, player is unable to be overlapping with any kitchen items

            if (other.tag == "PandaCustomer")
            {
                PandaOverlapping = true;
               
            }
        }

 
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Sink")
        {
            SinkOverlapping = false;
            Overlaps[1].SetActive(false);
        }

        if (other.tag == "FireExtinguisher")
        {
            FireExtinguisherOverlapping = false;
            Overlaps[2].SetActive(false);
        }

        if (other.tag == "TrashBin")
        {
            BinOverlapping = false; 
        }

        if (other.tag == "Oven")
        {
            OvenOverlapping = false;
        }

        if (other.tag == "ChoppingBoard")
        {
            ChoppingBoardOverlapping = false;   
        }

        if (other.tag == "Fridge")
        {
            FridgeOverlapping = false;
        }

        if (other.tag == "Broom")
        {
            BroomOverlapping = false;
        }

        if (other.tag == "Blender")
        {
            BlenderOverlapping = false;
            Overlaps[3].SetActive(false);
        }

        if (other.tag == "KitchenExit")
        {
            KitchenExitOverlapping = false;
        }

        if (other.tag == "PlatePlace1")
        {
            PlatePlace1Overlapping = false;
        }

        if (other.tag == "PlatePlace2")
        {
            PlatePlace2Overlapping = false;
        }

        if (other.tag == "PandaCustomer")
        {
            PandaOverlapping = false;  
        }
    }

    IEnumerator CooldownCheck()
    {
        Cooldown = true;
        yield return new WaitForSecondsRealtime(0.15f);
        Cooldown = false;
    }
}
