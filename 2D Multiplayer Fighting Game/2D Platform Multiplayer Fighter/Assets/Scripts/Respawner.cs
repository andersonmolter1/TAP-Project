﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{

    private Component player1, player2, player3, player4;
    //private bool isReadySpawn = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player1"))
        {
            StartCoroutine(WaitToSpawn("player1"));
            //isReadySpawn = false;
        }
        else if (collision.gameObject.CompareTag("player2"))
        {
            StartCoroutine(WaitToSpawn("player2"));
            //isReadySpawn = false;
        }
        else if (collision.gameObject.CompareTag("player3"))
        {
            StartCoroutine(WaitToSpawn("player3"));
            // isReadySpawn = false;
        }
        else if (collision.gameObject.CompareTag("player4"))
        {
            StartCoroutine(WaitToSpawn("player4"));
            // isReadySpawn = false;

        }
    }

    public IEnumerator WaitToSpawn(string player)
    {
        yield return new WaitForSeconds(0.8f);
        if (player.Equals("player1"))
        {
            GetComponent<player1Spawner>().findPlayer1();
        }
        else if (player.Equals("player2"))
        {
            GetComponent<player2Spawner>().findPlayer2();
        }
        else if (player.Equals("player3"))
        {
            GetComponent<player3Spawner>().findPlayer3();
        }
        else if (player.Equals("player4"))
        {
            GetComponent<player4Spawner>().findPlayer4();
        }
    }
    /*
    private void Update()
    {
        if (playerValues.player1Lives > 0 && !(GameObject.FindGameObjectWithTag("player1")))
        {
            WaitToSpawn("player1");
        }
        else if (playerValues.player2Lives > 0 && !(GameObject.FindGameObjectWithTag("player2")))
        {
            WaitToSpawn("player2");
        }
        else if (playerValues.player1Lives > 0 && !(GameObject.FindGameObjectWithTag("player3")))
        {
            WaitToSpawn("player3");
        }
        else if (playerValues.player1Lives > 0 && !(GameObject.FindGameObjectWithTag("player4")))
        {
            WaitToSpawn("player4");
        }
    }
    */
}

