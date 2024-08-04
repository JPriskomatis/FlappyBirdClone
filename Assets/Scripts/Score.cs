using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public static int score;

    public static event Action OnScore;
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

        if (score == 1)
        {
            OnScore?.Invoke();
        }
    }
}
