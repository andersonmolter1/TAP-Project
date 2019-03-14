using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCount : MonoBehaviour
{
    public Button one;
    public Button two;
    public Button three;
    public Button four;
     
    // Start is called before the first frame update
    void Start()
    {
        one.onClick.AddListener(One);
        two.onClick.AddListener(Two);
        three.onClick.AddListener(Three);
        four.onClick.AddListener(Four);

    }

    void One()
    {
        playerValues.playerCount = 1;
    }

    void Two()
    {
        playerValues.playerCount = 2;
    }

    void Three()
    {
        playerValues.playerCount = 3;
    }
    void Four()
    {
        playerValues.playerCount = 4;
    }
}
