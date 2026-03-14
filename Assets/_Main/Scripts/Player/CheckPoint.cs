using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private bool activated = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!activated && collision.CompareTag("Player"))
        {
            Vida vida = collision.GetComponent<Vida>();

            if (vida != null)
            {
                vida.SetSpawnPoint(transform);
                activated = true;
            }
        }
    }
}