using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FishingRod : MonoBehaviour
{
    public float ySpeed;
    public float xSpeed;
    private Vector2 moveDirection;
    private bool audioPlaying = false;

    public Rigidbody2D rb;
    public Transform boatTransform;
    public GameObject hook;
    public AudioSource ReelSfx;
    

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); 
        
        float moveY = Input.GetAxisRaw("Vertical");
        float oldY = hook.transform.position.y;
        
        //float oldYSpeed = ySpeed;
        
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) && !audioPlaying)
        {
            audioPlaying = true;
            ReelSfx.Play();
        }
        
        else if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            audioPlaying = false;
            ReelSfx.Stop();
        }

        else
        {
            audioPlaying = false;
        }
        
        if (oldY >= 291)
        {
            if (Input.GetKey(KeyCode.S))
            {
                ySpeed = 150;
            }

            else
            {
                ySpeed = 0;
            }
        }
        
        else if (oldY <= 123)
        {
            if (Input.GetKey(KeyCode.W))
            {
                ySpeed = 150;
            }

            else
            {
                ySpeed = 0;
            }
        }
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    private void FixedUpdate()
    {
        Vector2 boatPosition = boatTransform.position;
        rb.velocity = new Vector2(moveDirection.x * xSpeed, moveDirection.y * ySpeed);

        transform.position = new Vector2(boatPosition.x - 2, transform.position.y);
    }
}

