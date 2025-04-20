using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueClose : MonoBehaviour
{

    public GameObject DialogueBox;

    public void Clicked()
    {
        DialogueBox.SetActive(false);
    }



}
