using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float verticalGapSize = 2.0f; 
    public float minY = 0.0f;
    public float maxY = 5.0f;
    private bool isSpawning = false; // Added a flag to prevent simultaneous spawning

    public void SpawnPipe()
    {
        if (!isSpawning)
        {
            isSpawning = true;

            GameObject newPipe = Instantiate(pipePrefab, transform.position, transform.rotation);
            float pipeY = Random.Range(minY, maxY);
            newPipe.transform.position = new Vector3(transform.position.x, pipeY, transform.position.z);

            isSpawning = false;
        }
    }

}
