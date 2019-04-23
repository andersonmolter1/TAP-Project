using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experiment : MonoBehaviour
{
    public GameObject iceCream;
    public Transform playerPos;
    public int itemYPos;
    public int maxY = -2;

    private void createIceCream()//x = -5/4
    {
        itemYPos = (int)playerPos.position.y + 10;
        int randNum = Random.Range(-5, 4);
    }

    void Update()
    {
            createIceCream(); 
    }
}
