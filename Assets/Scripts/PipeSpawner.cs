using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    private float timeRemaining = 5f;
    public float respawnTimer;
    public bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerIsRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                SpawnPipe();
                timeRemaining = respawnTimer;
            }
        }
    }

    private void SpawnPipe()
    {
        GameObject pipeClone;
        pipeClone = Instantiate(pipePrefab, transform.position, transform.rotation);
        Debug.Log("Pipe spawned!");
        timerIsRunning = true;
    }
}
