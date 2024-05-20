using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlauyer : health
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health -= damage;
        }
    }
}