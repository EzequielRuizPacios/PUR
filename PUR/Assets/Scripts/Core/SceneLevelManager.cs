using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLevelManager : MonoBehaviour
{
  // Start is called before the first frame update
  public void ChangeScene(string sceneName)
  {
    StartCoroutine(ChangeSceneTo(sceneName, 0f));
  }

  public void ChangeSceneWithDelay(string sceneName)
  {
    StartCoroutine(ChangeSceneTo(sceneName, 2.5f));
  }

  IEnumerator ChangeSceneTo(string sceneName, float delayTime)
  {
    yield return new WaitForSecondsRealtime(delayTime);
    Time.timeScale = 1f;
    SceneManager.LoadScene(sceneName);
  }

  public void QuitGame()
  {
    Application.Quit();
  }
}
