using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform        playerTransform;

    private float           damping = 1.5f;
    private Camera          _mainCamera;


    private void Awake ()
    {
        _mainCamera = Camera.main;
    }

    private void Update ()
    {
        Vector3 target = playerTransform.position + (_mainCamera.ScreenToWorldPoint(Input.mousePosition) - playerTransform.position).normalized * 2;
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.x, target.y, -10), damping * Time.deltaTime);
    }

}
