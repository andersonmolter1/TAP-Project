using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PLayerController : NetworkBehaviour
{
    public float speed;
   
    private Rigidbody rb;


    public Vector3 pos;

    // Use this for initializati
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isLocalPlayer)
        {
                float moveHorizontal = Input.GetAxisRaw("Horizontal");
                Vector2 movement = new Vector2(moveHorizontal, 0.0f);
      
            rb.constraints = RigidbodyConstraints.None;
            if (Input.GetKeyUp("a") ||Input.GetKeyUp("d"))
            {
                for (int i = 5; i > 0; i--)
                {
                    rb.AddForce(((movement * speed) / i) * -1);
                }
                rb.constraints = RigidbodyConstraints.FreezeAll;
            } 
            else
            {
                rb.AddForce(movement * speed);
            }
            Debug.Log("Key down");
            return;
        }
    }
}