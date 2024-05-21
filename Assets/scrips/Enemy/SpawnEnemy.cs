using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] Enemys;
    public Transform spawnPoint;
    Transform Player;
    public float spawnDelay = 2;
    public float timer = 0;
    public float timer2 = 0;
    
    private void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (Player!=null && timer>=spawnDelay)
        {
           spawing();
           timer = 0;
        }
    }
    void spawing()
    { 
        if(timer2 <= 10)
        {
            Instantiate(Enemys[0]);
        }
        else if(timer2 > 10 && timer2 <= 20)
        {
            Instantiate(Enemys[1]);
        }
        else if(timer2 >20 && timer2 <= 30)
        {
            Instantiate(Enemys[0]);
            Instantiate(Enemys[1]);
        }
        else
        {
            timer2 = 0;
        }
    }
}
