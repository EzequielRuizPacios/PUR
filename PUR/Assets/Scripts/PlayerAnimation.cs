using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerAnimation : MonoBehaviour
{
  private Player player;
  private Animator playerAnimator;

  private void OnEnable()
  {
    player.onPlayerStateChanged += SetPlayerAnimation;
  }

  private void OnDisable()
  {
    player.onPlayerStateChanged -= SetPlayerAnimation;
  }

  private void Awake()
  {
    player = GameObject.Find("Player").GetComponent<Player>();
    playerAnimator = GameObject.Find("Player").GetComponent<Animator>();
  }

  private void SetPlayerAnimation(Player.PlayerState newState)
  {
    if (newState == Player.PlayerState.Running)
    {
      playerAnimator.Play("run");
    }

    if (newState == Player.PlayerState.ShortJumping)
    {
      playerAnimator.Play("shortJump");
    }

    if (newState == Player.PlayerState.LongJumping)
    {
      playerAnimator.Play("longJump");
    }

    if (newState == Player.PlayerState.Dashing)
    {
      playerAnimator.Play("dash");
    }
  }
}
