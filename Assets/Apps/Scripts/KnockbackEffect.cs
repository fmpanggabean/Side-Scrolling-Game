using UnityEngine;

internal class KnockbackEffect : MonoBehaviour
{
    private Vector2 knockbackVector;
    [SerializeField] private float knockbackPower;
    [SerializeField] private float effectDuration;

    private void Awake()
    {
        knockbackVector = new Vector2(1, 1);
    }

    public void Execute(Player player)
    {
        Vector2 knockbackDirection = knockbackVector * knockbackPower;
        knockbackDirection.x *= GetKnockbackDirection(player);
        StartCoroutine(player.ForcedMove(knockbackDirection, effectDuration));
        Debug.Log(knockbackDirection);
    }

    private int GetKnockbackDirection(Player player)
    {
        if (player.GetPosition().x > transform.position.x) return 1;
        else return -1;
    }
}