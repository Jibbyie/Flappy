using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public float playerScore;
    public TextMeshProUGUI scoreText;

    public AudioSource scoredPoint;
    public AudioSource broDied;

    private void Die()
    {
        Debug.Log("Player hit something");
        broDied.Play();
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
        scoredPoint.Play();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ScoringZone"))
        {
            Scoring();
        }
    }
}
