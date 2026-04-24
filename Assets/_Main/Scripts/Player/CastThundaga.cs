using UnityEngine;
using System.Collections;

public class CastThundaga : MonoBehaviour
{
    public GameObject thundaregaPrefab;

    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;

    public float distancia = 1f;

    public float tiempoVida = 2f;
    public float tiempoEntreRayos = 0.3f;
    public float cooldown = 1f;

    public float siguienteUso = 0f;
    void Update()
    {
        // Mirando derecha → solo cambia X, mantiene Y
        if (Input.GetKeyDown(KeyCode.D))
        {
            spawnPoint1.localPosition = new Vector3(distancia, spawnPoint1.localPosition.y, 0);
            spawnPoint2.localPosition = new Vector3(distancia + 1f, spawnPoint2.localPosition.y, 0);
            spawnPoint3.localPosition = new Vector3(distancia + 2f, spawnPoint3.localPosition.y, 0);
        }

        // Mirando izquierda → solo cambia X, mantiene Y
        if (Input.GetKeyDown(KeyCode.A))
        {
            spawnPoint1.localPosition = new Vector3(-distancia, spawnPoint1.localPosition.y, 0);
            spawnPoint2.localPosition = new Vector3(-distancia - 1f, spawnPoint2.localPosition.y, 0);
            spawnPoint3.localPosition = new Vector3(-distancia - 2f, spawnPoint3.localPosition.y, 0);
        }

        // Cast Thundaga con una pulsación
        if (Input.GetKeyDown(KeyCode.E) && Time.time >= siguienteUso)
        {
            siguienteUso = Time.time + cooldown;

            StartCoroutine(LanzarThundarega());
        }
    }

    IEnumerator LanzarThundarega()
    {
        LanzarRayo(spawnPoint1);
        yield return new WaitForSeconds(tiempoEntreRayos);

        LanzarRayo(spawnPoint2);
        yield return new WaitForSeconds(tiempoEntreRayos);

        LanzarRayo(spawnPoint3);
    }

    void LanzarRayo(Transform punto)
    {
        GameObject rayo = Instantiate(
            thundaregaPrefab,
            punto.position,
            Quaternion.identity
        );

        Destroy(rayo, tiempoVida);
    }
}