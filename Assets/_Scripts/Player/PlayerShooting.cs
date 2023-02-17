using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting:MonoBehaviour
{
    public WeaponShooting[]         weaponShooting;

    public void Shooting (bool condition)
    {
        for(int i = 0; i < weaponShooting.Length; i++)
        {
            if(weaponShooting[i] != null)
            {
                weaponShooting[i].CoroutineManager(condition);
            }
        }
    }
}
