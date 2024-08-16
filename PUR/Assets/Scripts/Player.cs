using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public delegate void OnPlayerDeath();
    public OnPlayerDeath onPlayerDeath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacle"))
        {
            onPlayerDeath?.Invoke();
        }
    }
}
