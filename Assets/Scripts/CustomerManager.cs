using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is intended to control when customers are spawned in


public class CustomerManager : MonoBehaviour
{

    public GameObject[] Customers; //Plan to have an array of customers which can be spawned

  
    void Start()
    {
        SpawnCustomer(); //when the game starts, spawn a customer
    }


    public void SpawnCustomer()
    {
        Customers[0].SetActive(true); //Enable the first customer in the array
        StartCoroutine(CustomerWait()); //Start a coroutine

    }
    IEnumerator CustomerWait()
    {
        Debug.Log("Waiting to Spawn Customer"); //Debug log to show that the manager is waiting
        yield return new WaitForSeconds(4); //Wait 4 seconds
        SpawnCustomer(); //Spawn next customer
    }

}
