using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public PlayerShooting           playerShooting;
    private PlayerMovement          _playerMovement;

    private void Awake ()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update ()
    {
        _playerMovement.direction = Input.GetAxis("Vertical");
        if (_playerMovement.direction >= 0)    // ���������� ����, ����� ����� ������� ���� ������� ���������
        {                                      // ������ � ���� �������� ��� � � ������ ���������� ����� � �������� ��������� )  
            _playerMovement.rotationDirection = -Input.GetAxis("Horizontal");
        } 
        else
        {
            _playerMovement.rotationDirection = Input.GetAxis("Horizontal");
        }
        if (Input.GetMouseButtonDown(0))
        {
            playerShooting.Shooting(true);
        }
        if(Input.GetMouseButtonUp(0))
        {

            playerShooting.Shooting(false);
        }
    }
}
