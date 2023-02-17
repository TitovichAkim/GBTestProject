using UnityEngine;

public class PlayerFactory:MonoBehaviour
{
    private GameObject          _player;
    private GameObject          _playerTower;

    private PlayerDesign        _playerDesign;
    private PlayerShooting      _playerShooting;

    private void Start ()
    {
        _player = GameObject.Find("Player");
        _playerDesign = _player.GetComponent<PlayerDesign>();
        _playerTower = _playerDesign.tower;
        _playerShooting = _playerTower.GetComponent<PlayerShooting>();
        InstallModules();
    }
    private void InstallModules ()
    {
        for(int i = 0; i < StaticPlayerCharacters.playerWeapons.Length; i++ )
        {
            if (StaticPlayerCharacters.playerWeapons[i] != null)
            {
                GameObject weapon = Instantiate(StaticPlayerCharacters.playerWeapons[i].weaponPrefabs[i], _playerTower.transform);
                _playerShooting.weaponShooting[i] = weapon.GetComponent<WeaponShooting>();
                _playerDesign.weapons[i] = weapon;
            }
        }
    }
}
