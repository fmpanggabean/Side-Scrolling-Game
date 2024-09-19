using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissappearOnCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player is not null)
        {
            Destroy(gameObject);
        }
    }
}
