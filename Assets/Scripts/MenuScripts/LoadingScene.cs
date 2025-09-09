using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This script is used on the loading scene, to pre-load the gameplay scene. 

public class LoadingScene : MonoBehaviour
{
    public Slider LoadingBar; //the slider featured on the loading screen, to show progress

    void Start()
    {
        StartCoroutine(LoadNextLevel()); //start the load next level coroutine
    }

    IEnumerator LoadNextLevel()
    {
        AsyncOperation loadLevel = SceneManager.LoadSceneAsync("StoryModeScene"); //start loading the gameplay scene

        while (!loadLevel.isDone) //while the scene is loading
        {
            LoadingBar.value = Mathf.Clamp01(loadLevel.progress / 9f); //change the value of the loading bar slider depending on load progress
            yield return null;
        }
    }
}
