using System.Collections;
using UnityEngine;

public class Puddles : MonoBehaviour
{

    public int RandomValue;

    public GameObject[] PuddleArrays;

    void Start()
    {
        StartCoroutine(PuddleSpawn());
    }

    IEnumerator PuddleSpawn()
    {
        RandomValue = Random.Range(60, 120);
        yield return new WaitForSecondsRealtime(RandomValue);
        RandomValue = Random.Range(0, 5);
        PuddleArrays[RandomValue].SetActive(enabled);
        StartCoroutine(PuddleSpawn());


    }

}
