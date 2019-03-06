using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    public Rigidbody2D projectile;               // Prefab of the rocket.
    public float speed = 20f;				// The speed the rocket will fire at.
    public string gunFire = "Fire1_P1";

    private PlayerControl playerCtrl;       // Reference to the PlayerControl script.
    private Animator anim;                  // Reference to the Animator component.


    void Awake()
    {
        // Setting up the references.
        anim = transform.root.gameObject.GetComponent<Animator>();
        playerCtrl = transform.root.GetComponent<PlayerControl>();
    }


    void Update()
    {
        projectile.gravityScale = 0;
        // If the fire button is pressed...
        if (Input.GetButtonDown(gunFire))
        {
            playerCtrl.activeState = 3;
            shootProjectile();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit ground");
    }
    //trial of delayed shooting
    /*
    IEnumerator waitForNextShot()
    {
        Debug.Log("fire");
        Invoke("shoot", 0.5f);
        yield return new WaitForSeconds(1);
        

    }
    */

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
}
