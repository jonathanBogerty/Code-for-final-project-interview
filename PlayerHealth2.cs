using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth2 : MonoBehaviour
{
    public int maxHealth = 100;
    public int health2;

    private Vector2 initialPosition;

    void Start()
    {   
        health2 = maxHealth;
        initialPosition = transform.position;
    }

    public void TakeDamage(int damage)
    {
        health2 -= damage;
        if (health2 <= 0)
        {


        }
    }
}
