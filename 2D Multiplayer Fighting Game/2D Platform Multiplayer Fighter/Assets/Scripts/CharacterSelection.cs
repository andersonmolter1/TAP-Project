using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public string player;
    public GameObject wizardMarker, 
                      archerMarker, 
                      knightMarker, 
                      vikingMarker;
    public GameObject[] charMarkers = new GameObject[4];
    // Start is called before the first frame update
    void Start()
    {
        charMarkers[0] = wizardMarker;
        charMarkers[1] = archerMarker;
        charMarkers[2] = knightMarker;
        charMarkers[3] = vikingMarker;
    }

    // Update is called once per frame
    void Update()
    {
        disableMarkers();
        if (player.Equals("player1"))
        {
            if (playerValues.P1wizard)
            {
                wizardMarker.SetActive(true);
            }
            else if (playerValues.P1archer)
            {
                archerMarker.SetActive(true);
            }
            else if (playerValues.P1knight)
            {
                knightMarker.SetActive(true);
            }
            else if (playerValues.P1viking)
            {
                vikingMarker.SetActive(true);
            }
        }
        else if (player.Equals("player2"))
        {
            if (playerValues.P2wizard)
            {
                wizardMarker.SetActive(true);
            }
            else if (playerValues.P2archer)
            {
                archerMarker.SetActive(true);
            }
            else if (playerValues.P2knight)
            {
                knightMarker.SetActive(true);
            }
            else if (playerValues.P2viking)
            {
                vikingMarker.SetActive(true);
            }
        }
        else if (player.Equals("player3"))
        {
            if (playerValues.P3wizard)
            {
                wizardMarker.SetActive(true);
            }
            else if (playerValues.P3archer)
            {
                archerMarker.SetActive(true);
            }
            else if (playerValues.P3knight)
            {
                knightMarker.SetActive(true);
            }
            else if (playerValues.P3viking)
            {
                vikingMarker.SetActive(true);
            }
        }
        else if (player.Equals("player4"))
        {
            if (playerValues.P4wizard)
            {
                wizardMarker.SetActive(true);
            }
            else if (playerValues.P4archer)
            {
                archerMarker.SetActive(true);
            }
            else if (playerValues.P4knight)
            {
                knightMarker.SetActive(true);
            }
            else if (playerValues.P4viking)
            {
                vikingMarker.SetActive(true);
            }
        }
    }

    void disableMarkers()
    {
        for (int i = 0; i < 4; i++)
        {
            charMarkers[i].SetActive(false);
        }
    }
}
