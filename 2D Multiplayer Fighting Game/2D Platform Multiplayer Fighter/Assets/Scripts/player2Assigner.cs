using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2Assigner : MonoBehaviour
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

        playerValues.P2knight = true;
        playerValues.P2archer = false;
        playerValues.P2viking = false;
        playerValues.P2wizard = false;
    }
    public void archer()
    {
        playerValues.P2knight = false;
        playerValues.P2archer = true;
        playerValues.P2viking = false;
        playerValues.P2wizard = false;
    }
    public void viking()
    {
        playerValues.P2knight = false;
        playerValues.P2archer = false;
        playerValues.P2viking = true;
        playerValues.P2wizard = false;
    }
    public void wizard()
    {
        playerValues.P2knight = false;
        playerValues.P2archer = false;
        playerValues.P2viking = false;
        playerValues.P2wizard = true;
    }
}