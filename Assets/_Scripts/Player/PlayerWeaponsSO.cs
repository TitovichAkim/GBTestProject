using UnityEngine;
[CreateAssetMenu(fileName = "Weapon", menuName = "ScrObj/Weapons")]

public class PlayerWeaponsSO : ScriptableObject
{
    public string       weaponName;
    public float        damage;
    public float        speed;
    public float        bulletSpeed;
    public GameObject[] weaponPrefabs;
    public GameObject   bulletPrefab;
    public Sprite       sprite;
}
