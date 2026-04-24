using UnityEngine;

public class CastFreeze : MonoBehaviour
{
    public GameObject freezePrefab;
    public Transform spawnPoint;

    public float distancia = 1f;
    public float tiempoEntreDisparos = 0.5f;
    public float tiempoVida = 3f;

    public float siguienteDisparo = 0f;

    void Update()
    {
        // Mirando derecha
        if (Input.GetKeyDown(KeyCode.D))
        {
            spawnPoint.localPosition = new Vector3(distancia, 0, 0);

            // Invierte horizontalmente conservando ángulo
            Vector3 rot = spawnPoint.localEulerAngles;
            spawnPoint.localRotation = Quaternion.Euler(rot.x, 0, rot.z);
        }

        // Mirando izquierda
        if (Input.GetKeyDown(KeyCode.A))
        {
            spawnPoint.localPosition = new Vector3(-distancia, 0, 0);

            // Invierte horizontalmente conservando ángulo
            Vector3 rot = spawnPoint.localEulerAngles;
            spawnPoint.localRotation = Quaternion.Euler(rot.x, 180, rot.z);
        }

        // Cast Freeze con una sola pulsación
        if (Input.GetKeyDown(KeyCode.R) && Time.time >= siguienteDisparo)
        {
            siguienteDisparo = Time.time + tiempoEntreDisparos;

            GameObject hielo = Instantiate(
                freezePrefab,
                spawnPoint.position,
                spawnPoint.rotation
            );

            Destroy(hielo, tiempoVida);
        }
    }
}