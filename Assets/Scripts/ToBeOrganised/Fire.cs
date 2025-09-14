using System.Collections;
using UnityEngine;

//This script controls the fires, and is enabled when the oven catches on fire.

public class Fire : MonoBehaviour
{
    public int RandomValue; //to spawn a random fire in the FireArray

    public GameObject[] FireArray; //stores all the fires, apart from the oven fire. (FireFridge, FireChoppingBoard, FireSink, FireTrash, FireBlender and FireBroom)

    public GameObject FireOven; //the oven fire game object

    private void OnEnable() //when the FireManager is enabled by the interact script, when the oven catches on fire
    {
        StartCoroutine(FireSpawn()); //start the fire spawn coroutine
        FireOven.SetActive(true); //enable the fire on the oven
    }

    IEnumerator FireSpawn() //Coroutine to spawn fire
    {
        RandomValue = Random.Range(5, 15); //choose a random number from 2, 3, 4 or 5.
        yield return new WaitForSecondsRealtime(RandomValue); //wait the randomvalue seconds, to stop the fire from being predictable
        RandomValue = Random.Range(0, 5);//choose a random number from 0, 1, 2, 3, 4 or 5
        FireArray[RandomValue].SetActive(enabled); //spawn a random gameobject from the array, to prevent predictability.
        StartCoroutine(FireSpawn()); //then, restart the firespawn coroutine
    }
}
