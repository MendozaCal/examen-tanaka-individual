using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] protected float maxSpeed = 15;
    protected Transform Player;
    protected Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.FindWithTag("Player").transform;
        rb.constraints = RigidbodyConstraints.FreezeRotation;

    }
    void Update()
    {
        Move();
    }
    protected virtual void Move()
    {

    }
}
