using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Respawn : NetworkBehaviour
{
    
    private bool isDead = false;
    public GameObject player;
    public Vector3 spawnPosition1;
    public Vector3 spawnPosition2;


    void Update()
    {
        

        if (isLocalPlayer)
        {
            if (isDead)
            {
                bool randomBool = (Random.value > 0.5f);
                

                if (randomBool)
                {
                    player.transform.position = (spawnPosition1);

                }
                else if (!randomBool)
                {
                   
                    player.transform.position = (spawnPosition2);
                }

            }
            
        }
    }
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "bottomFloor")
        {
            isDead = true;  
        }
    }
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "bottomFloor")
        {
            isDead = false;
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSecondsRealtime(2);
    }
}
