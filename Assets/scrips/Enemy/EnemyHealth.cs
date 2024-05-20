using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : health
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BulletWhite"))
        {
            Health -= damage;
        }
    }
}
