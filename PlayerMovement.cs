using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rb;

    public float moveSpeed = 40f;
    public float jumpForce = 700f;
    Vector2 movement;
    float horizontalMove;
    float smoothTime = 0.2f;
    Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update ()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }

    }

    void FixedUpdate ()
    {
        Vector2 targetVelocity = new Vector3(horizontalMove * moveSpeed * 10f * Time.fixedDeltaTime, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, smoothTime);
    }
    
}