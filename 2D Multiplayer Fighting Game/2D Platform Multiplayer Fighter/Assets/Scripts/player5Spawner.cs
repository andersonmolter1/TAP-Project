using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player5Spawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject knight;
    public GameObject archer;
    public GameObject viking;
    public GameObject wizard;
    public GameObject player5;
    private bool isMelee;
    // Start is called before the first frame update
    void Start()
    {
        findPlayer5();
    }

    public void findPlayer5()
    {

        if (playerValues.P5knight)
        {
            Destroy(player5);
            player5 = Instantiate(knight, spawnPoint);
            isMelee = true;

        }
        else if (playerValues.P5archer)
        {
            Destroy(player5);
            player5 = Instantiate(archer, spawnPoint);
            isMelee = false;
        }
        else if (playerValues.P5viking)
        {
            Destroy(player5);
            player5 = Instantiate(viking, spawnPoint);
            isMelee = true;
        }
        else if (playerValues.P5wizard)
        {
            Destroy(player5);
            player5 = Instantiate(wizard, spawnPoint);
            isMelee = false;
        }
        else
        {
            return;
        }

        player5.transform.gameObject.tag = "player5";
        player5.GetComponent<PlayerControl>().horiztonal = "P5_Horizontal";
        player5.GetComponent<PlayerControl>().jumpButton = "P5_Jump";
        player5.GetComponent<PlayerControl>().isMelee = isMelee;
        player5.GetComponent<PlayerControl>().attack = "P5_Fire";
        player5.GetComponent<ChangeColor>().playerNumber = 5;
        

    }
    public void DestroyPlayer()
    {
        Destroy(player5);
    }

}
