using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour
{
    public bool isDisabled;

    // Start is called before the first frame update
    void Start()
    {
        if (isDisabled)
        {
            Disable();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            Enable();
        }
        if (Input.GetKeyDown("space"))
        {
            Disable();
        }
    }

    private void Disable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Enable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
