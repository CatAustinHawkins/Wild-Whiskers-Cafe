using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNoise : MonoBehaviour
{
    public AudioSource[] Speak;
    public AudioSource Woof;

    public int random;
    public int random2;


   public void Clicked()
    {
        random = Random.Range(0, 4);
        random2 = Random.Range(0, 105);

        if(random2 == 100)
        {
            Woof.Play();
        }
        else
        {
            Speak[random].Play();

        }
    }
}
