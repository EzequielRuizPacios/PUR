using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Reference
    private Rigidbody2D rb2d;

    private float lifeSpan = 10f;
    private float force = 10f;
    private float timeLapsedSinceSpawn = 0f;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        timeLapsedSinceSpawn += Time.deltaTime;

        if (timeLapsedSinceSpawn > lifeSpan)
        {
            DestroyImmediate(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb2d.AddForce(Vector2.left * force, ForceMode2D.Force);
        //transform.Translate(-1f * Time.deltaTime, 0f, 0f);
    }
}
