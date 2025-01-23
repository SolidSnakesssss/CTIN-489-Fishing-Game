using System;
using System.Collections;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;

    private Vector2 moveDirection;

    public AudioSource BoatSfx;

    private bool audioPlaying = false;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        moveDirection = new Vector2(moveX, 0).normalized;

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) && !audioPlaying)
        {
            audioPlaying = true;
            BoatSfx.Play();
        }
        
        else if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            audioPlaying = false;
            BoatSfx.Stop();
        }

        else
        {
            audioPlaying = false;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, 0);
    }
}
