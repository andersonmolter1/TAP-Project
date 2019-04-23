using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //floats
    public float speed; //default speed value for player movement               
    public float moveForce = 365f; //force for moving the player from lef tot right
    public float maxSpeed = 5f; // The fastest the player can travel in the x axis
    public float jumpForce = 1000f; //default jump value while not on the wall
    public float wallJumpForce; //amount of force added when the player jumps on the on a wall 

    //booleans
    public bool grounded; //condition for if player is on the ground or not to prevent double jumping
    public bool onWall; //condition for if player on the wall
    public bool facingRight = true;
    public bool jump;
    public bool wallJump;


    //strings
    public string jumpButton = "Jump"; //button for jumping
    public string horiztonal = "Horizontal"; //for horizontal movement 

    //objects && other
    public Animator animator; //reference to animator
    private Transform groundCheck;
    public Rigidbody2D rgb2d = new Rigidbody2D(); //new rigidbody object
    WallGrab wallgrab = new WallGrab(); //object reference to wallgrab script
    SoundEffects se = new SoundEffects(); //allows use of soundeffects

    void Update()
    {
        // conditions for jump on ground
        if (Input.GetButtonDown(jumpButton) && grounded)
        {
            se.soundEffect("JumpSFX");
            jump = true;
        }

        //conditions for jump on wall
        if (Input.GetButtonDown(jumpButton) && onWall)
        {
            se.soundEffect("JumpSFX");
            wallJump = true;
        }
    }


    void FixedUpdate()
    {
        //horizontal input.
        float hInput = Input.GetAxis(horiztonal);
        float hVelocityX = GetComponent<Rigidbody2D>().velocity.x;
        float hVelocityY = GetComponent<Rigidbody2D>().velocity.y;

        //sets float for speed variable in animator
        animator.SetFloat("Run", Mathf.Abs(hInput));

        
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * hInput * moveForce);

        
        // If the input is moving the player right and the player is facing left...
        if (hInput > 0 && !facingRight)
            // ... flip the player.
        {
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (hInput < 0 && facingRight)
            // ... flip the player.
        {
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

        if (onWall)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, wallJumpForce));
            onWall = false;
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

    void Flip()
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
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
            animator.SetBool("onWall", true);
        }
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
            animator.SetBool("onWall", false);
        }
    }
}

