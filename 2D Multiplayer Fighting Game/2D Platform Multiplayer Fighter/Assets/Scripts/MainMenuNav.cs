using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Remember to clean this up. Changes to the overall menu/level nav
 * requires changes to this code.
 * 
 */

public class MainMenuNav : MonoBehaviour
{
    public Button game;
   
    void Start()
    {
        game.onClick.AddListener(delegate { SceneManager.LoadScene("MapSelector"); });
    }


   
}