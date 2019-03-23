using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player5Assigner : MonoBehaviour
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

        playerValues.P5knight = true;
        playerValues.P5archer = false;
        playerValues.P5viking = false;
        playerValues.P5wizard = false;
    }
    public void archer()
    {
        playerValues.P5knight = false;
        playerValues.P5archer = true;
        playerValues.P5viking = false;
        playerValues.P5wizard = false;
    }
    public void viking()
    {
        playerValues.P5knight = false;
        playerValues.P5archer = false;
        playerValues.P5viking = true;
        playerValues.P5wizard = false;
    }
    public void wizard()
    {
        playerValues.P5knight = false;
        playerValues.P5archer = false;
        playerValues.P5viking = false;
        playerValues.P5wizard = true;
    }
}