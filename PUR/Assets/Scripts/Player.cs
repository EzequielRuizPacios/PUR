using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
  public enum PlayerState
  {
    Running,
    ShortJumping,
    LongJumping,
    Dashing,
    Dead
  }
  public delegate void OnPlayerDeath();
  public OnPlayerDeath onPlayerDeath;
  public delegate void OnPlayerStateChanged(PlayerState state);
  public OnPlayerStateChanged onPlayerStateChanged;

  private PlayerState _state;
  public PlayerState State { get => _state; }



  private void Start()
  {
    SetPlayerState(PlayerState.Running);
  }


  public void SetPlayerState(PlayerState newState)
  {
    _state = newState;
    onPlayerStateChanged?.Invoke(_state);
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Obstacle"))
    {
      onPlayerDeath?.Invoke();
    }
  }
}
