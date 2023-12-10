using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rb;

    public AudioSource jumpSound;

    void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody2D not found on the player or its children.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce) * Time.deltaTime;
        jumpSound.Play();
    }
}
