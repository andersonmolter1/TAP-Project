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

    public CharacterSelection CharacterSelection;

    void Start()
    {
        //position of spawnpoint to teleport to.
        Vector2 spawnP1 = KnightSpawnPoint.transform.position;
        Vector2 spawnP2 = WizardSpawnPoint.transform.position;
        Vector2 spawnP3 = ArcherSpawnPoint.transform.position;
        Vector2 spawnP4 = VikingSpawnPoint.transform.position;

        /*
       //I have tried every way I know and that I could find to reference this bool variable. 
        if (CharacterSelection.getWizard())
        {
            Debug.Log("Teleport");
            Debug.Log(spawnP1);
            Knight.transform.position = spawnP1;
        }
        if (CharacterSelection.getWizard())
        {
            Wizard.transform.position = spawnP2;
        }
        if (CharacterSelection.getArcher())
        {
            Archer.transform.position = spawnP3;
        }
        if (CharacterSelection.getViking())
        {
            Viking.transform.position = spawnP4;
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
    }
}
