using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBoss_Lvl_1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public static double hp = 100;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage_(double attack)
    {
        hp -= attack;
        if (hp <= 0)
        {
            GoldCount.gold += 2000;
            ScoreCount.scoreValue += 150;
            Destroy(gameObject);

        }
    }
}

