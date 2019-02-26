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
    Respawner rp = new Respawner();

    private float swordDamage;
    private float maceDamage;
    private float arrowDamage;
    private float fireBallDamage;
    public Transform spawnPoint;
    public GameObject player;
    WeaponDamageAmounts wa = new WeaponDamageAmounts();
    public void Awake()
    {
        arrowDamage = wa.getArrowDamage();
        Debug.Log(arrowDamage);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("arrow"))
        {
            if (health > 0f)
            {
                TakeDamage(arrowDamage);
            } 
        }
        /*
        else if (col.gameObject.CompareTag("knight"))
        {
            if (health > 0f)
            {
                TakeDamage(10f);
            }
        }
        
        else if (col.gameObject.CompareTag("mace"))
        {
            if (health > 0f)
            {
                TakeDamage(15f);
            }
        }
        else if (col.gameObject.CompareTag("fireball"))
        {
            if (health > 0f)
            {
                TakeDamage(20f);
            }
        }
        */
    }
    public void TakeDamage(float damageAmount)
    {
        // Reduce the player's health by 10.
       // Debug.Log(damageAmount);
        health = health - damageAmount;
        
        if (health <= 0f)
        {
            killPlayer();
        }
        else
        {
            // Update what the health bar looks like.
            UpdateHealthBar();
        }
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
    public void killPlayer()
    {
        player.transform.position = spawnPoint.transform.position;
    }
}
