using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeAttacks : MonoBehaviour
{
    private PlayerControl playerCtrl;       // Reference to the PlayerControl script.
    private Animator anim;                  // Reference to the Animator component.
    public string meleeInput;

    void Awake()
    {
        // Setting up the references.
        anim = transform.root.gameObject.GetComponent<Animator>();
        playerCtrl = transform.root.GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(meleeInput))
        {
            playerCtrl.activeState = 3;
        }
    }
}
