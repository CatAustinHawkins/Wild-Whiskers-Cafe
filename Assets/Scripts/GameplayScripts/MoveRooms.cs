using UnityEngine;

//This script is used when the player moves from room to room
//Bedroom -> Cafe -> Kitchen
//Kitchen -> Cafe -> Bedroom

public class MoveRooms : MonoBehaviour
{

    public GameObject Camera; //get the camera gameobject so it can be moved 
    public Vector3 NewCameraPosition; //the new position for the camera
    public GameObject Player; //get the player gameobject so it can be moved
    public Vector3 NewPlayerPosition; //the new position for the camera 

    public PlayerScript PlayerMove; //get the player's script
    public Tutorial TutorialScript; //get the tutorial script

    public bool InCafe; //is the player in the cafe
    public bool InKitchen; //is the player in the kitchen
    public bool InBedroom; //is the player in the bedroom

    public GameObject LeftButton; //the left move to room gameobject
    public GameObject RightButton; //the right move to room gameobject

    public void Right() //on the RightButton
    {

        if(InCafe) //if in cafe, move to kitchen
        {
            Debug.Log("Test");
            Camera.transform.position = new Vector3(103, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(87, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position; //freeze the players movement, to avoid issues
            PlayerMove.speed = 14;

            if (TutorialScript.TutorialImages == 12) //if the player is on the 31st tutorial section
            {
                TutorialScript.NextTutorial(); //start the next tutorial prompt
            }

            InKitchen = true; //the player is in the kitchen
            InCafe = false; //the player is no longer in the cafe

            RightButton.SetActive(false); //as the player can no longer go to the right, disable the rightbutton.
        }

        if(InBedroom) //if in bedroom, move to cafe
        {
            Camera.transform.position = new Vector3(0, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(-21, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position; //freeze the players movement, to avoid issues
            PlayerMove.speed = 14;

            InBedroom = false; //the player is no longer in the bedroom
            InCafe = true; //the player is in the cafe

            RightButton.SetActive(true); //as the player can now go to the right, enable the right button
            LeftButton.SetActive(true); //as the player can now go to the left, enable the left button
        }
    }

    public void Left() //on the LeftButton
    {
        if (InCafe) //if in cafe, move to bedroom
        {
            Camera.transform.position = new Vector3(-120, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(-110, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position; //freeze the players movement, to avoid issues
            PlayerMove.speed = 14;

            if (TutorialScript.TutorialImages == 31) //if the player is on the 31st tutorial section
            {
                TutorialScript.NextTutorial(); //start the next tutorial prompt
            }

            InCafe = false; //the player is no longer in the cafe
            InBedroom = true; //the player is in the bedroom

            LeftButton.SetActive(false); //as the player can no longer go to the left, disable the rightbutton.
        }

        if (InKitchen) //if in kitchen, move to cafe
        {
            Camera.transform.position = new Vector3(0, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(21, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position; //freeze the players movement, to avoid issues
            PlayerMove.speed = 14;

            InKitchen = false; //the player is no longer in the kitchen
            InCafe = true; //the player is in the cafe

            RightButton.SetActive(true); //as the player can now go to the right, enable the right button
            LeftButton.SetActive(true); //as the player can now go to the left, enable the left button
        }
    }
}
