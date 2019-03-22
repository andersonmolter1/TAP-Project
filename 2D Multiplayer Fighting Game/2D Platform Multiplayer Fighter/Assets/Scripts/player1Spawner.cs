using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1Spawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject knight;
    public GameObject archer;
    public GameObject viking;
    public GameObject wizard;
    public GameObject player1;
    private bool isMelee;
    // Start is called before the first frame update
    void Start()
    {
        findPlayer1();
    }

    public void findPlayer1()
    {

        if (playerValues.P1knight)
        {
            Destroy(player1);
            player1 = Instantiate(knight, spawnPoint);
            isMelee = true;
        }
        else if (playerValues.P1archer)
        {
            Destroy(player1);
            player1 = Instantiate(archer, spawnPoint);
            isMelee = false;
        }
        else if (playerValues.P1viking)
        {
            Destroy(player1);
            player1 = Instantiate(viking, spawnPoint);
            isMelee = true;
        }
        else if (playerValues.P1wizard)
        {
            Destroy(player1);
            player1 = Instantiate(wizard, spawnPoint);
            isMelee = false;
        }
        else
        {
            return;
        }

        player1.transform.gameObject.tag = "player1";
        player1.GetComponent<PlayerControl>().horiztonal = "P1_Horizontal";
        player1.GetComponent<PlayerControl>().jumpButton = "P1_Jump";
        player1.GetComponent<PlayerControl>().isMelee = isMelee;
        player1.GetComponent<PlayerControl>().attack = "P1_Fire";
        player1.GetComponent<ChangeColor>().playerNumber = 1;
        


    }

    public void DestroyPlayer()
    {
        Destroy(player1);
    }
}

