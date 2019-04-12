using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Pauser : MonoBehaviour
{
    private bool paused = false;
    GameObject[] pauseObjects;
    StandaloneInputModule sim;

    private void Start()
    {
        pauseObjects = GameObject.FindGameObjectsWithTag("pause");
        hidePaused();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            togglePause();
        }
        if (Input.GetButtonDown("P1_Start"))
        {
            togglePause();
            setSIM("P1");
        }
        if (Input.GetButtonDown("P2_Start"))
        {
            togglePause();
            setSIM("P2");
        }
        if (Input.GetButtonDown("P3_Start"))
        {
            togglePause();
            setSIM("P3");
        }
        if (Input.GetButtonDown("P4_Start"))
        {
            togglePause();
            setSIM("P4");
        }
    }

    public void togglePause()
    {
        if (paused)
        {
            Time.timeScale = 1f;
            paused = false;
            hidePaused();
        }
        else
        {
            Time.timeScale = 0f;
            paused = true;
            showPaused();


        }
    }


    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    void setSIM(string player)
    {
        if (player.Equals("P1"))
        {
            sim.horizontalAxis = "P1_Dpad_Horizontal";
            sim.verticalAxis = "P1_Dpad_Vertical";
            sim.submitButton = "P1_Submit";
            sim.cancelButton = "P1_Cancel";
        }
        if (player.Equals("P2"))
        {

            sim.horizontalAxis = "P2_Dpad_Horizontal";
            sim.verticalAxis = "P2_Dpad_Vertical";
            sim.submitButton = "P2_Submit";
            sim.cancelButton = "P2_Cancel";
        }
        if (player.Equals("P3"))
        {

            sim.horizontalAxis = "P3_Dpad_Horizontal";
            sim.verticalAxis = "P3_Dpad_Vertical";
            sim.submitButton = "P3_Submit";
            sim.cancelButton = "P3_Cancel";
        }
        if (player.Equals("P4"))
        {
            sim.horizontalAxis = "P4_Dpad_Horizontal";
            sim.verticalAxis = "P4_Dpad_Vertical";
            sim.submitButton = "P4_Submit";
            sim.cancelButton = "P4_Cancel";
        }
    }
}
