using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float jumpForce = 5f;
    public float jumpInterval = 2f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("Jump", jumpInterval, jumpInterval);
    }

    private void Jump()
    {
        if (Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("choque con el player");
    }
}
