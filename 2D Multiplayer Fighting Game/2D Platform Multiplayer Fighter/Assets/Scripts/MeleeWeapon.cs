using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collsion for sword.
        if (collision.gameObject.CompareTag("player"))
        {
            Debug.Log("Sword Hit");
        } else if (collision.gameObject.CompareTag("player"))
        {
            Debug.Log("Arrow Hit");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
