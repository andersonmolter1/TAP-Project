using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class playerVictory : MonoBehaviour
{
    public int victoryCount;
    public TMP_Text whoWins;
    string winner;

    private void Start()
    {
        whoWins.text = "";
        whoWins.fontSize = 28;
        CountPlayers();
    }

    private void Update()
    {
        if (playerValues.player1Lives == 0 && !playerValues.player1isDead)
        {
            victoryCount++;
            playerValues.player1isDead = true;
        }
        if (playerValues.player2Lives == 0 && !playerValues.player2isDead)
        {
            victoryCount++;
            playerValues.player2isDead = true;
        }
        if (playerValues.player3Lives == 0 && !playerValues.player3isDead)
        {
            victoryCount++;
            playerValues.player3isDead = true;
        }
        if (playerValues.player4Lives == 0 && !playerValues.player4isDead)
        {
            victoryCount++;
            playerValues.player4isDead = true;
        }
        if (victoryCount == 3)
        {
            FindWinner();
            StartCoroutine(endGame());
        }

    }

    void FindWinner()
    {
       
            if (!playerValues.player1isDead)
            {
                winner = "Player 1";
            }
            else if (!playerValues.player2isDead)
            {
                winner = "Player 2";
            }
            else if (!playerValues.player3isDead)
            {
                winner = "Player 3";
            }
            else 
            {
                winner = "Player 4";
            }
            SetWhoWins(winner);
        
    }

    void SetWhoWins(string player)
    {
        whoWins.text = "Congratulations " + player + ". You win!";
    }

    void CountPlayers()
    {
        if (!(playerValues.P1archer || playerValues.P1knight
            || playerValues.P1viking || playerValues.P1wizard))
        {
            victoryCount++;
        }
        if (!(playerValues.P2archer || playerValues.P2knight
            || playerValues.P2viking || playerValues.P2wizard))
        {
            victoryCount++;
        }
        if (!(playerValues.P3archer || playerValues.P3knight
            || playerValues.P3viking || playerValues.P3wizard))
        {
            victoryCount++;
        }
        if (!(playerValues.P4archer || playerValues.P4knight
            || playerValues.P4viking || playerValues.P4wizard))
        {
            victoryCount++;
        }
    }

    
    IEnumerator endGame()
    {
        Time.timeScale = 0.1f;
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
        SceneManager.UnloadSceneAsync("Castle");

    }

    
}
