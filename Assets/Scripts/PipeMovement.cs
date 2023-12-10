using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    private float moveSpeed = 7f;
    private float direction;

    void Update()
    {
        direction = -moveSpeed * Time.deltaTime;
        transform.Translate(direction, 0, 0);

    }

}
