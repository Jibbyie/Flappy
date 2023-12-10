using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed;
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = -moveSpeed * Time.deltaTime;
        transform.Translate(direction, 0, 0);
    }
}
