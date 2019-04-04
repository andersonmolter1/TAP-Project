using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Spawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject knight;
    public GameObject archer;
    public GameObject viking;
    public GameObject wizard;
    public GameObject player2;
    private bool isMelee;
    // Start is called before the first frame update
    void Start()
    {
        findPlayer2();
    }

    public void findPlayer2()
    {

        if (playerValues.P2knight)
        {
            Destroy(player2);
            player2 = Instantiate(knight, spawnPoint);
            isMelee = true;

        }
        else if (playerValues.P2archer)
        {
            Destroy(player2);
            player2 = Instantiate(archer, spawnPoint);
            isMelee = false;
        }
        else if (playerValues.P2viking)
        {
            Destroy(player2);
            player2 = Instantiate(viking, spawnPoint);
            isMelee = true;
        }
        else if (playerValues.P2wizard)
        {
            Destroy(player2);
            player2 = Instantiate(wizard, spawnPoint);
            isMelee = false;
        }
        else
        {
            return;
        }

        player2.transform.gameObject.tag = "player2";
        player2.GetComponent<PlayerControl>().playerId = 1;
        //player2.GetComponent<PlayerControl>().horiztonal = "P2_Horizontal";
        //player2.GetComponent<PlayerControl>().jumpButton = "P2_Jump";
        player2.GetComponent<PlayerControl>().isMelee = isMelee;
        //player2.GetComponent<PlayerControl>().attack = "P2_Fire";
        player2.GetComponent<ChangeColor>().playerNumber = 2;

    }

    public void DestroyPlayer()
    {
        Destroy(player2);
    }
}
