using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1Assigner : MonoBehaviour
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
        
        playerValues.P1knight = true;
        playerValues.P1archer = false;
        playerValues.P1viking = false;
        playerValues.P1wizard = false;
    }
    public void archer()
    {
        playerValues.P1knight = false;
        playerValues.P1archer = true;
        playerValues.P1viking = false;
        playerValues.P1wizard = false;
    }
    public void viking()
    {
        playerValues.P1knight = false;
        playerValues.P1archer = false;
        playerValues.P1viking = true;
        playerValues.P1wizard = false;
    }
    public void wizard()
    {
        playerValues.P1knight = false;
        playerValues.P1archer = false;
        playerValues.P1viking = false;
        playerValues.P1wizard = true;
    }
}
