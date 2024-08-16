using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Reference
    [SerializeField] private Player player;
    public static GameManager Instance { get; private set; }
    
    
    private bool _isGamePaused = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        player = GameObject.Find("Player").GetComponent<Player>();
    }

    public bool IsGamePaused { get => _isGamePaused; set => _isGamePaused = value; }

}
