using UnityEngine;

//This script is used to take the player from one room to another. For example, from the kitchen to the cafe.

public class Arrow : MonoBehaviour
{
    public GameObject Camera; //get the camera gameobject so it can be moved 
    public Vector3 NewCameraPosition; //the new position for the camera
    public GameObject Player; //get the player gameobject so it can be moved
    public Vector3 NewPlayerPosition; //the new position for the camera

    public Tutorial TutorialScript;
    public bool GoToKitchen;
    public bool GoToRoom;

    private void OnTriggerEnter2D(Collider2D collision) //when the player collides with the arrow
    {
        Camera.transform.position = NewCameraPosition; //update the cameras position
        Player.transform.position = NewPlayerPosition; //update the players position
        if(GoToRoom && TutorialScript.TutorialImages == 17)
        {
            TutorialScript.NextTutorial();
        }

        if (GoToKitchen && TutorialScript.TutorialImages == 10)
        {
            TutorialScript.NextTutorial();
        }
    }
}
