using UnityEngine;

public class CastFiraga : MonoBehaviour
{
    public GameObject firagaPrefab;
    public Transform spawnPoint;

    public float distancia = 1f;
    public float tiempoVida = 3f;

    public float tiempoEntreDisparos = 0.2f; // intervalo entre ráfagas

    public string[] tagsDestruir; // Tags configurables en Inspector

    bool mirandoDerecha = true;

    public float siguienteDisparo = 0f;

    void Update()
    {
        // Mirar derecha
        if (Input.GetKeyDown(KeyCode.D))
        {
            mirandoDerecha = true;

            spawnPoint.localPosition = new Vector3(distancia, 0, 0);
            spawnPoint.rotation = Quaternion.Euler(0, 0, 0);
        }

        // Mirar izquierda
        if (Input.GetKeyDown(KeyCode.A))
        {
            mirandoDerecha = false;

            spawnPoint.localPosition = new Vector3(-distancia, 0, 0);
            spawnPoint.rotation = Quaternion.Euler(0, 180, 0);
        }

        // Disparo en ráfaga manteniendo botón
        if (Input.GetKey(KeyCode.Q) && Time.time >= siguienteDisparo)
        {
            siguienteDisparo = Time.time + tiempoEntreDisparos;

            GameObject fuego = Instantiate(firagaPrefab, spawnPoint.position, spawnPoint.rotation);

            FiragaDestroy detector = fuego.AddComponent<FiragaDestroy>();
            detector.tagsDestruir = tagsDestruir;

            Destroy(fuego, tiempoVida);
        }
    }
}

public class FiragaDestroy : MonoBehaviour
{
    public string[] tagsDestruir;

    void OnCollisionEnter2D(Collision2D collision)
    {
        RevisarTag(collision.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        RevisarTag(other.gameObject);
    }

    void RevisarTag(GameObject obj)
    {
        for (int i = 0; i < tagsDestruir.Length; i++)
        {
            if (obj.CompareTag(tagsDestruir[i]))
            {
                Destroy(gameObject);
            }
        }
    }
}
