using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float lifeSpan = 10f;
    private float timeLapsedSinceSpawn = 0f;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Translate(-0.01f, 0f, 0f);
        timeLapsedSinceSpawn += Time.deltaTime;
        if(timeLapsedSinceSpawn > lifeSpan)
        {
            DestroyImmediate(gameObject);
        }
    }
}
