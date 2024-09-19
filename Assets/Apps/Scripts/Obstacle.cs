using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private KnockbackEffect knockback;

    private void Awake()
    {
        knockback = GetComponent<KnockbackEffect>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player is not null)
        {
            knockback.Execute(player);
        }
    }
}
