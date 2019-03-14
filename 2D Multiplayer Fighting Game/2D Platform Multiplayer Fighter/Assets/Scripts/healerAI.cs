using UnityEngine;
using System.Collections;

public class healerAI : MonoBehaviour
{
    public float speed = 3.0f;
    private Vector2 target;
    private Vector2 position;
    
   
    public GameObject particleEffect;

    void Start()
    {
        

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
        Transform player = GameObject.FindGameObjectWithTag("player1").transform;
        target = player.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
            GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))); 
            Destroy(particle, 0.3f);
        }

    }


}
