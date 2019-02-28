using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/*
 * Missing is ability to generalize level to start. Need to
 * pass the level selected to here (or find better solution)
 */

public class StartLevel : MonoBehaviour
{

    public Button startLevel;
    // This ONLY starts castle for now.
    void Start()
    {
        startLevel.onClick.AddListener(delegate { SceneManager.LoadScene("Castle"); });
    }

    void Update()
    {
        
    }
}
