using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Pipe"))
        {
            Debug.Log("Player hit pipe");
        }
        else if(col.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Player hit ground");
        }
    }
}
