using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePlayerTag : MonoBehaviour
{
    public string player;
    public SpriteRenderer player1tag;
    public SpriteRenderer player2tag;
    public SpriteRenderer player3tag;
    public SpriteRenderer player4tag;

    // Start is called before the first frame update
    void Start()
    {
        Activate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        if (player.Equals("player1"))
        {
            player1tag.enabled = true;
        }
        else if (player.Equals("player2"))
        {
            player2tag.enabled = true;
        }
        else if (player.Equals("player3"))
        {
            player3tag.enabled = true;
        }
        else if (player.Equals("player4"))
        {
            player4tag.enabled = true;
        }
        
    }
}
