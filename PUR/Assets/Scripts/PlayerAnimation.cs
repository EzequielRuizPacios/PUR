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
        if (player.State == Player.PlayerState.Running)
        {
            playerAnimator.Play("run");
        }

        if (player.State == Player.PlayerState.ShortJumping)
        {
            playerAnimator.Play("shortJump");
        }

        if (player.State == Player.PlayerState.LongJumping)
        {
            playerAnimator.Play("longJump");
        }

        Debug.Log(player.State);
    }
}
