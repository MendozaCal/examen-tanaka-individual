using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBlack : health
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BulletBlack"))
        {
            Health -= damage;
        }
    }
}
