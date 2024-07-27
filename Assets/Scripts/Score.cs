using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score;

    private void OnEnable()
    {
        PipesScore.onPass += IncreaseScore;
    }

    private void OnDisable()
    {
        PipesScore.onPass -= IncreaseScore;
    }

    private void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
