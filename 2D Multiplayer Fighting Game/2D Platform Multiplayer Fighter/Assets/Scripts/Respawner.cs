using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    private int num;
    private bool isReadySpawn = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player1"))
        {
            num++;
            GetComponent<player1Spawner>().findPlayer1();
            isReadySpawn = false;
        }
        else if (collision.gameObject.CompareTag("player2"))
        {
            num++;
            GetComponent<player2Spawner>().findPlayer2();
            isReadySpawn = false;
        }
        else if (collision.gameObject.CompareTag("player3"))
        {
            num++;
            GetComponent<player3Spawner>().findPlayer3();
            isReadySpawn = false;
        }
        else if (collision.gameObject.CompareTag("player4"))
        {
            num++;
            GetComponent<player4Spawner>().findPlayer4();
            isReadySpawn = false;
        }
        Debug.Log(num);
        StartCoroutine(WaitForSpawn());
    }
    private IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(1f);
        isReadySpawn = true;
    }
}
