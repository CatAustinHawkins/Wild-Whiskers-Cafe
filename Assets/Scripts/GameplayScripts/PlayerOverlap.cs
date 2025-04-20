using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverlap : MonoBehaviour
{
    public GameObject SinkOverlap;
    public GameObject FireExtinguisherOverlap;
    public GameObject BinOverlap;
    public GameObject OvenOverlap;
    public GameObject ChoppingBoardOverlap;
    public GameObject FridgeOverlap;
    public GameObject BroomOverlap;
    public GameObject BlenderOverlap;
    public GameObject KitchenExitOverlap;
    public GameObject PlatePlace1Overlap;
    public GameObject PlatePlace2Overlap;
    public GameObject PandaOverlap;

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

    public bool PandaOverlapping;
    

    public bool Cooldown;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Cooldown == false)
        {
            StartCoroutine(CooldownCheck());

            if (other.tag == "Sink")
            {
                SinkOverlap.SetActive(true);
                SinkOverlapping = true;

                FireExtinguisherOverlap.SetActive(false);
                BinOverlap.SetActive(false);
                OvenOverlap.SetActive(false);
                ChoppingBoardOverlap.SetActive(false);
                FridgeOverlap.SetActive(false);
                BroomOverlap.SetActive(false);
                BlenderOverlap.SetActive(false);
                KitchenExitOverlap.SetActive(false);
                PlatePlace1Overlap.SetActive(false);
                PlatePlace2Overlap.SetActive(false);
            }

            if (other.tag == "FireExtinguisher")
            {
                FireExtinguisherOverlap.SetActive(true);
                FireExtinguisherOverlapping = true;

                SinkOverlap.SetActive(false);
                BinOverlap.SetActive(false);
                OvenOverlap.SetActive(false);
                ChoppingBoardOverlap.SetActive(false);
                FridgeOverlap.SetActive(false);
                BroomOverlap.SetActive(false);
                BlenderOverlap.SetActive(false);
                KitchenExitOverlap.SetActive(false);
                PlatePlace1Overlap.SetActive(false);
                PlatePlace2Overlap.SetActive(false);
            }

            if (other.tag == "TrashBin")
            {
                BinOverlap.SetActive(true);
                BinOverlapping = true;

                SinkOverlap.SetActive(false);
                FireExtinguisherOverlap.SetActive(false);
                OvenOverlap.SetActive(false);
                ChoppingBoardOverlap.SetActive(false);
                FridgeOverlap.SetActive(false);
                BroomOverlap.SetActive(false);
                BlenderOverlap.SetActive(false);
                KitchenExitOverlap.SetActive(false);
                PlatePlace1Overlap.SetActive(false);
                PlatePlace2Overlap.SetActive(false);
            }

            if (other.tag == "Oven")
            {
                OvenOverlap.SetActive(true);
                OvenOverlapping = true;

                SinkOverlap.SetActive(false);
                FireExtinguisherOverlap.SetActive(false);
                BinOverlap.SetActive(false);
                ChoppingBoardOverlap.SetActive(false);
                FridgeOverlap.SetActive(false);
                BroomOverlap.SetActive(false);
                BlenderOverlap.SetActive(false);
                KitchenExitOverlap.SetActive(false);
                PlatePlace1Overlap.SetActive(false);
                PlatePlace2Overlap.SetActive(false);
            }

            if (other.tag == "ChoppingBoard")
            {
                ChoppingBoardOverlap.SetActive(true);
                ChoppingBoardOverlapping = true;

                SinkOverlap.SetActive(false);
                FireExtinguisherOverlap.SetActive(false);
                BinOverlap.SetActive(false);
                OvenOverlap.SetActive(false);
                FridgeOverlap.SetActive(false);
                BroomOverlap.SetActive(false);
                BlenderOverlap.SetActive(false);
                KitchenExitOverlap.SetActive(false);
                PlatePlace1Overlap.SetActive(false);
                PlatePlace2Overlap.SetActive(false);
            }

            if (other.tag == "Fridge")
            {
                FridgeOverlap.SetActive(true);
                FridgeOverlapping = true;

                SinkOverlap.SetActive(false);
                FireExtinguisherOverlap.SetActive(false);
                BinOverlap.SetActive(false);
                OvenOverlap.SetActive(false);
                ChoppingBoardOverlap.SetActive(false);
                BroomOverlap.SetActive(false);
                BlenderOverlap.SetActive(false);
                KitchenExitOverlap.SetActive(false);
                PlatePlace1Overlap.SetActive(false);
                PlatePlace2Overlap.SetActive(false);
            }

            if (other.tag == "Broom")
            {
                BroomOverlap.SetActive(true);
                BroomOverlapping = true;

                SinkOverlap.SetActive(false);
                FireExtinguisherOverlap.SetActive(false);
                BinOverlap.SetActive(false);
                OvenOverlap.SetActive(false);
                ChoppingBoardOverlap.SetActive(false);
                FridgeOverlap.SetActive(false);
                BlenderOverlap.SetActive(false);
                KitchenExitOverlap.SetActive(false);
                PlatePlace1Overlap.SetActive(false);
                PlatePlace2Overlap.SetActive(false);
            }

            if (other.tag == "Blender")
            {
                BlenderOverlap.SetActive(true);
                BlenderOverlapping = true;

                SinkOverlap.SetActive(false);
                FireExtinguisherOverlap.SetActive(false);
                BinOverlap.SetActive(false);
                OvenOverlap.SetActive(false);
                ChoppingBoardOverlap.SetActive(false);
                FridgeOverlap.SetActive(false);
                BroomOverlap.SetActive(false);
                KitchenExitOverlap.SetActive(false);
                PlatePlace1Overlap.SetActive(false);
                PlatePlace2Overlap.SetActive(false);
            }

            if (other.tag == "KitchenExit")
            {
                KitchenExitOverlap.SetActive(true);
                KitchenExitOverlapping = true;

                SinkOverlap.SetActive(false);
                FireExtinguisherOverlap.SetActive(false);
                BinOverlap.SetActive(false);
                OvenOverlap.SetActive(false);
                ChoppingBoardOverlap.SetActive(false);
                FridgeOverlap.SetActive(false);
                BroomOverlap.SetActive(false);
                BlenderOverlap.SetActive(false);
                PlatePlace1Overlap.SetActive(false);
                PlatePlace2Overlap.SetActive(false);
            }

            if (other.tag == "PlatePlace1")
            {
                PlatePlace1Overlap.SetActive(true);
                PlatePlace1Overlapping = true;

                SinkOverlap.SetActive(false);
                FireExtinguisherOverlap.SetActive(false);
                BinOverlap.SetActive(false);
                OvenOverlap.SetActive(false);
                ChoppingBoardOverlap.SetActive(false);
                FridgeOverlap.SetActive(false);
                BroomOverlap.SetActive(false);
                BlenderOverlap.SetActive(false);
                KitchenExitOverlap.SetActive(false);
                PlatePlace2Overlap.SetActive(false);
            }

            if (other.tag == "PlatePlace2")
            {
                PlatePlace2Overlap.SetActive(true);
                PlatePlace2Overlapping = true;

                SinkOverlap.SetActive(false);
                FireExtinguisherOverlap.SetActive(false);
                BinOverlap.SetActive(false);
                OvenOverlap.SetActive(false);
                ChoppingBoardOverlap.SetActive(false);
                FridgeOverlap.SetActive(false);
                BroomOverlap.SetActive(false);
                BlenderOverlap.SetActive(false);
                KitchenExitOverlap.SetActive(false);
                PlatePlace1Overlap.SetActive(false);
            }

            //customers in cafe room, player is unable to be overlapping with any kitchen items

            if(other.tag == "PandaCustomer")
            {
                PandaOverlap.SetActive(true);
                PandaOverlapping = true;
               
            }
        }

 
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Sink")
        {
            SinkOverlap.SetActive(false);
            SinkOverlapping = false;
        }

        if (other.tag == "FireExtinguisher")
        {
            FireExtinguisherOverlap.SetActive(false);
            FireExtinguisherOverlapping = false;

        }

        if (other.tag == "TrashBin")
        {
            BinOverlap.SetActive(false);
            BinOverlapping = false; 
        }

        if (other.tag == "Oven")
        {
            OvenOverlap.SetActive(false);
            OvenOverlapping = false;
        }

        if (other.tag == "ChoppingBoard")
        {
            ChoppingBoardOverlap.SetActive(false);
            ChoppingBoardOverlapping = false;   
        }

        if (other.tag == "Fridge")
        {
            FridgeOverlap.SetActive(false);
            FridgeOverlapping = false;
        }

        if (other.tag == "Broom")
        {
            BroomOverlap.SetActive(false);
            BroomOverlapping = false;
        }

        if (other.tag == "Blender")
        {
            BlenderOverlap.SetActive(false);
        }

        if (other.tag == "KitchenExit")
        {
            KitchenExitOverlap.SetActive(false);
        }

        if (other.tag == "PlatePlace1")
        {
            PlatePlace1Overlap.SetActive(false);
        }

        if (other.tag == "PlatePlace2")
        {
            PlatePlace2Overlap.SetActive(false);
        }

        if (other.tag == "PandaCustomer")
        {
            PandaOverlap.SetActive(false);
        }
    }

    IEnumerator CooldownCheck()
    {
        Cooldown = true;
        yield return new WaitForSecondsRealtime(0.15f);
        Cooldown = false;
    }
}
