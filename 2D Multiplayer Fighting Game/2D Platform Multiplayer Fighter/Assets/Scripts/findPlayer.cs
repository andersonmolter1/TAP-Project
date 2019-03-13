using UnityEngine;
using System.Collections;

public class findPlayer : MonoBehaviour
{
    [HideInInspector]
    public Vector2 location;          // The offset at which the Health Bar follows the player.
    
    private Transform player;       // Reference to the player.


    void Awake()
    {
        // Setting up the reference.
        player = GameObject.FindGameObjectWithTag("player1").transform;
        Debug.Log(player);
    }

    public void Update()
    {
        

        location = player.transform.position;
        
    }
}
