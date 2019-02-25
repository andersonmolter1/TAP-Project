using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("knight"))
        {
            Debug.Log("knight");
        }
        if (collision.gameObject.CompareTag("wizard"))
        {
            Debug.Log("wizard");
        }
        if (collision.gameObject.CompareTag("archer"))
        {
            Debug.Log("archer");
        }
        if (collision.gameObject.CompareTag("viking"))
        {
            Debug.Log("viking");
        }
        //teleports projectile off map after hitting the ground or wall. 
        //Debug.Log("Hit ground");
        //transform.position = new Vector2(100, 100);
        Destroy(gameObject);
    }

}
