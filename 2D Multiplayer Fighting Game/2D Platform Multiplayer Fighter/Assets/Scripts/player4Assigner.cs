using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player4Assigner : MonoBehaviour
{
    public Button KnightButton;
    public Button ArcherButton;
    public Button WizardButton;
    public Button VikingButton;



    void Start()
    {

        KnightButton.onClick.AddListener(knight);
        ArcherButton.onClick.AddListener(archer);
        WizardButton.onClick.AddListener(wizard);
        VikingButton.onClick.AddListener(viking);

    }
    public void knight()
    {

        playerValues.P4knight = true;
        playerValues.P4archer = false;
        playerValues.P4viking = false;
        playerValues.P4wizard = false;
    }
    public void archer()
    {
        playerValues.P4knight = false;
        playerValues.P4archer = true;
        playerValues.P4viking = false;
        playerValues.P4wizard = false;
    }
    public void viking()
    {
        playerValues.P4knight = false;
        playerValues.P4archer = false;
        playerValues.P4viking = true;
        playerValues.P4wizard = false;
    }
    public void wizard()
    {
        playerValues.P4knight = false;
        playerValues.P4archer = false;
        playerValues.P4viking = false;
        playerValues.P4wizard = true;
    }
}