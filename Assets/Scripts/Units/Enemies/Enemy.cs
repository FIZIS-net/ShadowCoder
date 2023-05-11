using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 2f; // Скорость передвижения врага
    [SerializeField] private float health = 100f; // Количество здоровья врага

    private Rigidbody2D rb; // Ссылка на Rigidbody2D компонент врага

    private void Awake()
    {
        // Получаем ссылку на Rigidbody2D компонент врага
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Двигаем врага влево со скоростью speed
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }

    public void TakeDamage(float damageAmount)
    {
        // Отнимаем здоровье врага
        health -= damageAmount;

        // Если здоровье врага меньше или равно нулю, уничтожаем его
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
