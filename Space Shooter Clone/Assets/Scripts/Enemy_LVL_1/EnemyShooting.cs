using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bullet;
    [SerializeField] float speed_bullet;
    [SerializeField] double _attack = 0.2;
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale == 1f) { InvokeRepeating("Shoot", 2, 4); }
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Shoot()
    {
        GameObject bullet_ = Instantiate(bullet, new Vector3(transform.position.x - 1, transform.position.y, 0), Quaternion.identity);
        bullet_.GetComponent<BulletEnemy>().Initialize(_attack, speed_bullet);
    }
}
