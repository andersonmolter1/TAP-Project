                 // How many times the enemy can be hit before it dies.
using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour
{
    private float speed = 1.0f;
    private Vector2 target;
    private Vector2 position;
    private Camera cam;
    public Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player1").transform;

    }

    void Update()
    {
        findPlayer();
        
        ////Debug.Log(playerLoc.location);
        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }

    void findPlayer()
    {
        target = player.transform.position;
    }

    


}