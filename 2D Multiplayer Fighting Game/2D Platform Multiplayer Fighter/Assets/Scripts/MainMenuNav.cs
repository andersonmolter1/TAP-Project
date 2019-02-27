using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuNav : MonoBehaviour
{
    public Button Button;
    public int levelIndex = 0;
    void Start()
    {
        Button.onClick.AddListener(delegate { LoadByIndex(levelIndex); });
    }


    public void LoadByIndex(int levelIndex)
    {
        SceneManager.LoadScene("Castle");
    }
}