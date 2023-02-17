using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShooting:MonoBehaviour
{
    public PlayerWeaponsSO      weaponSO;

    private Transform           _startBulletTransform;
    private Camera              _mainCamera;
    private Coroutine           _coroutine;

    private void Awake ()
    {
        _mainCamera = Camera.main;
        _startBulletTransform = GetComponent<WeaponStartPoint>().startBulletPoint;
    }
    public void Shot ()
    {
        GameObject bulletGO = Instantiate(weaponSO.bulletPrefab);
        bulletGO.transform.position = _startBulletTransform.position;
        Bullet bulletScr = bulletGO.GetComponent<Bullet>();
        bulletScr.speed = weaponSO.bulletSpeed;
        bulletScr.damage = weaponSO.damage;
        bulletScr.target = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    public void CoroutineManager (bool condition)
    {
        if (condition)
        {
            _coroutine = StartCoroutine(ShotTimer());
        }
        else
        {
            StopCoroutine(_coroutine);
        }
    }
    public IEnumerator ShotTimer ()
    {
        while (true)
        {
            Shot();
            yield return new WaitForSeconds(weaponSO.speed);
        }
    }
}
