using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text scoreText2;
    public Text bestScoreText;

    public int score = 0;
    private int bestScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("HighScore", 0);
        bestScoreText.text = bestScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUpdate();
        BestScoreUpdate();
    }

    private void ScoreUpdate()
    {
        scoreText.text = score.ToString();
        scoreText2.text = score.ToString();
    }

    private void BestScoreUpdate()
    {
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("HighScore", bestScore);

            bestScoreText.text = bestScore.ToString();
        }
    }
}
