using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUnloader : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Debug.Log(SceneManager.GetSceneAt(i).name);
        }
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            if (SceneManager.GetSceneAt(i).name.Equals("Castle")) {
                i++;
            }
            else {
                string name = SceneManager.GetSceneAt(i).name;
                SceneManager.UnloadSceneAsync(name);
                 }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
