using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonsMenu : MonoBehaviour
{
    public GameObject panelOptions;

    // Cierra menú y continúa juego
    public void ContinuarJuego()
    {
        panelOptions.SetActive(false);
        Time.timeScale = 1f;
    }

    // Cambiar escena por nombre
    public void CambiarEscena(string nombreEscena)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nombreEscena);
    }

    // Salir del juego
    public void SalirJuego()
    {
        Application.Quit();
    }
}
