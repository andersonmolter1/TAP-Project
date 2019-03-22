using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    private bool spawnBreak = false;
    private Component player1, player2, player3, player4;
    /*//private bool isReadySpawn = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if (collision.gameObject.CompareTag("player1") && playerValues.player1Lives > 0)
        {

            StartCoroutine(WaitToSpawn("player1"));

        }
        else if (collision.gameObject.CompareTag("player2") && playerValues.player2Lives > 0)
        {
            StartCoroutine(WaitToSpawn("player2"));

        }
        else if (collision.gameObject.CompareTag("player3") && playerValues.player3Lives > 0)
        {
            StartCoroutine(WaitToSpawn("player3"));

        }
        else if (collision.gameObject.CompareTag("player4") && playerValues.player4Lives > 0)
        {
            StartCoroutine(WaitToSpawn("player4"));


        }
    
    }
    */
    public IEnumerator WaitToSpawn(string player)
    {
        spawnBreak = true;
        yield return new WaitForSeconds(.8f);
        if (player.Equals("player1") && playerValues.player1Lives > 0)
        {
            GetComponent<player1Spawner>().findPlayer1();
        }
        else if (player.Equals("player2") && playerValues.player2Lives > 0)
        {
            GetComponent<player2Spawner>().findPlayer2();
        }
        else if (player.Equals("player3") && playerValues.player3Lives > 0)
        {
            GetComponent<player3Spawner>().findPlayer3();
        }
        else if (player.Equals("player4") && playerValues.player4Lives > 0)
        {
            GetComponent<player4Spawner>().findPlayer4();
        }
        spawnBreak = false;
    }

    private void Update()
    {
        if (!spawnBreak)
        {
            bool findPlayer1 = !(GameObject.FindGameObjectWithTag("player1"));
            bool findPlayer2 = !(GameObject.FindGameObjectWithTag("player2"));
            bool findPlayer3 = !(GameObject.FindGameObjectWithTag("player3"));
            bool findPlayer4 = !(GameObject.FindGameObjectWithTag("player4"));
            if (playerValues.player1Lives > 0 && findPlayer1)
            {
                StartCoroutine(WaitToSpawn("player1"));
            }
            else if (playerValues.player2Lives > 0 && findPlayer2)
            {
                StartCoroutine(WaitToSpawn("player2"));
            }
            else if (playerValues.player3Lives > 0 && findPlayer3)
            {
                StartCoroutine(WaitToSpawn("player3"));
            }
            else if (playerValues.player4Lives > 0 && findPlayer4)
            {
                StartCoroutine(WaitToSpawn("player4"));

            }

        }

    }
    
}

