using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject panelOptions;
    public MonoBehaviour playerMovement; // arrastra tu script movimiento aquí

    bool abierto = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            abierto = !abierto;

            panelOptions.SetActive(abierto);

            if (playerMovement != null)
                playerMovement.enabled = !abierto;

            Cursor.visible = abierto;
        }
    }
}