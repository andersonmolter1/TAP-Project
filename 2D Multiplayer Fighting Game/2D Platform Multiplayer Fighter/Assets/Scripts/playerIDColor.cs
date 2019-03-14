using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIDColor : MonoBehaviour
{
    
    public GameObject playerID;

    [HideInInspector]
    public string color;
    void Start()
    {
        Renderer rend = playerID.GetComponent<Renderer>();
        if (color == "red")
        {
            rend.material.color = Color.red;
        }
        else if (color == "blue")
        {
            rend.material.color = Color.blue;
        }
        else if (color == "green")
        {
            Debug.Log("green");
            rend.material.color = Color.green;
        }
        else if (color == "yellow")
        {
            rend.material.color = Color.yellow;
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
    
}
