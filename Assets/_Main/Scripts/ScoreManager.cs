using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateScore();
    }

    void Update()
    {
        
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Puntos: " + Vida.coins;
    }
}
