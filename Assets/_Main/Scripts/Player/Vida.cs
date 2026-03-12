using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int Vidas = 5;
    public float FuerzaRepelenteDaño = 10f;
    public Vector3 DireccionRepelenteDaño = new Vector3(0, -1, 0);

    void Update()
    {
        if (Vidas <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnvironmentDamage")
        {
            Vidas -= 1;
            GetComponent<Rigidbody2D>().AddForce(DireccionRepelenteDaño * FuerzaRepelenteDaño, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "ItemVida")
        {
            
            
                Vidas += 1;
            Destroy(collider2D.gameObject);
        }
    }
}