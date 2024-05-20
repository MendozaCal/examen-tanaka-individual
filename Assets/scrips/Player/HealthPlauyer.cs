using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthPlauyer : health
{
    public int damageEnemyBullet1 = 10;
    public int damageEnemyBullet2 = 20;
    public int damageSuicideEnemy = 50;
    public int healthItem = 20;
    public GameObject HealthItem;

    void Update()
    {
        Health = Mathf.Max(Health, 0);
        Health = Mathf.Min(Health, 100);
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("damageSuicideEnemy"))
        {
            Health -= damageSuicideEnemy;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("damageEnemyBullet1"))
        {
            Health -= damageEnemyBullet1;
        }
        if (other.gameObject.CompareTag("damageEnemyBullet2"))
        {
            Health -= damageEnemyBullet2;
        }
    }
}
