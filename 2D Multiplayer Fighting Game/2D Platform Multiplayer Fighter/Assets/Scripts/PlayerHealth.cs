using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
  
    public float health = 100f;
    public float damageAmount = 10f;
    //public GameObject project
    
    //public Transform healthBar;
    public GameObject HealthBar;
    private float healthBarMaxSize = 10;

    public void Awake()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("arrow"))
        {
            if (health > 0f)
            {
                TakeDamage();
            }
        }
    }
    public void TakeDamage()
    {
        // Reduce the player's health by 10.
        health = health - damageAmount;

        // Update what the health bar looks like.
        UpdateHealthBar();

    }


    public void UpdateHealthBar()
    {
        Renderer HealthBarRender = HealthBar.GetComponent<Renderer>();
        if (health > 30f)
        {

            HealthBar.transform.localScale = new Vector3((health * 0.01f), 0.6251f, 0.893f);

            HealthBarRender.material.color = Color.green;
        }
        else if (health < 30f)
        {
            HealthBar.transform.localScale = new Vector3((health * 0.01f), 0.6251f, 0.893f);
            HealthBarRender.material.color = Color.red;
        }
    }
    void KillPlayer()
    {
        Destroy(gameObject);
    }
}
