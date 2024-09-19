using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField, Range(0, 20)] private float speed;
    private float horizontalDirection;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        Vector2 direction = rb2d.velocity;
        direction.x = horizontalDirection * speed;
        rb2d.velocity = direction;
    }

    public void SetHorizontalDirection(float x)
    {
        horizontalDirection = x;
    }
}
