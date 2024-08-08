using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Factoryspace;

namespace Scorespace {
    public class Score : MonoBehaviour
    {

        [SerializeField] private TextMeshProUGUI scoreText;
        public static int score;

        public static event Action OnScore;
        private void OnEnable()
        {
            PipesScore.onPass += IncreaseScore;
            Banana.OnBananaPickUp += IncreaseScore;
            GameManager.OnRestart += ResetScore;
        }

        private void OnDisable()
        {
            PipesScore.onPass -= IncreaseScore;
            Banana.OnBananaPickUp -= IncreaseScore;
            GameManager.OnRestart -= ResetScore;
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

        private void ResetScore()
        {
            score = 0;
        }
    }

}
