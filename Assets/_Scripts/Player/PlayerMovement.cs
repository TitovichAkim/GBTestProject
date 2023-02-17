using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform        towerTransform;

    private float           _speed = 1;
    private float           _rotationSpeed = 50;

    private float           _direction;
    private float           _rotationDirection;

    private Rigidbody2D     _playerRigidbody;

    private Camera          _mainCamera;
    private void Awake ()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _mainCamera = Camera.main;
    }

    private void FixedUpdate ()
    {
        _playerRigidbody.velocity = transform.up * _speed * _direction;
        _playerRigidbody.rotation += Time.deltaTime * _rotationSpeed * _rotationDirection;
    }
    private void Update ()
    {
        Vector3 perpendicular = Vector3.Cross(transform.position-_mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);
        towerTransform.rotation = Quaternion.LookRotation(Vector3.forward, perpendicular);
    }
    #region Доступ к приватным переменным
    public float speed
    {
        get
        {
            return(_speed);
        }
        set
        {
            _speed = value;
        }
    }
    public float rotationSpeed
    {
        get
        {
            return (_rotationSpeed);
        }
        set
        {
            _rotationSpeed = value;
        }
    }
    public float direction
    {
        get
        {
            return (_direction);
        }
        set
        {
            _direction = value;
        }
    }
    public float rotationDirection
    {
        get
        {
            return (_rotationDirection);
        }
        set
        {
            _rotationDirection = value;
        }
    }
    #endregion
}
