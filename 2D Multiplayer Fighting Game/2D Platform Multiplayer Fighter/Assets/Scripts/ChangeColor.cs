using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    
    public int playerNumber;

    public GameObject playerID1;
    public GameObject playerID2;
    public GameObject playerID3;

    private void Start()
    {
        ChangeColorID(playerNumber);
    }

    private void Update()
    {
        
    }
    void ChangeColorID(int playerNumber)
    {
        Renderer playerID1Render = playerID1.GetComponent<Renderer>();
        Renderer playerID2Render = playerID2.GetComponent<Renderer>();
        Renderer playerID3Render = playerID3.GetComponent<Renderer>();
        switch (playerNumber)
        {
            case 1:
                playerID1Render.material.color = Color.red;
                playerID2Render.material.color = Color.red;
                playerID3Render.material.color = Color.red;
                break;
            case 2:
                playerID1Render.material.color = Color.green;
                playerID2Render.material.color = Color.green;
                playerID3Render.material.color = Color.green;
                break;
            case 3:
                playerID1Render.material.color = Color.yellow;
                playerID2Render.material.color = Color.yellow;
                playerID3Render.material.color = Color.yellow;
                break;
            case 4:
                playerID1Render.material.color = Color.blue;
                playerID2Render.material.color = Color.blue;
                playerID3Render.material.color = Color.blue;
                break;

        }
        
    }
}
