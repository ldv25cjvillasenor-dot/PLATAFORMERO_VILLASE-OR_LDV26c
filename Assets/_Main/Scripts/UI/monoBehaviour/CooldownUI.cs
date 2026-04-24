using UnityEngine;
using TMPro;

public class CooldownUI : MonoBehaviour
{
    public TextMeshProUGUI txtFiraga;
    public TextMeshProUGUI txtFreeze;
    public TextMeshProUGUI txtThundaga;

    public CastFiraga firaga;
    public CastFreeze freeze;
    public CastThundaga thundaga;

    void Update()
    {
        Mostrar(txtFiraga, firaga.siguienteDisparo, "🔥 Firaga");
        Mostrar(txtFreeze, freeze.siguienteDisparo, "❄ Freeze");
        Mostrar(txtThundaga, thundaga.siguienteUso, "⚡ Thundaga");
    }

    void Mostrar(TextMeshProUGUI txt, float tiempoFinal, string nombre)
    {
        float restante = tiempoFinal - Time.time;

        if (restante > 0.05f)
        {
            txt.text = nombre + ": " + restante.ToString("0.0") + "s";
        }
        else
        {
            txt.text = nombre + ": READY";
        }
    }
}