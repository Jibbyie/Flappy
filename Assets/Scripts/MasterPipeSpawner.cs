using System.Collections;
using UnityEngine;

public class MasterPipeSpawner : MonoBehaviour
{
    public PipeSpawner lowerPipeSpawner;
    public PipeSpawner upperPipeSpawner;
    public float minSpawnDelay = 1.0f;
    public float maxSpawnDelay = 3.0f;

    private void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    IEnumerator SpawnPipes()
    {
        while (true)
        {
            float randomDelay = Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(randomDelay);

            // Signal both spawners to spawn a pair of pipes
            lowerPipeSpawner.SpawnPipe();
            upperPipeSpawner.SpawnPipe();
        }
    }
}
