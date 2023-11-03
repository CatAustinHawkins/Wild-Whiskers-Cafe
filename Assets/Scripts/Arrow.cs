using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public GameObject Camera;
    public Vector3 NewCameraPosition;
    public GameObject Player;
    public Vector3 NewPlayerPosition;

    // arrow
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Camera.transform.position = NewCameraPosition;
        Player.transform.position = NewPlayerPosition;
    }

}
