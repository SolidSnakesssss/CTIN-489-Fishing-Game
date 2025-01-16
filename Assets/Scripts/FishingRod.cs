using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingRod : MonoBehaviour
{
    public float ySpeed;
    public float xSpeed;
    private Vector2 moveDirection;

    public Rigidbody2D rb;
    public Transform boatTransform;
    

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    private void FixedUpdate()
    {
        Vector2 boatPosition = boatTransform.position;
        rb.velocity = new Vector2(moveDirection.x * xSpeed, moveDirection.y * ySpeed);

        transform.position = new Vector2(boatPosition.x - 2, transform.position.y);
    }
}

