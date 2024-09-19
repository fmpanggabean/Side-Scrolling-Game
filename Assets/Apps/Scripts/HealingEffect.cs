using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingEffect : MonoBehaviour
{
    [SerializeField] private int healingFactor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player is not null)
        {
            player.GainHealth(healingFactor);
        }
    }
}
