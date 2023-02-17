using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float        damage;
    public float        speed;
    public Vector3      target;

    private Rigidbody2D _bulletRigidbody;
    private float       _createTime;

    private void Awake ()
    {
        _bulletRigidbody = GetComponent<Rigidbody2D>();
        _createTime = Time.time;
    }
    private void FixedUpdate ()
    {
        _bulletRigidbody.velocity = (target - transform.position).normalized * speed;

        if ( Vector3.Distance(transform.position, target) <= 1.02f || (Time.time - _createTime) > 2f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Вот сюда добавлять урон этому уроду!!!
            Debug.Log(collision.gameObject.name);
            Destroy(this.gameObject);
        }
    }

}
