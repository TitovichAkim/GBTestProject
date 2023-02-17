using UnityEngine;


public class StartGame : MonoBehaviour
{
    public PlayerWeaponsSO      firstWeapon;

    private void Start ()
    {
        StaticPlayerCharacters.playerWeapons[0] = firstWeapon;
    }
}
