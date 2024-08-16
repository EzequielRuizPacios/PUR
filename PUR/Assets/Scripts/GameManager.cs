using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // [SerializeField] private Player player;
    public static GameManager Instance { get; private set; }
    
    
    private bool _isGamePaused = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public bool IsGamePaused { get => _isGamePaused; set => _isGamePaused = value; }

}
