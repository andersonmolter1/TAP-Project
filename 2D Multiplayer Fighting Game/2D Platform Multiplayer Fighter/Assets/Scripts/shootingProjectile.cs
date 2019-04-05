using UnityEngine;
using System.Collections;

public class shootingProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;               // Prefab of the rocket.
    public float speed = 20f;				// The speed the rocket will fire at.
    public string gunFire;

    private PlayerControl playerCtrl;       // Reference to the PlayerControl script.
    private Animator anim;                  // Reference to the Animator component.
    private bool isCooldown;


    void Awake()
    {
        PlayerControl pc = new PlayerControl();
        gunFire = "no";
        isCooldown = true;
        // Setting up the references.
       
        playerCtrl = transform.root.GetComponent<PlayerControl>();
    }


    void Update()
    {
        projectile.gravityScale = 0;
        // If the fire button is pressed...
        if (Input.GetButtonDown(gunFire) && isCooldown)
        {

            StartCoroutine(Cooldown());

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit ground");
    }
   
    public void destroyArrow()
    {
        Destroy(projectile);
    }
    public void shootProjectile()
    {

        if (playerCtrl.facingRight)
        {
            // ... instantiate the rocket facing right and set it's velocity to the right. 
            Rigidbody2D bulletInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
            bulletInstance.velocity = new Vector2(speed, 0);


        }
        else
        {
            // Otherwise instantiate the rocket facing left and set it's velocity to the left.
            Rigidbody2D bulletInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0, 0, 180f))) as Rigidbody2D;
            bulletInstance.velocity = new Vector2(-speed, 0);
        }
    }
    private IEnumerator Cooldown()
    {
        playerCtrl.activeState = 3;
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
}
