using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] Enemys;
    public Transform spawnPoint;
    public float spawnDelay = 0;
    public Transform Player;

    void Update()
    {
        spawnDelay += Time.deltaTime;
        if (Player != null && spawnDelay >= 1)
        {
            spawnEnemy();
            spawnDelay = 0;
        }
    }
    void spawnEnemy()
    {
        int randomIndex = Random.Range(0, Enemys.Length);
        GameObject enemyToSpawn = Enemys[randomIndex];
        Instantiate(enemyToSpawn);
    }
}
