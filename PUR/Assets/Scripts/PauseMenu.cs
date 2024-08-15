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
        GameManager.Instance.IsGamePaused = true;
    }

    public void HidePauseMenu()
    {
        pauseMenu.SetActive(false);
        backgroundImage.SetActive(false);
        GameManager.Instance.IsGamePaused = false;
    }
}
