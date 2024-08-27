using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommands : MonoBehaviour
{
  // References
  [SerializeField] private BoxCollider2D boxCollider2d_top;
  private Rigidbody2D myRb2d;
  private CircleCollider2D sidewalkChecker;
  private Player player;



  private float shortJumpForce = 300f;
  private float longJumpForce = 450f;
  private bool isGrounded = true;

  private void Awake()
  {
    myRb2d = GetComponent<Rigidbody2D>();
    sidewalkChecker = GetComponent<CircleCollider2D>();
    player = GameObject.Find("Player").GetComponent<Player>();
  }
  public void ShortJumpCommand()
  {
    if (isGrounded && !GameManager.Instance.IsGamePaused)
    {
      myRb2d.AddForce(new Vector2(0f, shortJumpForce));
      isGrounded = false;
      player.SetPlayerState(Player.PlayerState.ShortJumping);
    }
  }

  public void LongJumpCommand()
  {
    if (isGrounded && !GameManager.Instance.IsGamePaused)
    {
      myRb2d.AddForce(new Vector2(0f, longJumpForce));
      isGrounded = false;
      player.SetPlayerState(Player.PlayerState.LongJumping);
    }
  }

  public void DashCommand()
  {
    if (isGrounded && !GameManager.Instance.IsGamePaused)
    {
      player.SetPlayerState(Player.PlayerState.Dashing);
      boxCollider2d_top.enabled = false;
    }
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.transform.CompareTag("Sidewalk"))
    {
      isGrounded = true;
      player.SetPlayerState(Player.PlayerState.Running);
    }
  }

  public void ActivateTopBoxCollider2d()
  {
    boxCollider2d_top.enabled = true;
  }
}
