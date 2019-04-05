using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeAttacks : MonoBehaviour
{
    private GameObject meleeCollider;
    public GameObject meleeCol;
    private PlayerControl playerCtrl;       // Reference to the PlayerControl script.
    private Animator anim;                  // Reference to the Animator component.
    private string meleeInput;
    public string colliderTag;
    private float cooldownTime = .8f;
    private bool isCooldown;
    


    void Awake()
    {
        PlayerControl pc = new PlayerControl();
        //meleeInput = pc.attack;
        isCooldown = true;
        // Setting up the references.
        anim = transform.root.gameObject.GetComponent<Animator>();
        playerCtrl = transform.root.GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetButtonDown(attack) && isCooldown)
        {
            
            StartCoroutine(Cooldown());
        }
        
    }
    private IEnumerator Cooldown()
    {
        meleeCollider = Instantiate(meleeCol, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        //need to destroy gameObject but comes with error "Destroying assets is not permitted to avoid data loss."
        playerCtrl.activeState = 3;
        Destroy(meleeCollider, 0.1f);
        // Start cooldown
        isCooldown = false;
        // Wait for time you want
        yield return new WaitForSeconds(cooldownTime);
        // Stop cooldown
        isCooldown = true;
    }

}
