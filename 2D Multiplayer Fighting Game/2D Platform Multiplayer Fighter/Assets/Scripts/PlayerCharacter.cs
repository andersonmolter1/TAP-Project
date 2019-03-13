using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour

{
    public string playerName;
    public GameObject character;
    public Transform spawnPoint;

    private PlayerCharacter()
    {

    }

    private PlayerCharacter(string player, GameObject character)
    {

    }

    public string getPlayer()
    {
        return this.playerName;
    }

    public void setCharacter(GameObject character)
    {
        this.character = character;
    }

    public GameObject getCharacter()
    {
        return this.character;
    }

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        if (this.character!=null)
        {
            if (lookForSpawn())
            {
                Instantiate(this.character, spawnPoint, true);
                this.character = null;
            }
        }
    }

    private bool lookForSpawn()
    {
        if (GameObject.FindGameObjectWithTag(playerName + "_spawn"))
        {
            GameObject mapSpawn = GameObject.FindGameObjectWithTag(playerName + "_spawn");
            spawnPoint.transform.position = mapSpawn.transform.position;
            return true;
        }

        return false;
    }


}
