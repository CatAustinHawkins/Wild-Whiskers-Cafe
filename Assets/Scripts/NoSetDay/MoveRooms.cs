using UnityEngine;

public class MoveRooms : MonoBehaviour
{

    public GameObject Camera; //get the camera gameobject so it can be moved 
    public Vector3 NewCameraPosition; //the new position for the camera
    public GameObject Player; //get the player gameobject so it can be moved
    public Vector3 NewPlayerPosition; //the new position for the camera 

    public PlayerScript PlayerMove;
    public Tutorial TutorialScript;

    public bool InCafe;
    public bool InKitchen;
    public bool InBedroom;

    public GameObject LeftButton;
    public GameObject RightButton;

    public void Right()
    {

        if(InCafe) //move to kitchen
        {
            Debug.Log("Test");
            Camera.transform.position = new Vector3(103, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(87, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position;

            if (TutorialScript.TutorialImages == 12)
            {
                TutorialScript.NextTutorial();
            }

            InKitchen = true;
            InCafe = false;

            RightButton.SetActive(false);
        }

        if(InBedroom) //move to cafe
        {
            Camera.transform.position = new Vector3(0, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(-21, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position;

            InBedroom = false;
            InCafe = true;

            RightButton.SetActive(true);
            LeftButton.SetActive(true);
        }
    }

    public void Left()
    {
        if (InCafe) //move to bedroom
        {
            Camera.transform.position = new Vector3(-120, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(-110, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position;
            if (TutorialScript.TutorialImages == 31)
            {
                TutorialScript.NextTutorial();
            }

            InCafe = false;
            InBedroom = true;

            LeftButton.SetActive(false);
        }

        if (InKitchen) //move to cafe
        {
            Camera.transform.position = new Vector3(0, 0, -10); //update the cameras position
            Player.transform.position = new Vector3(21, -4.5f, 0); //update the players position
            PlayerMove.target = PlayerMove.transform.position;

            InKitchen = false;
            InCafe = true;

            RightButton.SetActive(true);
            LeftButton.SetActive(true);
        }
    }

}
