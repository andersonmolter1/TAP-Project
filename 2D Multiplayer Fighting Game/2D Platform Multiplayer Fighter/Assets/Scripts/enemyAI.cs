                 // How many times the enemy can be hit before it dies.
using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour
{
    private float speed = 10.0f;
    private Vector2 target;
    private Vector2 position;
    private Camera cam;
    private findPlayer playerLoc;

    void Start()
    {
        position = gameObject.transform.position;
        target = playerLoc.location;
        Debug.Log(target);

    }

    void Update()
    {
        target = playerLoc.location;
        Debug.Log(target);
        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }

    


}