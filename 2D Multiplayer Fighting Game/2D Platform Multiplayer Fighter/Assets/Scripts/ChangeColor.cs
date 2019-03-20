using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    
    public int playerNumber;

    public GameObject playerID;

    private void Start()
    {
        ChangeColorID(playerNumber);
    }

    private void Update()
    {
        
    }
    void ChangeColorID(int playerNumber)
    {
        Renderer playerIDRender = playerID.GetComponent<Renderer>();
        switch (playerNumber)
        {
            case 1:
                playerIDRender.material.color = Color.red;
                break;
            case 2:
                playerIDRender.material.color = Color.green;
                break;
            case 3:
                playerIDRender.material.color = Color.yellow;
                break;
            case 4:
                playerIDRender.material.color = Color.blue;
                break;

        }
        
    }
}
