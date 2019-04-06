using UnityEngine;
using System.Collections;
using Rewired;

[AddComponentMenu("")]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControl : MonoBehaviour
{
    [HideInInspector]
    public bool facingRight = true;         // For determining which way the player is currently facing.
    [HideInInspector]
    public bool jump = false;               // Condition for whether the player should jump.

    public int playerId = 0; // The Rewired player id of this character


    public bool isMelee;
    public int activeState;
    //public string playerAttack;
    public float moveForce = 365f;          // Amount of force added to move the player left and right.
    public float maxSpeed = 5f;             // The fastest the player can travel in the x axis.
    public float jumpForce = 1200f;         // Amount of force added when the player jumps.
    public bool attack;   
    
    private Transform groundCheck;          // A position marking where to check if the player is grounded.
    private bool grounded = false;          // Whether or not the player is grounded.
    public Animator anim;                  // Reference to the player's animator component.
    public string horiztonal = "Move Horizontal";
    public string jumpButton = "Jump";
    public string Fire = "Fire";

    public Rigidbody2D projectile;               // Prefab of the rocket.
    public float speed = 20f;				// The speed the rocket will fire at.
    private bool isCooldown;
    public Transform projectileSpot;

    public Transform colliderMelee;

    private GameObject meleeCollider;
    public GameObject meleeCol;
    private string meleeplayer;
    //public string colliderTag;

    [System.NonSerialized] // Don't serialize this so the value is lost on an editor script recompile.
    private bool initialized;

    private float cooldownTime = .8f;

    private Player player; // The Rewired Player

    void Awake()
    {
        // Setting up references.
        groundCheck = transform.Find("groundCheck");
        isCooldown = true;
        projectile.gravityScale = 0;
    }

    private void Initialize()
    {
        // Get the Rewired Player object for this player.
        

        initialized = true;
    }

    void Update()
    {

        if (!ReInput.isReady) return; // Exit if Rewired isn't ready. This would only happen during a script recompile in the editor.
        if (!initialized) Initialize(); // Reinitialize after a recompile in the editor

        // The player is grounded if a linecast to the groundcheck position hits anything on the ground layer.
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (!isMelee)
        {
            // If the fire button is pressed...
            if (attack && isCooldown)
            {

                StartCoroutine(shootingCooldown());

            }
        }
        else if (isMelee)
        {
            if (attack && isCooldown)
            {

                StartCoroutine(meleeCooldown());
            }
        }
    }
    private void FixedUpdate()
    {
        player = ReInput.players.GetPlayer(playerId);
        float h = player.GetAxis("Move Horizontal");
        attack = player.GetButtonDown("Fire");
        jump = player.GetButtonDown("Jump");
        anim.SetInteger("stateOfAction", activeState);
        // Cache the horizontal player.
        
        if (Mathf.Abs(h) > 0)
        {
            activeState = 1;
        }
        else
        {
            activeState = 0;
        }

        // If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
        if (h * GetComponent<Rigidbody2D>().velocity.x < maxSpeed)
        {
            // ... add a force to the player.

            GetComponent<Rigidbody2D>().AddForce(Vector2.right * h * moveForce);
        }
        // If the player's horizontal velocity is greater than the maxSpeed...
        if (Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > maxSpeed)
        {

            // ... set the player's velocity to the maxSpeed in the x axis.
            GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        // If the player is moving the player right and the player is facing left...

        if (h > 0 && !facingRight)
            // ... flip the player.
            Flip();
        // Otherwise if the player is moving the player left and the player is facing right...
        else if (h < 0 && facingRight)
            // ... flip the player.
            Flip();
        
        // If the player should jump...
        if (jump && grounded)
        {
            //activeState = 2;

            // Add a vertical force to the player.
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));

            // Make sure the player can't jump again until the jump conditions from Update are satisfied.
            jump = false;
        }
    }
    void Flip()
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void shootProjectile()
    {

        if (facingRight)
        {
            // ... instantiate the rocket facing right and set it's velocity to the right. 
            Rigidbody2D bulletInstance = Instantiate(projectile, projectileSpot.transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
            bulletInstance.velocity = new Vector2(speed, 0);


        }
        else
        {
            // Otherwise instantiate the rocket facing left and set it's velocity to the left.
            Rigidbody2D bulletInstance = Instantiate(projectile, projectileSpot.transform.position, Quaternion.Euler(new Vector3(0, 0, 180f))) as Rigidbody2D;
            bulletInstance.velocity = new Vector2(-speed, 0);
        }
    }

    private IEnumerator shootingCooldown()
    {
        activeState = 3;
        // Wait for time you want
        //yield return new WaitForSeconds(.3f);
        StartCoroutine(waitForAnim());

        isCooldown = false;
        // Stop cooldown
        yield return new WaitForSeconds(.8f);
        isCooldown = true;
    }

    private IEnumerator waitForAnim()
    {
        yield return new WaitForSeconds(.3f);
        shootProjectile();
    }

    private IEnumerator meleeCooldown()
    {
        activeState = 3;
        yield return new WaitForSeconds(0.15f);
        Vector3 collider = new Vector3(colliderMelee.transform.position.x, colliderMelee.transform.position.y , colliderMelee.transform.position.z);
        meleeCollider = Instantiate(meleeCol, collider, Quaternion.Euler(new Vector3(0, 0, 0)));

        
        
        Destroy(meleeCollider, 0.1f);
        // Start cooldown
        isCooldown = false;
        // Wait for time you want
        yield return new WaitForSeconds(cooldownTime);
        // Stop cooldown
        isCooldown = true;
    }
}
