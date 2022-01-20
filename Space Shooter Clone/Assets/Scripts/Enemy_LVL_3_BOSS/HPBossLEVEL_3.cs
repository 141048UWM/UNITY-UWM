using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBossLEVEL_3 : MonoBehaviour
{
    [SerializeField] public static double hp = 300;
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
            GoldCount.gold += 6000;
            ScoreCount.scoreValue += 600;
            Destroy(gameObject);

        }
    }
}
