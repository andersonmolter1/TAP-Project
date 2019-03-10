using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeAttacks : MonoBehaviour
{
    private GameObject meleeCollider;
    public GameObject meleeCol;
    private PlayerControl playerCtrl;       // Reference to the PlayerControl script.
    private Animator anim;                  // Reference to the Animator component.
    public string meleeInput;
    private bool attackOnce = true;
    public string colliderTag;
    public int num = 0;

    void Awake()
    {
        // Setting up the references.
        anim = transform.root.gameObject.GetComponent<Animator>();
        playerCtrl = transform.root.GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(meleeInput) && attackOnce)
        {
            num++;
            meleeCollider = Instantiate(meleeCol, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            //need to destroy gameObject but comes with error "Destroying assets is not permitted to avoid data loss."
            playerCtrl.activeState = 3;
            attackOnce = false;
            Destroy(meleeCollider, 0.2f);
        }
        if (GameObject.Find(colliderTag) == null)
        {

            attackOnce = true;
        }
    }
}
