using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player3Assigner : MonoBehaviour
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

        playerValues.P3knight = true;
        playerValues.P3archer = false;
        playerValues.P3viking = false;
        playerValues.P3wizard = false;
    }
    public void archer()
    {
        playerValues.P3knight = false;
        playerValues.P3archer = true;
        playerValues.P3viking = false;
        playerValues.P3wizard = false;
    }
    public void viking()
    {
        playerValues.P3knight = false;
        playerValues.P3archer = false;
        playerValues.P3viking = true;
        playerValues.P3wizard = false;
    }
    public void wizard()
    {
        playerValues.P3knight = false;
        playerValues.P3archer = false;
        playerValues.P3viking = false;
        playerValues.P3wizard = true;
    }
}
