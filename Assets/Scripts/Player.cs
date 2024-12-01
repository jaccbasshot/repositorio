using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    private Rigidbody2D rb;

    public bool isGrounded = true;

    public LayerMask groundLayer;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;

    public Animator animator;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        if(isGrounded)
        {
           animator.SetBool("IsGrounded", true);
        }
        else
        {
            animator.SetBool("IsGrounded", false);
        }
            
     
    }

    void Update()
    {
        // Si presionamos la barra espaciadora y estamos en el suelo, saltamos
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    public void SonidoPasos()
    {
        audioSource.Play();
    }

    void Jump()
    {
        // Añadimos una fuerza hacia arriba para hacer que el personaje salte
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        animator.SetBool("IsGrounded", false);
    }
}
