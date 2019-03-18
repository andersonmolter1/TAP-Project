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
    private GameObject player2;
    private bool isMelee;
    // Start is called before the first frame update
    void Start()
    {
        findPlayer2();
    }

    void findPlayer2()
    {

        if (playerValues.P2knight)
        {
            player2 = Instantiate(knight, spawnPoint);
            isMelee = true;

        }
        else if (playerValues.P2archer)
        {
            player2 = Instantiate(archer, spawnPoint);
            isMelee = false;
        }
        else if (playerValues.P2viking)
        {
            player2 = Instantiate(viking, spawnPoint);
            isMelee = true;
        }
        else if (playerValues.P2wizard)
        {
            player2 = Instantiate(wizard, spawnPoint);
            isMelee = false;
        }
        else
        {
            return;
        }

        player2.transform.gameObject.tag = "player2";
        player2.GetComponent<PlayerControl>().horiztonal = "P2_Horizontal";
        player2.GetComponent<PlayerControl>().jumpButton = "P2_Jump";
        player2.GetComponent<PlayerControl>().isMelee = isMelee;
        player2.GetComponent<PlayerControl>().attack = "P2_Fire";


    }
}
