using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;
using System.Runtime.Serialization;

public class PlayerControl : MonoBehaviour
{
    [HideInInspector]
    public bool facingRight = true;         // For determining which way the player is currently facing.
    [HideInInspector]
    public bool jump = false;               // Condition for whether the player should jump.


    public float moveForce = 365f;          // Amount of force added to move the player left and right.
    public float maxSpeed = 5f;             // The fastest the player can travel in the x axis.
   // public AudioClip[] jumpClips;           // Array of clips for when the player jumps.
    public float jumpForce = 1000f;
    public float wallJumpForce;// Amount of force added when the player jumps.
    
    

    
    private Transform groundCheck;          // A position marking where to check if the player is grounded.
    private bool grounded = false;
    private bool onWall;// Whether or not the player is grounded.
    private bool wallJump;
    public Animator animator;                  //reference to animator
    public string jumpButton = "Jump";
    public string horiztonal = "Horizontal";

    //public int iceCreamCount;
    //public GameObject tilemapCoin;
    //Tilemap tilemap;
    

    void Awake()
    {
        groundCheck = transform.Find("groundCheck");
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        //tilemap = tilemapCoin.GetComponent<Tilemap>();

        //if (isRegular)
        //{
        //    PlayerPrefs.SetInt("IceCream", 0);
        //    iceCreamCount = 0;
        //}
        //if (isGold)
        //{
        //    PlayerPrefs.SetInt("Gold", 0);
        //    goldCount = 0;
        //}
    }

    void Update()
    {
       // conditions for jump
       if (Input.GetButtonDown(jumpButton) && grounded)
       {
           jump = true;
       }

       if (Input.GetButtonDown(jumpButton) && onWall)
       {
           wallJump = true;
       }
    }


    void FixedUpdate()
    {
        //horizontal input.
        float h = Input.GetAxis(horiztonal);

         //sets float for speed variable in animator
        animator.SetFloat("Run", Mathf.Abs(h));

        // If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
        if (h * GetComponent<Rigidbody2D>().velocity.x < maxSpeed)
            // ... add a force to the player.
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * h * moveForce);

        // If the player's horizontal velocity is greater than the maxSpeed...
        if (Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > maxSpeed)
            // ... set the player's velocity to the maxSpeed in the x axis.
            GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        // If the input is moving the player right and the player is facing left...
        if (h > 0 && !facingRight)
        // ... flip the player.
        {
            animator.SetBool("Facing Right", false);
            animator.SetBool("Facing Left", true);
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (h < 0 && facingRight)
        // ... flip the player.
        {
            animator.SetBool("Facing Right", true);
            animator.SetBool("Facing Left", false);
            Flip();
        }
        // If the player should jump...
        if (jump)
        {
            // Set the Jump animator trigger parameter.
            animator.SetTrigger("Jump");

            //Add a vertical force to the player.
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));

            // Make sure the player can't jump again until the jump conditions from Update are satisfied.
            jump = false;
        }

        if (wallJump)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, wallJumpForce));
            wallJump = false;
        }
    }
        
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Floor"))
        {
            grounded = true;
        }

        if (col.gameObject.CompareTag("Wall"))
        {
            onWall = true;
            animator.SetBool("OnWall", true);
        }
        //Debug.LogWarning(col.gameObject.tag);
        //if (col.gameObject.CompareTag("coin"))
        //{
        //    Debug.LogWarning("coin should Snatch");
        //    Vector3Int hitPos = Vector3Int.zero;
        //    if (tilemapCoin == col.gameObject)
        //    {
        //        foreach (ContactPoint2D hit in col.contacts)
        //        {
        //            hitPos.x = (int)hit.point.x;
        //            hitPos.y = (int)hit.point.y;
        //            tilemap.SetTile(tilemap.WorldToCell(hitPos), null);
        //            iceCreamCount++;
        //        }
        //    }
        //}    
    }


    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Floor"))
        {
            grounded = false;
        }

        if (col.gameObject.CompareTag("Wall"))
        {
            onWall = false;
            animator.SetBool("OnWall", false);
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
}
