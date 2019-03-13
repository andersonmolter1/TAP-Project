using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPlayer : MonoBehaviour
{
    public Button KnightButton;
    public Button ArcherButton;
    public Button WizardButton;
    public Button VikingButton;
    public static bool spawnKnight = false;
    public static bool spawnArcher = false;
    public static bool spawnWizard = false;
    public static bool spawnViking = false;

    public GameObject Knight;
    public GameObject Viking;
    public GameObject Wizard;
    public GameObject Archer;
    public GameObject KnightSpawnPoint;
    public GameObject WizardSpawnPoint;
    public GameObject ArcherSpawnPoint;
    public GameObject VikingSpawnPoint;

    public void Update()
    {
        KnightButton.onClick.AddListener(KnightSelection);
        ArcherButton.onClick.AddListener(ArcherSelection);
        WizardButton.onClick.AddListener(WizardSelection);
        VikingButton.onClick.AddListener(VikingSelection);
    }

    public void KnightSelection()
    {
        spawnKnight = true;
    }
    public void WizardSelection()
    {
        spawnWizard = true;
    }
    public void ArcherSelection()
    {
        spawnArcher = true;
    }
    public void VikingSelection()
    {
        spawnViking = true;
    }

    void Start()
    {

        //position of spawnpoint to teleport to.
        Vector2 spawnP1 = KnightSpawnPoint.transform.position;
        Vector2 spawnP2 = WizardSpawnPoint.transform.position;
        Vector2 spawnP3 = ArcherSpawnPoint.transform.position;
        Vector2 spawnP4 = VikingSpawnPoint.transform.position;


        if (spawnKnight)
        {
            Knight.transform.position = spawnP1;
        }
        if (spawnWizard)
        {
            Wizard.transform.position = spawnP2;
        }
        if (spawnArcher)
        {
            Archer.transform.position = spawnP3;
        }
        if (spawnViking)
        {
            Viking.transform.position = spawnP4;
        }


    }

    
}
