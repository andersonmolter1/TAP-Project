using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void RestartLevel()
    {
        Scene sc = SceneManager.GetActiveScene();
        SceneManager.SetActiveScene(sc);
    }
}
