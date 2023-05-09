using UnityEngine;

public class ShotScript : MonoBehaviour
{
    public float damage = 1f;

    public bool isEnemyShot = false;
    void Update()
    {
        Destroy(gameObject, 20);
    }
}
