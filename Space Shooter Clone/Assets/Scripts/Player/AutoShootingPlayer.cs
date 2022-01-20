using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShootingPlayer : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float _speed;
    [SerializeField] float rate;
    public bool isFire = false;
    Coroutine firecourin;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }
    void Fire()
    {
        if(isFire && firecourin == null)
        {
            firecourin = StartCoroutine(autoFire());
        }else if(!isFire && firecourin != null)
        {
            StopCoroutine(firecourin);
            firecourin = null;
        }
    }
    IEnumerator autoFire()
    {
        while (true)
        {
            GameObject instance = Instantiate(bullet, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity);
            
            if(rb != null)
            {
                instance.GetComponent<Bullet>().Initialize(PlayerShoot._attack, _speed);
            }
            yield return new WaitForSeconds(rate);
        }
    }
    public void Click_fire()
    {
        isFire = true;
        PlayerShoot.isFiring = false;
    }
    public void Stop_fire()
    {
        isFire = false;
        PlayerShoot.isFiring = true;
    }
}
