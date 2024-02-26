using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public int RandomValue;

    public GameObject[] FireArrays;

    // Start is called before the first frame update
    void Start()
    {
        FireBegins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FireSpawn()
    {
        RandomValue = Random.Range(2, 5);
        yield return new WaitForSecondsRealtime(RandomValue);
        RandomValue = Random.Range(0, 5);
        FireArrays[RandomValue].SetActive(enabled);
        StartCoroutine(FireSpawn());


    }

    public void FireBegins()
    {
        StartCoroutine(FireSpawn());
    }


}
