using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Info : MonoBehaviour
{
    private int _health;

    private void Start()
    {
        _health = 10;
    }

    public void Hurt(int damage)
    {
        _health -= damage;
        Debug.Log("Health : " + _health);
    }
}