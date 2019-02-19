using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stones : MonoBehaviour
{
    public float health = 1f;
    public GameObject effect;

    public void Die()
    {
        Destroy(gameObject);
    }

    public void Damage(float amount)
    {
        health = health - amount;

        if (health <= 0f)
        {
            Die();
        }
    }
}
