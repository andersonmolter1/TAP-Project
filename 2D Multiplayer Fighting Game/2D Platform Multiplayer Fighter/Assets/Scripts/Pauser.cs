using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pauser : MonoBehaviour {
	private bool paused = false;
    GameObject[] pauseObjects;


    private void Start()
    {
        pauseObjects = GameObject.FindGameObjectsWithTag("pause");
        hidePaused();
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton7))
		{
            togglePause();
		}


	}

    public void togglePause() {
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
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    public void hidePaused() {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
}
