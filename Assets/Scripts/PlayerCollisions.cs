using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public float playerScore;
    public TextMeshProUGUI scoreText;


    private void Update()
    {

    }

    private void Die()
    {
        Debug.Log("Player hit something");
        Time.timeScale = 0;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Pipe") || col.gameObject.CompareTag("Floor"))
        {
            Die();
        }
    }

    private void Scoring()
    {
        playerScore += 0.5f;
        scoreText.text = playerScore.ToString();
        Debug.Log("Player scored a point");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ScoringZone"))
        {
            Scoring();
        }
    }
}
