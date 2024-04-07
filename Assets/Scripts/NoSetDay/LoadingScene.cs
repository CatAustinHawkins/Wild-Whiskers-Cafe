using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadingScene : MonoBehaviour
{
    public Slider LoadingBar;

    void Start()
    {
        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel()
    {
        AsyncOperation loadLevel = SceneManager.LoadSceneAsync("Tutorial");

        while (!loadLevel.isDone)
        {
            LoadingBar.value = Mathf.Clamp01(loadLevel.progress / 9f);
            yield return null;
        }
    }
}
