using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyBoss : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    double attack_bullet;
    float speed_bullet;
    public void Initialize(double _attack_bullet, float _speed)
    {
        attack_bullet = _attack_bullet;
        speed_bullet = _speed;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-speed_bullet, 0f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            collision.gameObject.GetComponent<Player>().TakeDamage(attack_bullet);
        }
        Destroy(gameObject);
    }
}
