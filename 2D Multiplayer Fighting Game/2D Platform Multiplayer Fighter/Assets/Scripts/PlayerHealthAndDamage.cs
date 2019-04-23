using UnityEngine;
using System.Collections;
using System.Threading.Tasks;

public class PlayerHealthAndDamage : MonoBehaviour
{
    public float health = 100f;
    public float damageAmount = 10f;
    //public GameObject project

    //public Transform healthBar;
    public GameObject HealthBar;
    public bool canKill = true;

    private float swordDamage;
    private float maceDamage;
    private float arrowDamage;
    private float fireBallDamage;
    //public Transform spawnPoint;
    public GameObject player;
    bool allowDamage = true;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    public string playerTag;
    //public Animator anim;
    //private int activeState;
    void OnCollisionEnter2D(Collision2D col)
    {

        if (allowDamage)
        {
            allowDamage = false;
            if (col.gameObject.CompareTag("arrow"))
            {
                Debug.Log("arrow");
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
                    TakeDamage(15f);

                }

            }
            else if (col.gameObject.CompareTag("healer"))
            {
                Debug.Log("healer");
                if (health > 0f)
                {
                    TakeDamage(-5f);

                }
            }
            else if (col.gameObject.CompareTag("enemy"))
            {
                Debug.Log("enemy");
                if (health > 0f)
                {
                    TakeDamage(7.5f);

                }
            }
            else if (col.gameObject.CompareTag("vikingCollider"))
            {
                Debug.Log("viking");
                if (health > 0f)
                {
                    TakeDamage(25f);
                }
            }

            else if (col.gameObject.CompareTag("fireball"))
            {

                Debug.Log("fireball");
                if (health > 0f)
                {
                    TakeDamage(15f);

                }


            }

        }
        if (col.gameObject.CompareTag("killBar"))
        {

            TakeDamage(100f);
            

        }
    }

    
    private void OnCollisionExit2D(Collision2D collision)
    {
        allowDamage = true;
        canKill = true;
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
        else if (health < 60 && health > 30)
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
        if (canKill)
        {
            canKill = false;
            //activeState = 4;
            UpdateHealthBar();
            RestoreHealthBar();
            UpdateHealthBar();
            player.SetActive(false);

            if (playerTag == "player1")
            {

                playerValues.player1Lives--;


            }
            else if (playerTag == "player2")
            {
                playerValues.player2Lives--;


            }
            else if (playerTag == "player3")
            {
                playerValues.player3Lives--;


            }
            else if (playerTag == "player4")
            {
                playerValues.player4Lives--;
            }
            Destroy(player);
        }
    }
    private void Update()
    {
       
        playerTag = player.tag;
        if (playerTag == "player1")
        {
            switch (playerValues.player1Lives)
            {
                case 0:
                    Destroy(player);
                    break;
                case 1:
                    Destroy(life1);
                    Destroy(life2);
                    break;
                case 2:
                    Destroy(life1);
                    break;
            }
        }
        else if (playerTag == "player2")
        {
            switch (playerValues.player2Lives)
            {
                case 0:
                    Destroy(player);
                    break;
                case 1:
                    Destroy(life1);
                    Destroy(life2);
                    break;
                case 2:
                    Destroy(life1);
                    break;
            }
        }
        else if (playerTag == "player3")
        {
            switch (playerValues.player3Lives)
            {
                case 0:
                    Destroy(player);
                    break;
                case 1:
                    Destroy(life1);
                    Destroy(life2);
                    break;
                case 2:
                    Destroy(life1);
                    break;
                    
            }
        }
        else if (playerTag == "player4")
        {
            switch (playerValues.player4Lives)
            {
                case 0:
                    Destroy(player);
                    break;
                case 1:
                    Destroy(life1);
                    Destroy(life2);
                    break;
                case 2:
                    Destroy(life1);
                    break;
            }
        }
    }
}