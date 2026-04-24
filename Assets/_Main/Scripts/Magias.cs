using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Thundaga : MonoBehaviour
{
    public float speed = 8f;
    public float damage = 15f;
    public float lifeTime = 2f;

    private Rigidbody2D rb;

    void Start()
    {
       
        // Destruir después de cierto tiempo
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Detecta daño
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
        }

        // Se destruye al impactar
        Destroy(gameObject);
    }
}
