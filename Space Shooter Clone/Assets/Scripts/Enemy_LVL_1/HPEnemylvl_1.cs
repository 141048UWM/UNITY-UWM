using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPEnemylvl_1 : MonoBehaviour
{
    [SerializeField] public double hp;
    public GameObject blood;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(double attack)
    {
        hp -= attack;
        if(hp <= 0)
        {
            GoldCount.gold += 200;
            ScoreCount.scoreValue += 15;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("bullet")){
            Instantiate(blood, transform.position, Quaternion.identity);
        }
    }
}
