using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int Vidas = 1;
    public int coinPoints = 10;

    public float FuerzaRepelenteDaño = 10f;
    public Vector3 DireccionRepelenteDaño = new Vector3(0, -1, 0);

    public Transform spawnPoint;

    public AudioSource coinSound;

    void Update()
    {
        if (Vidas <= 0)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = spawnPoint.position;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.zero;

        Vidas = 5;
    }

    public void SetSpawnPoint(Transform newSpawn)
    {
        spawnPoint = newSpawn;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnvironmentDamage"))
        {
            Vidas -= 1;
            GetComponent<Rigidbody2D>().AddForce(DireccionRepelenteDaño * FuerzaRepelenteDaño, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("ItemVida"))
        {
            ScoreManager.instance.AddScore(coinPoints);

            coinSound.Play();

            Destroy(collider2D.gameObject);
        }
    }
}