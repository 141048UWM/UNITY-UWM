using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_ENEMY_LVL_2 : MonoBehaviour
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
        if (hp <= 0)
        {
            GoldCount.gold += 300;
            ScoreCount.scoreValue += 30;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("bullet"))
        {
            Instantiate(blood, transform.position, Quaternion.identity);
        }
    }
}
