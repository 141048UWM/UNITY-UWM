using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_BOSS_LVL2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public static double hp = 200;
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
            GoldCount.gold += 4000;
            ScoreCount.scoreValue += 300;
            Destroy(gameObject);

        }
    }
}
