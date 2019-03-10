using UnityEngine;
using System.Collections;
using System.Threading.Tasks;

public class PlayerHealthAndDamage : MonoBehaviour
{
    public int lives = 3;
    public float health = 100f;
    public float damageAmount = 10f;
    //public GameObject project
    
    //public Transform healthBar;
    public GameObject HealthBar;

    private float swordDamage;
    private float maceDamage;
    private float arrowDamage;
    private float fireBallDamage;
    public Transform spawnPoint;
    public GameObject player;
    bool allowDamage = true;


    void OnCollisionEnter2D(Collision2D col)
    {

        if (allowDamage)
        {
            if (col.gameObject.CompareTag("arrow"))
            {

                if (health > 0f)
                {
                    TakeDamage(7.5f);
                    
                }

            }

            else if (col.gameObject.CompareTag("knightCollider"))
            {
                Debug.Log("knight");
                if (health > 0f)
                {
                    TakeDamage(5f);
                    
                }
                
            }

            else if (col.gameObject.CompareTag("vikingCollider"))
            {

                if (health > 0f)
                {
                    TakeDamage(7.5f);
                    
                }

            }

            else if (col.gameObject.CompareTag("fireball"))
            {


                if (health > 0f)
                {
                    TakeDamage(15f);
                    
                }


            }

        }
        if (col.gameObject.CompareTag("killBar"))
        {

            KillPlayer();
            Invoke("Respawn", 1.5f);

        }
    }
    


    public void TakeDamage(float damageAmount)
    {
        // Reduce the player's health by 10.
       // Debug.Log(damageAmount);
        health -= damageAmount;
        if (health < 0f)
        {
            health = 0f;
        }
        if (health == 0f)
        {
            KillPlayer();
            Invoke("Respawn", 2f);

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
        if (health > 60f)
        {
            HealthBar.transform.localScale = new Vector3((health * 0.01f), 0.6251f, 0.893f);
            HealthBarRender.material.color = Color.green;
        }
        else if(health < 60 && health > 30)
        {
            HealthBar.transform.localScale = new Vector3((health * 0.01f), 0.6251f, 0.893f);
            HealthBarRender.material.color = Color.yellow;
        }
        else if (health <= 30f)
        {
            HealthBar.transform.localScale = new Vector3((health * 0.01f), 0.6251f, 0.893f);
            HealthBarRender.material.color = Color.red;
        }
    }

    public void RestoreHealthBar()
    {
        health = 100f;
    }

    public void KillPlayer()
    {
        UpdateHealthBar();
        RestoreHealthBar();
        UpdateHealthBar();
        player.SetActive(false);
        lives--;
        Debug.Log(lives);
    }

    public void Respawn()
    {
        player.SetActive(true);
        player.transform.position = spawnPoint.position;

    }

}
