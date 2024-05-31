using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;


public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;
    


    public int score;
    public int batteries;
    public TextMeshProUGUI battText;
    public int lives;
    public TextMeshProUGUI livesText;

    public GameObject pauseScreen;
    private bool paused;


    

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = false;
        if(Input.GetKeyUp(KeyCode.P))
        {
            StartGame();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangePaused();
        }
    }
    public void StartGame()
    {
        isGameActive = true;
        score = 0;
        lives = 3;

        UpdateScore(0);
        UpdateLives(0);
        UpdateBatteries(0);
        titleScreen.gameObject.SetActive(false);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += (scoreToAdd * lives);
        scoreText.text = "Score: " + score;
    }

    public void UpdateLives(int lifeLost)
    {
        lives -= lifeLost;
        livesText.text = "Lives Left: " + lives;
    }

    public void UpdateBatteries(int battAdd)
    {
        batteries += battAdd;
        battText.text = "Batteries: " + batteries;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        lives = 0;

    }

    void ChangePaused()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
