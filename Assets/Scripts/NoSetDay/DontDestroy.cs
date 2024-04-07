using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    public string GameObjectTag; //the string of the gameobject that I want to keep between scenes

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(GameObjectTag); //get an array of every object with that tag in the scene

        if (objs.Length > 1) //if theres more than 1
        {
            Destroy(this.gameObject); //delete the current gameobject
        }

        DontDestroyOnLoad(this.gameObject); //if there wasn't more than 1, keep this gameobject.
    }
}
