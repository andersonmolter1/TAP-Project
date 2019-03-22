using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player4Spawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject knight;
    public GameObject archer;
    public GameObject viking;
    public GameObject wizard;
    public GameObject player4;
    private bool isMelee;
    // Start is called before the first frame update
    void Start()
    {
        findPlayer4();
    }

    public void findPlayer4()
    {

        if (playerValues.P4knight)
        {
            Destroy(player4);
            player4 = Instantiate(knight, spawnPoint);
            isMelee = true;

        }
        else if (playerValues.P4archer)
        {
            Destroy(player4);
            player4 = Instantiate(archer, spawnPoint);
            isMelee = false;
        }
        else if (playerValues.P4viking)
        {
            Destroy(player4);
            player4 = Instantiate(viking, spawnPoint);
            isMelee = true;
        }
        else if (playerValues.P4wizard)
        {
            Destroy(player4);
            player4 = Instantiate(wizard, spawnPoint);
            isMelee = false;
        }
        else
        {
            return;
        }

        player4.transform.gameObject.tag = "player4";
        player4.GetComponent<PlayerControl>().horiztonal = "P4_Horizontal";
        player4.GetComponent<PlayerControl>().jumpButton = "P4_Jump";
        player4.GetComponent<PlayerControl>().isMelee = isMelee;
        player4.GetComponent<PlayerControl>().attack = "P4_Fire";
        player4.GetComponent<ChangeColor>().playerNumber = 4;
        

    }
    public void DestroyPlayer()
    {
        Destroy(player4);
    }

}
