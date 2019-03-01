using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * 
 * Need to fix/separate character selection from levels.
 */ 
 
public class LevelSelector : MonoBehaviour
{
   
    // Start is called before the first frame update
    public void StartLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

}
