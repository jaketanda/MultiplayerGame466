﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerInfo player = collision.GetComponent<PlayerInfo>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }

        //Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);


    }
}
