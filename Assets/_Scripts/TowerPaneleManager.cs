using UnityEngine;
using UnityEngine.UI;

public class TowerPaneleManager:MonoBehaviour
{
    public Button[]                 weaponsButtons = new Button[9];
    public PlayerWeaponsSO[]        weapon;

    private void Start ()
    {
        TesterWeaponButtons();
    }
    public void TesterWeaponButtons ()
    {
        foreach(Button but in weaponsButtons)
        {
            but.interactable = true;
        }

        for(int i = 0; i < StaticPlayerCharacters.playerWeapons.Length; i++)
        {
            if(StaticPlayerCharacters.playerWeapons[i] != null)
            {
                if(StaticPlayerCharacters.playerWeapons[i] == weapon[0])
                {
                    weaponsButtons[3 * i].interactable = false;
                }
                else
                {
                    weaponsButtons[2 + 3 * i].interactable = false;
                }
            }
            else
            {
                weaponsButtons[1 + 3 * i].interactable = false;
            }
        }
    }
}
