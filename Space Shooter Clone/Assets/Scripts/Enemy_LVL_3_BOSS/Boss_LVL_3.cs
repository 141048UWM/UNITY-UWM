using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_LVL_3 : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    bool Spawn = false;
    private void Start()
    {

    }
    private void Update()
    {
        if (ScoreCount.scoreValue == 3692)
        {
            Spawn = true;
        }
        else
        {
            Spawn = false;
        }
        if (Spawn)
        {
            randX = Random.Range(5f, 5f);
            randY = Random.Range(-0.1f, -0.1f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            ScoreCount.scoreValue += 1;
        }
    }
}
