using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField, Range(10,100)] private float gravity;

    private void FixedUpdate()
    {
        Physics2D.gravity = new Vector2(0, -gravity);
    }
}
