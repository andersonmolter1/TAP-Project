using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Generator : MonoBehaviour
{
    public Tile pointTile;
    public Tile groundTile;
    public Tilemap Rendered;
    public Tilemap CoinTM;
    public GameObject player;

    public Vector3Int leftWall;
    public Vector3Int rightWall;
    public Vector3Int midWall;

    public Vector3Int platform;
    public Vector3Int coinSpawn;

    public int lwStartX = -6;
    public int rwStartX = 2;
    public int mw;
    public int x;
    public int playerYPos;
    public int highestYPoint;

    public Vector3Int testDelete;
    public bool WallInMiddle = true;


    //  -6  2
    // Start is called before the first frame update
    void Start()//Runs code only at the start
    {
        playerYPos = (int)player.transform.position.y;
        CoinTM.SetTile(testDelete, pointTile);
        //DeleteBlock(testDelete);
    }

    // Update is called once per frame
    void Update()//Always runs code
    {
        genWalls();
        playerYPos = (int)player.transform.position.y;
        //genPlats(); TAISANN COMMENTED THIS OUT
        MaxHeight();//MaxHeight --> genPlatV2 --> Creates walls
    }

    private void genWalls()
    {
        // have counter generates once it is passed.
        // keeps generating
        // maybe add variables to make it more difficult with time
        for (int y = -4; y < highestYPoint + 20; y++)
        {
            leftWall = new Vector3Int(lwStartX, y, 0);
            rightWall = new Vector3Int(rwStartX, y, 0);

            Rendered.SetTile(leftWall, groundTile);
            Rendered.SetTile(rightWall, groundTile);
        }
        //do
        //{
        //    Rendered.SetTile(midWall, groundTile);
        //} while (WallInMiddle == true);
    }

    //WALLS (-6 Left --> -1 Middle --> 4 Right)
    public void genPlatV2()
    {
        int y = highestYPoint + 10;
        int randNum = Random.Range(0, 20);
        print(randNum);
        //wall combos
        if (randNum == 1)
        {
            for (int lwx = -5; lwx <= -4; lwx++) //LeftWall
                                                 //for (int x = -5; x <= 1; x++) //LeftWall TAISANN'S EDIT
            {
                Debug.Log("init left wall");
                platform = new Vector3Int(lwx, y, 0);
                Rendered.SetTile(platform, groundTile);
                Debug.Log("leftwall created");
                Debug.Log(x);
            }
            return;
        }
        else if (randNum == 3)
        {

            for (int rwx = 2; rwx <= 4; rwx++) //RightWall
            {
                Debug.Log("init right wall");
                platform = new Vector3Int(rwx, y, 0);
                Rendered.SetTile(platform, groundTile);
                Debug.Log("rightwall executed");
            }
            return;
        }
        else if (randNum == 0 || randNum == 2 || randNum == 4 || randNum == 6 || randNum == 8 || randNum == 10 || randNum == 12 || randNum == 14 || randNum == 16 || randNum == 18)
        {
            Debug.Log("nothing");
            int coinX = Random.Range(-5, 3);
            coinSpawn = new Vector3Int(coinX, y, 0);
            CoinTM.SetTile(coinSpawn, pointTile);
            return; //Blank
        }
        else if (randNum == 5)
        {

            for (int mwx = -1; mwx <= 1; mwx++) //Right midWall
            {
                Debug.Log("init mid wall");
                platform = new Vector3Int(mwx, y, 0);
                Rendered.SetTile(platform, groundTile);
            }
            return;
        }
        else if (randNum == 7)
        {

            for (int mwx = -2; mwx <= -0; mwx++) //Left midWall
            {
                Debug.Log("init mid wall");
                platform = new Vector3Int(mwx, y, 0);
                Rendered.SetTile(platform, groundTile);
            }
            return;
        }
        else if (randNum == 9 || randNum == 11)
        {
            //mid midWall
            Debug.Log("init mid wall");
            platform = new Vector3Int(-4, y, 0);
            Rendered.SetTile(platform, groundTile);

            platform = new Vector3Int(-3, y, 0);
            Rendered.SetTile(platform, groundTile);

            //platform = new Vector3Int(2, y, 0);
            //Rendered.SetTile(platform, groundTile);

            //platform = new Vector3Int(2, y, 0);
            //Rendered.SetTile(platform, groundTile);
        }
        else if (randNum == 13 || randNum == 15)
        {
            //mid midWall
            Debug.Log("init mid wall");
            platform = new Vector3Int(-2, y, 0);
            Rendered.SetTile(platform, groundTile);

            platform = new Vector3Int(-1, y, 0);
            Rendered.SetTile(platform, groundTile);

            //platform = new Vector3Int(3, y, 0);
            //Rendered.SetTile(platform, groundTile);
        }
        else if (randNum == 17 || randNum == 19 )
        {
            //mid midWall
            Debug.Log("init 10 wall");
            platform = new Vector3Int(-1, y, 0);
            Rendered.SetTile(platform, groundTile);
            //platform = new Vector3Int(-3, y, 0);
            //Rendered.SetTile(platform, groundTile);

            //platform = new Vector3Int(-2, y, 0);
            //Rendered.SetTile(platform, groundTile);


            //platform = new Vector3Int(3, y, 0);
            //Rendered.SetTile(platform, groundTile);

            //platform = new Vector3Int(2, y, 0);
            //Rendered.SetTile(platform, groundTile);

            //platform = new Vector3Int(1, y, 0);
            //Rendered.SetTile(platform, groundTile);
        }
    }

    public void MaxHeight()
    {
        if (playerYPos > highestYPoint)
        {
            highestYPoint = playerYPos;
            genPlatV2();

        }
    }
    public void DeleteBlock(Vector3Int blockInfo)
    {
        Debug.LogWarning("deleteBlock called");
        CoinTM.SetTile(blockInfo, null);
        Debug.LogWarning("is this the smae" + blockInfo);
        Debug.Log(blockInfo + "should be deleted");
    }
}

