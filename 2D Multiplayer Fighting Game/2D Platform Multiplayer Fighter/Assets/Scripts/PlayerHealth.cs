using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public float orgHealth = 100f;
    public float health = 100f;                 // The player's health.
    public float damageAmount = 1f;            // The amount of damage to take when enemies touch the player
    public GameObject projectile;
              // Reference to the sprite renderer of the health bar.
    private Vector3 healthScale;                // The local scale of the health bar initially (with full health).
    private Transform bar;
    public Transform healthBar;
    public GameObject HealthBar;
    private void Start()
    {
        
    }
    void Awake()
    {

        bar = transform.Find("HealthBar");

        // Getting the intial scale of the healthbar (whilst the player has full health).
        //healthScale = healthBar.transform.localScale;
    }
    public void SetSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 0, 0);
    }
    public void SetColor(Color color)
    {
        bar.Find("HealthBar");
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        healthBar.localScale = new Vector3(0.5f, 0, 0);
        /*
        //GameObject.Find("arrow").GetComponent<SpriteRenderer>();
        // If the colliding gameobject is an Enemy...
        //if (col.gameObject.CompareTag("arrow"))
        {
            

            // ... and if the player still has health...
            //if (health > 0f)
            {
                // ... take damage and reset the lastHitTime.
                StartCoroutine(waitTime());
            }
            

        }
        
    }
    */
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        

    }

    IEnumerator waitTime()
    {
        print("time");
        Debug.Log("collsion");
        TakeDamage();
        yield return new WaitForSeconds(10);
        print("time");
    }
    public void TakeDamage()
    {
        // Reduce the player's health by 10.
        health -= damageAmount;

        // Update what the health bar looks like.
        UpdateHealthBar();
       
    }


    public void UpdateHealthBar()
    {
        // Set the health bar's colour to proportion of the way between green and red based on the player's health.
        //healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
        Debug.Log("player damage");

        // Set the scale of the health bar to be proportional to the player's health.
        //healthBar.transform.localScale = new Vector3(healthScale.x * health * 0.01f, 1, 1);
    }
    void KillPlayer()
    {
        Destroy(gameObject);
    }
}
