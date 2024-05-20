using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] Enemys;
    public Transform spawnPoint;
    Transform Player;
    public float spawnDelay = 0;
    public float timer = 0;
    private void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        spawnDelay += Time.deltaTime;
        timer += Time.deltaTime;
        if (Player != null && spawnDelay >= 1)
        {
            if (timer / 2 == 0)
            {
                Instantiate(Enemys[0]);
                spawnDelay = 0;
            }
            else if (timer / 2 == 1)
            {
                Instantiate(Enemys[1]);
                spawnDelay = 0;
            }
            else if (timer >= 20)
            {
                Instantiate(Enemys[1]);
                Instantiate(Enemys[0]);
                timer = 0;
            }
        }
    }
}
