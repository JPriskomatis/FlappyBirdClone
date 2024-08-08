using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scorespace;

namespace Leaderboardspace
{
    public class ActivateLeaderboard : MonoBehaviour
    {
        [SerializeField] private GameObject leaderboardObject;

        private void OnEnable()
        {
            Score.OnScore += EnableLeaderboard;
        }
        private void OnDisable()
        {
            Score.OnScore -= EnableLeaderboard;
        }

        private void EnableLeaderboard()
        {
            leaderboardObject.SetActive(true);
        }
    }

}
