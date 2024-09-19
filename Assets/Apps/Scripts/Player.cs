using System;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField, Range(0, 20)] private float speed;
    [SerializeField, Range(5, 20)] private float jumpPower;
    [SerializeField] private bool isControllable;
    private float horizontalDirection;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;

        isControllable = true;
    }

    private void Update()
    {
        if (isControllable) UpdatePosition();
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

    internal void Jump()
    {
        Vector2 direction = rb2d.velocity;
        direction.y = jumpPower;
        rb2d.velocity = direction;
    }

    internal Vector3 GetPosition()
    {
        return transform.position;
    }

    internal IEnumerator ForcedMove(Vector2 knockbackDirection, float duration)
    {
        isControllable = false;
        rb2d.velocity = knockbackDirection;
        yield return new WaitForSeconds(duration);
        isControllable = true;
    }
}
