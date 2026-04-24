using UnityEngine;

public class EnemigoBasico : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidad = 2f;
    public Transform puntoIzquierdo;
    public Transform puntoDerecho;

    [Header("Tags")]
    public string tagJugador = "Player";
    public string tagMagia = "Magias";

    bool yendoDerecha = true;

    void Update()
    {
        Mover();
    }

    void Mover()
    {
        if (yendoDerecha)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                new Vector2(puntoDerecho.position.x, transform.position.y),
                velocidad * Time.deltaTime
            );

            if (transform.position.x >= puntoDerecho.position.x - 0.02f)
            {
                yendoDerecha = false;
                GirarSprite();
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                new Vector2(puntoIzquierdo.position.x, transform.position.y),
                velocidad * Time.deltaTime
            );

            if (transform.position.x <= puntoIzquierdo.position.x + 0.02f)
            {
                yendoDerecha = true;
                GirarSprite();
            }
        }
    }

    void GirarSprite()
    {
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    void ProcesarImpacto(GameObject obj)
    {
        if (obj.CompareTag(tagMagia))
        {
            Destroy(gameObject);
            return;
        }

        if (obj.CompareTag(tagJugador))
        {
            Vida vida = obj.GetComponent<Vida>();

            if (vida != null)
            {
                vida.Vidas = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        ProcesarImpacto(other.gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ProcesarImpacto(collision.gameObject);
    }
}