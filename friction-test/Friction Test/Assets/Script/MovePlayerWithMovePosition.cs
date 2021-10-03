using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerWithMovePosition : MonoBehaviour
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
        if (horizontal != 0 || vertical != 0)
            rb.MovePosition(rb.position + new Vector2(horizontal, vertical) * Time.fixedDeltaTime * MoveSpeed);
        rb.MoveRotation(Quaternion.identity);
    }
}
