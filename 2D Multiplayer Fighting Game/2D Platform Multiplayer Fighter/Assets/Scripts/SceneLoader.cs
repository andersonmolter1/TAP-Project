using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * 
 * Need to fix/separate character selection from levels.
 */

public class SceneLoader : MonoBehaviour
{
    public static string level;

    public void SetLevel(string thisLevel)
    {
        level = thisLevel;
    }

    public void CharacterSelect() {
        SceneManager.LoadScene("CharacterSelection");
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(level);
    }

}
