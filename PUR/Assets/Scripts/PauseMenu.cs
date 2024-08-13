using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    //References
    [SerializeField] private GameObject pauseMenu;

    public void ShowPauseMenu()
    {
        pauseMenu.SetActive(true);
        GameManager.Instance.IsGamePaused = true;
    }

    public void HidePauseMenu()
    {
        pauseMenu.SetActive(false);
        GameManager.Instance.IsGamePaused = false;
    }
}
