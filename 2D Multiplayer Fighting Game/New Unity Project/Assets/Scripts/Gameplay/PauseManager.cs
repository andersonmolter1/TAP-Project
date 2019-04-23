using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauser;
    public bool isMainMenu;

    void Start()
    {
        Resume();
    }

    void Update()
    {
        if(isMainMenu)
        {
            Resume();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        /* MAKE THE CODE UNPAUSE WHEN THE USER LOADS MAIN MENU
        if ()
        {
            Resume();
        }
        */
    }

    public void Resume()
    {
        if (isMainMenu)
        {
            Time.timeScale = 1f;
            paused = false;
        }
        if (!isMainMenu)
        {
            pauser.SetActive(false);
            Time.timeScale = 1f;
            paused = false;
        }
    }

    void Pause()
    {
        pauser.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }
}
