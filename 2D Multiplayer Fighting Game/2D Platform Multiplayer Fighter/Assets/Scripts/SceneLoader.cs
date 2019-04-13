using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public static string level;
    public static string map;
    public string currentLevel;

    public void SetLevel(string thisLevel)
    {
        level = thisLevel;
    }

    public void CharacterSelect()
    {
        SceneManager.LoadScene("Player1Selector");
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(level);
    }

    public void SetMap(string thismap)
    {
        map = thismap;
    }

    public void StartMap()
    {
        SceneManager.LoadScene(map);

    }


    private void Update()
    {
        if (currentLevel.Equals("Player1Selector"))
        {
            if (Input.GetButtonDown("P1_Start"))
            {
                StartMap();
            }
        }
        else if (currentLevel.Equals("Player2Selector"))
        {
            if (Input.GetButtonDown("P2_Start"))
            {
                StartMap();
            }
        }
        else if (currentLevel.Equals("Player3Selector"))
        {
            if (Input.GetButtonDown("P3_Start"))
            {
                StartMap();
            }
        }
        else if (currentLevel.Equals("Player4Selector"))
        {
            if (Input.GetButtonDown("P4_Start"))
            {
                StartMap();
            }
        }

    }


}
