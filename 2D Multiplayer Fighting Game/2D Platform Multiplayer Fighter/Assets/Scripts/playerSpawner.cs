using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject knight;
    public GameObject archer;
    public GameObject viking;
    public GameObject wizard;
    private int spawnIndex;
    private GameObject player1;
    private GameObject player2;
    private GameObject player3;
    private GameObject player4;

    // Start is called before the first frame update
    void Start()
    {
        findPlayer1();
        findPlayer2();
        findPlayer3();
        findPlayer4();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void findPlayer1()
    {
        spawnIndex = Random.Range(0, spawnPoints.Length);
        if (playerValues.P1knight)
        {
            player1 = Instantiate(knight, spawnPoints[0]);
        }
        else if (playerValues.P1archer)
        {
            player1 = Instantiate(archer, spawnPoints[0]);
        }
        else if (playerValues.P1viking)
        {
            player1 = Instantiate(viking, spawnPoints[0]);
        }
        else if (playerValues.P1wizard)
        {
            player1 = Instantiate(wizard, spawnPoints[0]);
        }
        else
        {
            return;
        }

        player1.transform.gameObject.tag = "player1";
        player1.GetComponent<PlayerControl>().horiztonal = "P1_Horizontal";
        player1.GetComponent<PlayerControl>().jumpButton = "P1_Jump";
        player1.GetComponent<PlayerControl>().attack = "P1_Fire";
    }
    void findPlayer2()
    {
        spawnIndex = Random.Range(0, spawnPoints.Length);
        if (playerValues.P2knight)
        {
            player2 = Instantiate(knight, spawnPoints[1]);
        }
        else if (playerValues.P2archer)
        {
            player2 = Instantiate(archer, spawnPoints[1]);
        }
        else if (playerValues.P2viking)
        {
            player2 = Instantiate(viking, spawnPoints[1]);
        }
        else if (playerValues.P2wizard)
        {
            player2 = Instantiate(wizard, spawnPoints[1]);
        }
        else
        {
            return;
        }

        player2.transform.gameObject.tag = "player2";
        player2.GetComponent<PlayerControl>().horiztonal = "P2_Horizontal";
        player2.GetComponent<PlayerControl>().jumpButton = "P2_Jump";
        player2.GetComponent<PlayerControl>().attack = "P2_Fire";
    }
    void findPlayer3()
    {
        spawnIndex = Random.Range(0, spawnPoints.Length);
        if (playerValues.P3knight)
        {
            player3 = Instantiate(knight, spawnPoints[2]);
        }
        else if (playerValues.P3archer)
        {
            player3 = Instantiate(archer, spawnPoints[2]);
        }
        else if (playerValues.P3viking)
        {
            player3 = Instantiate(viking, spawnPoints[2]);
        }
        else if (playerValues.P3wizard)
        {
            player3 = Instantiate(wizard, spawnPoints[2]);
        }
        else
        {
            return;
        }

        player3.transform.gameObject.tag = "player3";
        player3.GetComponent<PlayerControl>().horiztonal = "P3_Horizontal";
        player3.GetComponent<PlayerControl>().jumpButton = "P3_Jump";
        player3.GetComponent<PlayerControl>().attack = "P3_Fire";
    }
    void findPlayer4()
    {
        spawnIndex = Random.Range(0, spawnPoints.Length);
        if (playerValues.P4archer)
        {
            player4 = Instantiate(knight, spawnPoints[3]);
        }
        else if (playerValues.P4archer)
        {
            player4 = Instantiate(archer, spawnPoints[3]);
        }
        else if (playerValues.P4viking)
        {
            player4 = Instantiate(viking, spawnPoints[3]);
        }
        else if (playerValues.P4wizard)
        {
            player4 = Instantiate(wizard, spawnPoints[3]);
        }
        else
        {
            return;
        }

        player4.transform.gameObject.tag = "player4";
        player4.GetComponent<PlayerControl>().horiztonal = "P4_Horizontal";
        player4.GetComponent<PlayerControl>().jumpButton = "P4_Jump";
        player4.GetComponent<PlayerControl>().attack = "P4_Fire";

    }
}
