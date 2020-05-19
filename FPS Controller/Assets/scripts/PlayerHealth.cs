using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int _health;

    // Start is called before the first frame update
    void Start()
    {
        _health = 10;
    }

    public void Damage(int damage)
    {
        _health -= damage;

    }

    
}
