using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject p1_spawn, p2_spawn, p3_spawn, p4_spawn;
    public PlayerCharacter Player1, Player2, Player3, Player4;

    void Start()
    {
        spawn();
    }

    public void spawn()
    {
        Player1.getCharacter().transform.position = p1_spawn.transform.position;
        Player2.getCharacter().transform.position = p2_spawn.transform.position;
        Player3.getCharacter().transform.position = p3_spawn.transform.position;
        Player4.getCharacter().transform.position = p4_spawn.transform.position;
    }

}
