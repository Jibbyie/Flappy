using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDespawn : MonoBehaviour
{
    public float despawnTimer;

    private void Update()
    {
        despawnTimer -= Time.deltaTime;

        if (despawnTimer <= 0.0f)
        {
            Destroy(gameObject);
        }
    }

}
