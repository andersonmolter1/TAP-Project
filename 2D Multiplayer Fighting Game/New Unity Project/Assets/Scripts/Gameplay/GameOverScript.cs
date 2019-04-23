using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject prefab;
    public GameObject gameOverScreen;
    public static bool dead = false;

    void Update()
    {
        if (dead == true)
        {
            gameOverScreen.SetActive(false);
        }
        if (prefab == null)
        {
            gameOverScreen.SetActive(true);
            //PlayerPrefs.SetString("GameOver", "true");
        }
    }
}
