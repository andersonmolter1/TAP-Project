using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("P1_Start")
            || Input.GetKeyDown(KeyCode.Return)
            || Input.GetKeyDown("space")
            || Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("MapSelector");
        }
    }
}
