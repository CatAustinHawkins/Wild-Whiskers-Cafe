using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public float speed = 14; //speed of the player when they move
    public Vector3 target; //their target position

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position += transform.right * -moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position += transform.right * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position += transform.up * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position += transform.up * -moveSpeed * Time.deltaTime;
        }
    }

    void previousmove()
    {
        if (Input.GetMouseButtonDown(0)) //if they hold down the left (0) mouse button
        {
            if (EventSystem.current.IsPointerOverGameObject()) //if they arent clicking UI
            {
                Debug.Log("Clicked on the UI");
                return;
            }
            else
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition); //find where they clicked
                target.z = transform.position.z; //set the target.z value to the players tranform.position.z value, as the player won't move in the Z axis
            }

        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime); //move the player

    }
}
