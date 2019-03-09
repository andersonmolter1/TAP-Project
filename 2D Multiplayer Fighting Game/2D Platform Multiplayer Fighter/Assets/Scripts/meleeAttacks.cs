using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeAttacks : MonoBehaviour
{

    public Rigidbody2D meleeCol;
    public GameObject weapon;
    private PlayerControl playerCtrl;       // Reference to the PlayerControl script.
    private Animator anim;                  // Reference to the Animator component.
    public string meleeInput;

    void Awake()
    {
        GameObject tempWep = new GameObject("weapon");
        // Setting up the references.
        anim = transform.root.gameObject.GetComponent<Animator>();
        playerCtrl = transform.root.GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(meleeInput))
        {
            Debug.Log("fire");
            Rigidbody2D meleeCollider = Instantiate(meleeCol, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
            //need to destroy gameObject but comes with error "Destroying assets is not permitted to avoid data loss."


            playerCtrl.activeState = 3;
            
        }
        
    }
    private void Destroy()
    {
        
        Destroy(weapon);
    }
}
