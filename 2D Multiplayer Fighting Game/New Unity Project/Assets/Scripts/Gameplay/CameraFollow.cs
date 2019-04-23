using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float maxY = -2.0f;

    void FixedUpdate()
    {
        //transform.position = new Vector3(0, player.position.y, transform.position.z);//Normal Camera Movement
        transform.position = new Vector3(0, maxY + 3.5f, transform.position.z);//Vertical Camera Movement
        if (player.position.y > maxY)
        {
            maxY = player.position.y;
        }
    }


}
