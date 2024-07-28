using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public GameObject restartButton;
    public GameObject leaderboardButton;
    public Player player;

    public TextMeshProUGUI gameOverCountdown;
    public float countTimer = 3;


    // Start is called before the first frame update
    void Start()
    {
        gameOverCountdown.gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    private void OnEnable()
    {
        Player.onDeath += DeathScreen;
    }

    private void OnDisable()
    {
        Player.onDeath -= DeathScreen;

    }

    private void DeathScreen()
    {

        leaderboardButton.SetActive(true);
        restartButton.SetActive(true);
    }



    public void StartGame()
    {
        startButton.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
