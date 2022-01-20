using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float speed_bullet;
    [SerializeField] public static double _attack = 1;
    AutoShootingPlayer shooter;
    public static bool isFiring = true;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        shooter = GetComponent<AutoShootingPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isFiring)
        {
            if(Time.timeScale == 1f) { 
                Shoot();
            } 
        }
    }
    public void Shoot()
    {
        GameObject bullet_ = Instantiate(bullet, new Vector3(transform.position.x+1, transform.position.y,0), Quaternion.identity);
        bullet_.GetComponent<Bullet>().Initialize(_attack, speed_bullet);
    }
}
