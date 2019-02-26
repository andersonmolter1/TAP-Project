using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterTeleport : MonoBehaviour
{
    public GameObject Knight;
    public GameObject Viking;
    public GameObject Wizard;
    public GameObject Archer;
    public GameObject KnightSpawnPoint;
    public GameObject WizardSpawnPoint;
    public GameObject ArcherSpawnPoint;
    public GameObject VikingSpawnPoint;

    CharacterSelection cs = new CharacterSelection();

    void Start()
    {
        //position of spawnpoint to teleport to.
        Vector2 spawnP1 = KnightSpawnPoint.transform.position;
        Vector2 spawnP2 = WizardSpawnPoint.transform.position;
        Vector2 spawnP3 = ArcherSpawnPoint.transform.position;
        Vector2 spawnP4 = VikingSpawnPoint.transform.position;


        
        if (cs.getKnight())
        {
            Knight.transform.position = spawnP1;
        }
        if (cs.getWizard())
        {
            Wizard.transform.position = spawnP2;
        }
        if (cs.getArcher())
        {
            Archer.transform.position = spawnP3;
        }
        if (cs.getViking())
        {
            Viking.transform.position = spawnP4;
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

}

