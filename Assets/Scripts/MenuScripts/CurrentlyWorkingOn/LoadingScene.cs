using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
//This script is used on the loading scene, to pre-load the gameplay scene.

//Used on LoadingScreen_ST and LoadingScreen_FT 

public class LoadingScene : MonoBehaviour
{
    public Slider LoadingBar; //the slider featured on the loading screen, to show progress
    public string SceneToLoad; //either storymode or foodtruck
    public float fillSpeed = 0.4f; // speed at which the bar smooths toward progress

    public RectTransform HandleBar;

    public TextMeshProUGUI LoadingText;

    void Start()
    {
        StartCoroutine(LoadNextLevel()); //start the load next level coroutine
        StartCoroutine(LoadingTextEdit());

        //Can change handlebar
        LoadingBar.handleRect = HandleBar;
    }




    IEnumerator LoadNextLevel()
    {
        float startTime = Time.time;

        // Begin loading the next scene but don't allow activation yet
        AsyncOperation loadLevel = SceneManager.LoadSceneAsync(SceneToLoad);
        loadLevel.allowSceneActivation = false;

        // Track "fake" progress for smooth animation
        float displayedProgress = 0f;

        while (loadLevel.progress < 0.9f)
        {
            // target progress is normalized (0–1)
            float targetProgress = Mathf.Clamp01(loadLevel.progress / 0.9f);

            // Smoothly move the displayed progress toward target progress
            displayedProgress = Mathf.MoveTowards(displayedProgress, targetProgress, fillSpeed * Time.deltaTime);

            LoadingBar.value = displayedProgress;

            yield return null;
        }

        // Scene is done loading, fill to 100%
        while (displayedProgress < 1f)
        {
            displayedProgress = Mathf.MoveTowards(displayedProgress, 1f, fillSpeed * Time.deltaTime);
            LoadingBar.value = displayedProgress;
            yield return null;
        }

        // Calculate elapsed load time
        float elapsed = Time.time - startTime;

        // If it loaded in under 4 seconds, wait the remaining time
        if (elapsed < 4f)
        {
            yield return new WaitForSeconds(4f - elapsed);
        }

        // Activate the scene
        loadLevel.allowSceneActivation = true;
    }

    IEnumerator LoadingTextEdit()
    {
        LoadingText.text = "Loading.";
        yield return new WaitForSecondsRealtime(0.5f);
        LoadingText.text = "Loading..";
        yield return new WaitForSecondsRealtime(0.5f);
        LoadingText.text = "Loading...";
        yield return new WaitForSecondsRealtime(0.5f);
        StartCoroutine(LoadingTextEdit());
    }
}
