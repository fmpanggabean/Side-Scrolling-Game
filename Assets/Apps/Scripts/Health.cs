using System;
using UnityEngine;

[Serializable]
internal class Health
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;

    public Health(int maxHealth)
    {
        this.maxHealth = maxHealth;
    }
    public void Reduce(int value)
    {
        currentHealth -= value;

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }
    public void Gain(int value)
    {
        currentHealth += value;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}