using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public static string level;

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

}
