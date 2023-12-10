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

    public GameObject prefabPS;
    public GameObject RestartUI;

    private void Die()
    {
        broDied.Play();
        Debug.Log("PARTICLES" + Instantiate(prefabPS, transform.position, Quaternion.identity));

        // Pass the player score to the RestartHandling script
        RestartHandling.Instance.SetPlayerScore(playerScore);

        Destroy(gameObject);
        RestartUI.gameObject.SetActive(true);
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
