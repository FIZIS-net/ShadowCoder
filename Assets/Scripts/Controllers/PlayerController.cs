using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;   // Скорость перемещения персонажа
    public float jumpForce = 10f;  // Сила прыжка персонажа
    public LayerMask groundLayers; // Слои объектов, считающихся землей для персонажа

    private Rigidbody2D rb;               // Rigidbody2D компонент персонажа
    private Animator animator;            // Animator компонент персонажа
    // private bool isFacingRight = true;   // Флаг направления персонажа

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        rb.velocity = movement;        

        // if (horizontalInput > 0 && !isFacingRight)
        // {
        //     Flip();
        // }
        // else if (horizontalInput < 0 && isFacingRight)
        // {
        //     Flip();
        // }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        // animator.SetFloat("Speed", Mathf.Abs(horizontalInput));
        // animator.SetBool("IsGrounded", IsGrounded());
    }

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1f, groundLayers);
        return hit.collider != null;
    }

    private bool isTouchingWall()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, 1f, groundLayers);
        return hit.collider != null;
    }

    // private void Flip()
    // {
    //     isFacingRight = !isFacingRight;
    //     transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    // }
}