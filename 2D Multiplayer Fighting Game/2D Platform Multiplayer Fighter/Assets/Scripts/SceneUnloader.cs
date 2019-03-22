using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUnloader : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.UnloadSceneAsync("Player1Selector");
        SceneManager.UnloadSceneAsync("Player2Selector");
        SceneManager.UnloadSceneAsync("Player3Selector");
        SceneManager.UnloadSceneAsync("Player4Selector");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
