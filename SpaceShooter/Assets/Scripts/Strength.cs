using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : MonoBehaviour
{
    public float health = 25f;

    public void Damage(float value)
    {
        health -= value;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
