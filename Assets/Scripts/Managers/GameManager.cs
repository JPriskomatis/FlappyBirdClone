using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;
using Playerspace;

public enum GameState
{
    Playing,
    Pause,
    EndScreen
}
public class GameManager : MonoBehaviour
{
    public static event Action OnRestart;

    public GameObject startButton;
    public GameObject restartButton;
    public GameObject leaderboardButton;
    public Player player;

    public TextMeshProUGUI gameOverCountdown;
    public float countTimer = 3;

    public static GameState gameState;


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

        restartButton.SetActive(true);
        gameState = GameState.Pause;

    }



    public void StartGame()
    {
        gameState = GameState.Playing;
        startButton.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameState = GameState.EndScreen;

    }


    public void RestartGame()
    {
        OnRestart?.Invoke();
        SceneManager.LoadScene(0);
        gameState = GameState.Pause;

    }

}
