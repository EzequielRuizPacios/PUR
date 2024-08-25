using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Reference
    public static GameManager Instance { get; private set; }
    [SerializeField] private SceneLevelManager sceneLevelManager;
    [SerializeField] private Player player;

    private bool _isGamePaused = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        sceneLevelManager = GameObject.Find("SceneLevelManager").GetComponent<SceneLevelManager>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void OnEnable()
    {
        player.onPlayerDeath += ShowLostScene;
    }

    private void OnDisable()
    {
        player.onPlayerDeath -= ShowLostScene;
    }

    private void ShowLostScene()
    {
        sceneLevelManager.ChangeSceneTo("Perdiste");
    }

    public bool IsGamePaused { get => _isGamePaused; set => _isGamePaused = value; }
}
