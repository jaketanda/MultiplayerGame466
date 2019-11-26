using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int playerHealth = 100;
    public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        playerHealth -= damage;

        if (playerHealth <= 0)
        {
            GetComponent<Player>().Die();
        }
    }

   
}
