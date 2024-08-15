using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    //References
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject backgroundImage;

    public void ShowPauseMenu()
    {
        pauseMenu.SetActive(true);
        backgroundImage.SetActive(true);
        Time.timeScale = 0f;
        GameManager.Instance.IsGamePaused = true;
    }

    public void HidePauseMenu()
    {
        pauseMenu.SetActive(false);
        backgroundImage.SetActive(false);
        Time.timeScale = 1f;
        GameManager.Instance.IsGamePaused = false;
    }
}
