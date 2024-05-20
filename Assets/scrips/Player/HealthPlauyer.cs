using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthPlauyer : health
{
    public int damage;
    
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
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health -= damage;
        }
    }
}
