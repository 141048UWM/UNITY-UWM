using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
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
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed_bullet, 0f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HPEnemylvl_1>())
        {
            collision.gameObject.GetComponent<HPEnemylvl_1>().TakeDamage(attack_bullet);
        }
        if (collision.gameObject.GetComponent<HPBoss_Lvl_1>())
        {
            collision.gameObject.GetComponent<HPBoss_Lvl_1>().TakeDamage_(attack_bullet);
        }
        if (collision.gameObject.GetComponent<HP_ENEMY_LVL_2>())
        {
            collision.gameObject.GetComponent<HP_ENEMY_LVL_2>().TakeDamage(attack_bullet);
        }
        if (collision.gameObject.GetComponent<HPENEMY_LVL3>())
        {
            collision.gameObject.GetComponent<HPENEMY_LVL3>().TakeDamage(attack_bullet);
        }
        if (collision.gameObject.GetComponent<HP_BOSS_LVL2>())
        {
            collision.gameObject.GetComponent<HP_BOSS_LVL2>().TakeDamage_(attack_bullet);
        }
        if (collision.gameObject.GetComponent<HPBossLEVEL_3>())
        {
            collision.gameObject.GetComponent<HPBossLEVEL_3>().TakeDamage_(attack_bullet);
        }
        Destroy(gameObject);
    }

}
