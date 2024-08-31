using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
  // Reference
  private Rigidbody2D rb2d;

  [SerializeField] private float lifeSpan = 10f;
  [SerializeField] private float force = 10f;
  [SerializeField] private float timeLapsedSinceSpawn = 0f;
  [SerializeField] private bool esEscenario;
  [SerializeField] private float velocityVert = 10f;
  private void Awake()
  {
    rb2d = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    timeLapsedSinceSpawn += Time.deltaTime;

        if (timeLapsedSinceSpawn > lifeSpan)
        {
          Debug.Log("tiempo y tiempoVida" + timeLapsedSinceSpawn + ", " + lifeSpan);
          DestroyImmediate(gameObject);
        }
  }

  private void FixedUpdate()
  {
    if (esEscenario == false)
      rb2d.AddForce(Vector2.left * force, ForceMode2D.Force);
    else
      transform.Translate(-1f * Time.deltaTime * velocityVert, 0f, 0f);
  }
}
