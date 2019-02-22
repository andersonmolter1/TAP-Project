using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    public float health = 1f;
    public float repeatDamagePeriod = 2f;		
				
	public float hurtForce = 10f;				
	public float damageAmount = 10f;			

	private SpriteRenderer healthBar;			
						
	private Vector3 healthScale;				
	private PlayerControl playerControl;		
						


	void Awake ()
	{
        health = 1f;
		// Setting up references.
		playerControl = GetComponent<PlayerControl>();
		healthBar = GameObject.Find("HealthBar").GetComponent<SpriteRenderer>();
		//anim = GetComponent<Animator>();

		// Getting the intial scale of the healthbar (whilst the player has full health).
		healthScale = healthBar.transform.localScale;
	}


	


	public void TakeDamage ()
	{
		// Make sure the player can't jump.
		playerControl.jump = false;
		
        // Reduce the player's health by 10.
		health -= damageAmount;

		// Update what the health bar looks like.
		UpdateHealthBar();

		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "arrow")
        {
            Debug.Log("Player contact");
            TakeDamage();
        }
    }
    public void UpdateHealthBar ()
	{
        if (health < 0.01f)
        {
            // Set the health bar's colour to proportion of the way between green and red based on the player's health.
            healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);

            // Set the scale of the health bar to be proportional to the player's health.
            healthBar.transform.localScale = new Vector3(healthScale.x * health * 0.01f, 1, 1);
        } else
        {
            GetComponent<Respawner>().killPlayer();
        }
	}
   
    
}
