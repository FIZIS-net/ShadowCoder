using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float directionChangeInterval = 3f;
    [SerializeField] private float detectionRange = 5f;
    [SerializeField] private Transform player;

    private Rigidbody2D rb;
    private float nextDirectionChangeTime = 0f;
    private bool isFacingRight = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Time.time >= nextDirectionChangeTime)
        {
            nextDirectionChangeTime = Time.time + directionChangeInterval;
            isFacingRight = !isFacingRight;
        }

        float distanceToPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceToPlayer < detectionRange)
        {
            Vector2 targetPos = new Vector2(player.position.x, player.position.y);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
