using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePlayers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        playerValues.player1isDead = false;
        playerValues.player2isDead = false;
        playerValues.player3isDead = false;
        playerValues.player4isDead = false;

        playerValues.P1archer = false;
        playerValues.P1knight = false;
        playerValues.P1viking = false;
        playerValues.P1wizard = false;

        playerValues.P2archer = false;
        playerValues.P2knight = false;
        playerValues.P2viking = false;
        playerValues.P2wizard = false;

        playerValues.P3archer = false;
        playerValues.P3knight = false;
        playerValues.P3viking = false;
        playerValues.P3wizard = false;

        playerValues.P4archer = false;
        playerValues.P4knight = false;
        playerValues.P4viking = false;
        playerValues.P4wizard = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
