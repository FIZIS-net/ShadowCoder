using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float health = 100f;
    public bool isEnemy = true;

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        ShotScript shot = other.GetComponent<ShotScript>();
        if (shot != null)
        {
            if(shot.isEnemyShot != isEnemy)
            {
                TakeDamage(shot.damage);

                Destroy(shot.gameObject);
            }
        }
    }
}
