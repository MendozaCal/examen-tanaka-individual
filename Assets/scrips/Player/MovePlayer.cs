using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MoveController
{
    [SerializeField] protected float rotationSpeed;
    [SerializeField] float velocityUp = 5;
    protected override void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * maxSpeed * Time.deltaTime;
        //Quaternion rotation = Quaternion.Euler(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
        Vector3 movimiento = new Vector3(0, velocityUp * Time.deltaTime, 0);

        rb.MovePosition(transform.position + transform.TransformDirection(movement));
        //rb.MoveRotation(rb.rotation * rotation);
        rb.MovePosition(rb.position + movimiento);
    }
}
