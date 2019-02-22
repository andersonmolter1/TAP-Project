using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamagePlayer : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("player"))
        {
            Debug.Log("Player contact");
            GetComponent<PlayerHealth>().TakeDamage();
        }
    }
   
}
