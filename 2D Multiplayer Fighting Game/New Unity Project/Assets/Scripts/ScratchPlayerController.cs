using UnityEngine;

public class ScratchPlayerController : MonoBehaviour
{
    //float
    public float speed;        //default speed value for player movement
    public float jump;        //default jump value while not on the wall
    float moveVelocity;        //i can't remember what this variable is for but if i figure it out later i'll comment it in herpaderp
    public float moveForce = 200f;          // Amount of force added to move the player left and right.
    public string horiztonal_P1 = "Horizontal_P1";
    
    
    
    //bool
    public bool grounded;      //condition for if player is on the ground or not to prevent double jumping
    public bool onWall;        //condition for if player on the wall
    
    //objects
    public Rigidbody2D rgb2d = new Rigidbody2D();
    WallGrab wallgrab = new WallGrab(); //object reference to wallgrab script
    
    // Update is called once per frame
    void Update()
    {
        //movement with arrow keys, experimenting with addforce instead of translate
        /** transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f,
             Input.GetAxis("Vertical") * Time.deltaTime);
`        */

        SoundEffects se = new SoundEffects(); //TAISANN'S EDIT ALLOWS USE OF SOUND EFFECTS
       
       
       
       
        //jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if (grounded)
            { //TAISANN EDIT THIS IN
                se.soundEffect("JumpSFX");
                rgb2d.velocity = new Vector2(rgb2d.velocity.x, jump);
            } //TAISANN EDIT THIS IN
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onWall)
            { //TAISANN EDIT THIS IN
                se.soundEffect("JumpSFX");
                rgb2d.velocity = new Vector2(rgb2d.velocity.x, jump);
            }//TAISANN EDIT THIS IN
        }
    }

    //check condition for grounded boolean
    /**  void OnTriggerEnter2D()
      {
          grounded = true;
      }
  
      void OnTriggerExit2D()
      {
          grounded = false;
      }
  
     **/

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Floor"))
        {
            grounded = true;
        }

        if (col.gameObject.CompareTag("Wall"))
        {
            onWall = true;
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
        }
    }
}