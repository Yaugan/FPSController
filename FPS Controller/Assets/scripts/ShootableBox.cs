using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableBox : MonoBehaviour
{
    public int currentHealth = 5;

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
