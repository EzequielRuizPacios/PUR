using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // References
    private Rigidbody2D myRb2d;
    private CircleCollider2D sidewalkChecker;


    private float shortJumpForce = 300f;
    private float longJumpForce = 450f;
    private bool canJump = true;

    private void Awake()
    {
        myRb2d = GetComponent<Rigidbody2D>();
        sidewalkChecker = GetComponent<CircleCollider2D>();
    }
    public void ShortJumpCommand()
    {
        if (canJump && !GameManager.Instance.IsGamePaused)
        {
            myRb2d.AddForce(new Vector2(0f, shortJumpForce));
            canJump = false;
        }
    }

    public void LongJumpCommand()
    {
        if (canJump && !GameManager.Instance.IsGamePaused)
        {
            myRb2d.AddForce(new Vector2(0f, longJumpForce));
            canJump = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Sidewalk"))
        {
            canJump = true;
        }
    }
}
