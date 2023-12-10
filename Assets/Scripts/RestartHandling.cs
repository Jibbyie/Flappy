using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartHandling : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    private float highScore;
    private float playerScore;

    // Singleton instance
    public static RestartHandling Instance;

    private void Awake()
    {
        // Singleton pattern to ensure only one instance of this script exists
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Load the high score from PlayerPrefs
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        UpdateHighScoreText();
    }

    public void SetPlayerScore(float score)
    {
        playerScore = score;
    }

    private void Update()
    {
        // Check if the player achieved a new high score
        if (playerScore > highScore)
        {
            highScore = playerScore;
            UpdateHighScoreText();

            // Save the new high score to PlayerPrefs
            PlayerPrefs.SetFloat("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    private void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + highScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
