using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dan.Main;
using TMPro;

namespace Leaderboardspace
{

    public class Leaderboard : MonoBehaviour
    {
        [SerializeField] private List<TextMeshProUGUI> names;



        private string publicKey = "363eb8336b2c1335d951b80f2a42d349ac32a3d4ea1804ddb868d10e4b4d1acd";

        private void Start()
        {
            GetLeaderboard();
        }

        public void GetLeaderboard()
        {
            Leaderboards.FlappyBirdClone.GetEntries(entries =>
            {
                foreach (var t in names)
                    t.text = "";

                var length = Mathf.Min(names.Count, entries.Length);
                for (int i = 0; i < length; i++)
                {
                    Debug.Log($"Entry {i}: {entries[i].Username} - {entries[i].Score}"); // Debugging each entry
                    names[i].text = $"{entries[i].Rank}. {entries[i].Username} - {entries[i].Score}";
                }
            });
        }

        public void UploadEntry(string username, int score)
        {
            Leaderboards.FlappyBirdClone.UploadNewEntry(username, score, isSuccessful =>
            {
                if (isSuccessful)
                {
                    Debug.Log($"Successfully uploaded score: {score} for username: {username}");
                    GetLeaderboard();
                }
                else
                {
                    Debug.LogError("Failed to upload score");
                }
            });
        }

    }

}