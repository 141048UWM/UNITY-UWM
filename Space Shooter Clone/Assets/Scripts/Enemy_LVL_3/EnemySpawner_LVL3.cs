using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner_LVL3 : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    int enemyCount;
    public int enemyWave;
    private void Start()
    {

    }
    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-2f, 8f);
            randY = Random.Range(1.9f, -4f);
            whereToSpawn = new Vector2(randX, randY);
            if (enemyCount < enemyWave)
            {
                enemyCount++;
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }
        }
    }
}
