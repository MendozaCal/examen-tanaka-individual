using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] protected int Health = 100;
    [SerializeField] protected int damage;
    private void Start()
    {
        Health = Mathf.Max(Health, 0);
        Health = Mathf.Min(Health, 100);
    }
    void Update()
    {
        Health = Mathf.Max(Health, 0);
        Health = Mathf.Min(Health, 100);
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
