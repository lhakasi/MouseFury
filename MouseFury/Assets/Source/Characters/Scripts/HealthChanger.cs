using System;
using UnityEngine;
using HealthImpact;

[RequireComponent(typeof(Health))]
public class HealthChanger
{  
    private Health _health;

    public HealthChanger(Health health)
    {
        if (health == null)
            throw new NullReferenceException(nameof(health));

        _health = health;
    }

    private uint CurrentHealth => _health.CurrentHealth;

    public void ChangeHealth(ImpactTypes impactType, uint impactForce)
    {   
        switch (impactType)
        {
            case ImpactTypes.Healing:
                TakeHealing(CurrentHealth, impactForce);
                break;

            case ImpactTypes.Damage:
                TakeDamage(CurrentHealth, impactForce);
                break;
        }        
    }   

    private void TakeDamage(uint currentHealth, uint damage) =>    
        _health.SetCurrentHealth(currentHealth -= damage);
    
    private void TakeHealing(uint currentHealth, uint healing) =>    
        _health.SetCurrentHealth(currentHealth += healing);
}
