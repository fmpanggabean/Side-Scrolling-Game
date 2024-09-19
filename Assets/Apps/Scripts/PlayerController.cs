using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Player player = new Player();

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        player.SetHorizontalDirection(Input.GetAxisRaw("Horizontal"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump();
        }
    }
}
