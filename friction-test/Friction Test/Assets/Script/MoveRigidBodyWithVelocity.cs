using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidBodyWithVelocity : MonoBehaviour
{
    Rigidbody2D rb;

    public float MoveSpeed = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    float horizontal;
    float vertical;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical) * MoveSpeed;
        rb.MoveRotation(Quaternion.identity);
    }
}
