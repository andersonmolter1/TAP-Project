using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGrab : MonoBehaviour
{
    
    public bool wallSliding; //when wallsliding is true, fall velocity will be slower
    public bool wallCheck; //check if player is on wall
    public float jump; //sets jump value

    
    //objects
    ScratchPlayerController pc =  new ScratchPlayerController(); // object to reference playercontroller script
    
  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pc.grounded)///if grounded is false on playercontroller, check condition for wall
        {
            wallCheck = pc.onWall;
        }
        
        if (wallCheck) //if wallcheck is true, WallSliding method is called
        {
            WallSliding();
        }

        if (wallCheck == false && pc.grounded) //if wallCheck is false, wallsliding is set to false as well
        {
            wallSliding = false;
        }
    }

    void WallSliding()
    {
        //assigns slower velocity along y axis(falling) when on the wall
        pc.rgb2d.velocity = new Vector2(pc.rgb2d.velocity.x, -0.7f);

        wallSliding = true;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if player jumps while on wall, a new jump value is assigned
            pc.rgb2d.velocity = new Vector2(pc.rgb2d.velocity.x, jump);
        }
    }
}