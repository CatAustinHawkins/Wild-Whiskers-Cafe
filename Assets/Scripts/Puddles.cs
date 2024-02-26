using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddles : MonoBehaviour
{

    public int RandomValue;

    public GameObject[] PuddleArrays;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PuddleSpawn());
    }


    IEnumerator PuddleSpawn()
    {
        RandomValue = Random.Range(20, 50);
        yield return new WaitForSecondsRealtime(RandomValue);
        RandomValue = Random.Range(0, 5);
        PuddleArrays[RandomValue].SetActive(enabled);
        StartCoroutine(PuddleSpawn());


    }

}
