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
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    //public Animator anim;
    //private int activeState;

    private void Update()
    {
        //anim.SetInteger("stateOfAction", activeState);
    }
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
                if (health > 0f)
                {
                    TakeDamage(5f);

                }

            }
            else if (col.gameObject.CompareTag("healer"))
            {
                
                if (health > 0f)
                {
                    TakeDamage(-5f);

                }
            }
            else if (col.gameObject.CompareTag("enemy"))
            {
                if (health > 0f)
                {
                    TakeDamage(7.5f);

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

    private void OnCollisionExit2D(Collision2D collision)
    {
        allowDamage = true;
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
        //activeState = 4;
        UpdateHealthBar();
        RestoreHealthBar();
        UpdateHealthBar();
        player.SetActive(false);
       
        lives--;
        switch (lives)
        {
            case 1:
                Destroy(life2);
                break;
            case 2:
                Destroy(life1);
                break;
        }
        Destroy(player);
    }

    public void Respawn()
    {
        if (lives > 0)
        {
           
        }
    }

}
