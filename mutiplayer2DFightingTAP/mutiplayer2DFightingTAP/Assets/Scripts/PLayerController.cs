using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PLayerController : NetworkBehaviour
{
    public float speed;

    private Rigidbody rb;

    public int jumpForce;
    private bool isGrounded = false;
    public Vector3 pos;

    // Use this for initializati
    void Start()
    {
        facingRight = true;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        jumpMovement();
        horizontalMovement();
    }
    void horizontalMovement()
    {
        if (isLocalPlayer)
            {

            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            Vector2 movement = new Vector2(moveHorizontal, 0.0f);

            if (Input.GetKeyUp("a") || Input.GetKeyUp("d"))
            {
                rb.constraints = RigidbodyConstraints.FreezePositionX;
                rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            }
            else
            {
                rb.AddForce(movement * speed);
            }
            
        }
    }
    void jumpMovement()
    {
        if (isLocalPlayer)
        {
            if (Input.GetKeyDown("space") && isGrounded == true)
            {
                rb.AddForce(new Vector2(0, jumpForce), ForceMode.Impulse);
            }
            else
            {

            }

        }
    }
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Platform")
        {
            isGrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Platform")
        {
            isGrounded = false;
        }
    }
    void RotateLeft()
    {
        rb.transform.Rotate(Vector3.forward * -90);
    }
    
}