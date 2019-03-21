                 // How many times the enemy can be hit before it dies.
using UnityEngine;
using System.Collections;
public class enemyAI : MonoBehaviour
{
    public float speed = 3.0f;
    private Vector2 target;
    private Vector2 position;
    private Transform player;
    public GameObject particleEffect;

    void Start()
    {
        
    }

    void Update()
    {
        
            int random = Random.Range(1, 5);
            switch (random)
            {
                case 1:
                if (GameObject.FindGameObjectWithTag("player1"))
                {
                    player = GameObject.FindGameObjectWithTag("player1").transform;
                }
                    break;
            case 2:
                if (GameObject.FindGameObjectWithTag("player2"))
                {
                    player = GameObject.FindGameObjectWithTag("player2").transform;
                }
                break;
            case 3:
                if (GameObject.FindGameObjectWithTag("player3"))
                {
                    player = GameObject.FindGameObjectWithTag("player3").transform;
                }
                break;
            case 4:
                if (GameObject.FindGameObjectWithTag("player4"))
                {
                    player = GameObject.FindGameObjectWithTag("player4").transform;
                }
                break;
        }
       
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject, 0.2f);
            GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            Destroy(particle, 0.3f);
        }

    }

}