using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this manages the customer spawning
//depends on level



public class CustomerManager : MonoBehaviour
{

    public GameObject[] Customers;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCustomer();
    }


    public void SpawnCustomer()
    {
        //int random = Random.Range(0, 10);
        Customers[0].SetActive(true);
        StartCoroutine(CustomerWait());

    }
    IEnumerator CustomerWait()
    {
        Debug.Log("Waiting to Spawn Customer");
        yield return new WaitForSeconds(4);
        SpawnCustomer();
    }

}
