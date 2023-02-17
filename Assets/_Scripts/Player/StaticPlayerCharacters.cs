using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticPlayerCharacters
{
    private static float            _experience«oints;
    private static int              _playerLevel;
    private static int              _skillPoints;
    private static int              _skillChassis;


    private static PlayerWeaponsSO[] _playerWeapons = new PlayerWeaponsSO[3];

    #region —¬Œ…—“¬¿
    public static float experiencePoints
    {
        get
        {
            return (_experience«oints);
        }
        set
        {
            _experience«oints = value;
        }
    }
    public static int playerLevel
    {
        get
        {
            return (_playerLevel);
        }
        set
        {
            _playerLevel = value;
        }
    }
    public static int skillPoints
    {
        get
        {
            return (_skillPoints);
        }
        set
        {
            _skillPoints = value;
        }
    }
    public static int skillChassis
    {
        get
        {
            return (_skillChassis);
        }
        set
        {
            _skillChassis = value;
        }
    }
    public static PlayerWeaponsSO[] playerWeapons
    {
        get
        {
            return (_playerWeapons);
        }
        set
        {
            _playerWeapons = value;
        }
    }
    #endregion
}


