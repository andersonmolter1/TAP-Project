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
        // If the fire button is pressed...
        if (Input.GetButtonDown(gunFire))
        {

            // ... set the animator Shoot trigger parameter and play the audioclip.
            //anim.SetTrigger("Shoot");


            // If the player is facing right...
            if (playerCtrl.facingRight)
            {
                // ... instantiate the rocket facing right and set it's velocity to the right. 
                Rigidbody2D bulletInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
                bulletInstance.velocity = new Vector2(speed, 4);
            }
            else
            {
                // Otherwise instantiate the rocket facing left and set it's velocity to the left.
                Rigidbody2D bulletInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0, 0, 180f))) as Rigidbody2D;
                bulletInstance.velocity = new Vector2(-speed, 4);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit ground");
    }
    IEnumerator waitForNextShot()
    {
        
        yield return new WaitForSeconds(2);
        
    }
    public void destroyArrow()
    {
        Destroy(projectile);
    }
}
