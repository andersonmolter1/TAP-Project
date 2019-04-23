using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIceCream : MonoBehaviour
{
    public GameObject iceCream;
    public GameObject gold;
    public Transform playerPos;
    public int itemYPos;
    public int maxY = -2;
    public int goldYSpawn = 8;
    public bool isWut;
    public bool isMainMenu;
    private float timeCount = 0.0f;
    private float timeThreshold = 0.0f;

    private void createIceCream()//x = -5/4
    {
        if (isWut)
        {
            itemYPos = (int)playerPos.position.y + 10;
            int randNum = Random.Range(-5, 4);
            GameObject item = Instantiate(iceCream, new Vector3Int(randNum, itemYPos, 0), Quaternion.identity) as GameObject;
        }
        if(isMainMenu)
        {
            int randNum = Random.Range(-150, 150);
            GameObject item = Instantiate(iceCream, new Vector3Int(randNum, 120, 91), Quaternion.identity) as GameObject;
        }
    }

    private void createGold()//x = -5/4
    {
        itemYPos = (int)playerPos.position.y + 10;
        int randNum = Random.Range(-5, 4);
        GameObject item = Instantiate(gold, new Vector3Int(randNum, itemYPos, 0), Quaternion.identity) as GameObject;
    }

    void Update()
    {
        if (isWut)
        {
            timeCount = Time.time;
            if(timeCount > timeThreshold)//Creates ice cream every 0.5 seconds
            {
                //createIceCream();
                timeThreshold += 0.5f;//Change the timeThreshold to change the time Ice Cream spawns
            }
            //createIceCream();//Keeps creating ice cream
            if ((int)playerPos.position.y > maxY)//Only creates ice cream when player goes above their highest point
            {
                maxY = (int)playerPos.position.y;
                createIceCream();
            }
            if((int)playerPos.position.y > goldYSpawn)//Creates gold every 10 walls
            {
                goldYSpawn += 10;
                createGold();
            }
        }
        if(isMainMenu)
        {
            createIceCream();
        }
    }
}
