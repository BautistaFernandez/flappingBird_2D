using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();

        // PlayerPrefs saves values to use wihout kare if game restarts.
        bestScoreText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
    }

    public void UpdateBestScore()
    {
        // Update BestScore if score is bigger.
        if (score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);

            bestScoreText.text = score.ToString();
        }
    }

    public void UpdateScore()
    {
        score++;

        scoreText.text = score.ToString();
        UpdateBestScore();
    }
}