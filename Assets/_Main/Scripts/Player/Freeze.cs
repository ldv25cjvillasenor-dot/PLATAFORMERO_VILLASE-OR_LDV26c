using UnityEngine;

public class Freeze : MonoBehaviour
{
    public float speed = 4f;
    public float lifeTime = 3f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = transform.right * speed;

        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Congelado");
        }
    }
}