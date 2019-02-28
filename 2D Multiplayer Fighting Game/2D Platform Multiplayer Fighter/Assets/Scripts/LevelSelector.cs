using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * 
 * Need to fix/separate character selection from levels.
 */ 
 
public class LevelSelector : MonoBehaviour
{
    public Button castleLevel;
    public Button pirateLevel;

    // Start is called before the first frame update
    void Start()
    {
        castleLevel.onClick.AddListener(delegate { SceneManager.LoadScene("CharacterSelector"); } );
        pirateLevel.onClick.AddListener(delegate { SceneManager.LoadScene("PirateShip"); });
    }

    void Update()
    {
        castleLevel.onClick.AddListener(delegate { SceneManager.LoadScene("CharacterSelector"); });
        pirateLevel.onClick.AddListener(delegate { SceneManager.LoadScene("PirateShip"); });
    }

}
