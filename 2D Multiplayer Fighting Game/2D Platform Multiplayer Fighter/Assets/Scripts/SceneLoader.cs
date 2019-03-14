using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public static string level;
    public static string map;

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


}
