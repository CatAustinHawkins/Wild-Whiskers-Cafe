using System.Collections;
using UnityEngine;

//This script is on the puddle manager, controlling puddle spawning

public class Puddles : MonoBehaviour
{
    public int RandomValue; //to spawn a random puddle from puddle array

    public GameObject[] PuddleArrays; //stores all the puddle gameobjects

    void Start()
    {
        StartCoroutine(PuddleSpawn()); //start spawning puddles
    }

    IEnumerator PuddleSpawn()
    {
        RandomValue = Random.Range(60, 120); //choose a random number from 60-120
        yield return new WaitForSecondsRealtime(RandomValue); //wait a random number of seconds, from 1 minute to 2 minute
        RandomValue = Random.Range(0, 5); //choose a random number from 0-5
        PuddleArrays[RandomValue].SetActive(enabled); //spawn a random puddle
        StartCoroutine(PuddleSpawn()); //restart the coroutine
    }
}
