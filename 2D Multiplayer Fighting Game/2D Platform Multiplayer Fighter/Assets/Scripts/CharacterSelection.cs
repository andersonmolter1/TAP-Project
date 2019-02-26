using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{

    public Button KnightButton;
    public Button ArcherButton;
    public Button WizardButton;
    public Button VikingButton;
    public bool Knight = true;
    public bool Archer = true;
    public bool Wizard = true;
    public bool Viking = true;
    // Start is called before the first frame update
    public void Update()
    {
        KnightButton.onClick.AddListener(KnightSelection);
        ArcherButton.onClick.AddListener(ArcherSelection);
        WizardButton.onClick.AddListener(WizardSelection);
        VikingButton.onClick.AddListener(VikingSelection);
    }

    public void KnightSelection()
    {
        Knight = true;
    }
    public void WizardSelection()
    {
        Wizard = true;
    }
    public void ArcherSelection()
    {
        Archer = true;
    }
    public void VikingSelection()
    {
        Viking = true;
    }
    
    

    public bool getKnight()
    {
        return Knight;
    }
    public bool getWizard()
    {
        return Wizard;
    }
    public bool getViking()
    {
        return Viking;
    }
    public bool getArcher()
    {
        return Archer;
    }
}
