using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public float score;
    public Text highScore;

    void start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

    }


    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            ScoreText.text = ((int)score).ToString();

            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", (int)score);
                highScore.text = score.ToString("0");
            }

        }
    }
}