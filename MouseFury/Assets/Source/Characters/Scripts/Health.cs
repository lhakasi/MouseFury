using UnityEngine;
using HealthImpact;
using System;

public class Health : MonoBehaviour
{
    [field: SerializeField] public uint MaxHealth { get; private set; }    
    public uint CurrentHealth { get; private set; }

    public HealthChanger HealthChanger {  get; private set; }

    public event Action Changed;

    private void Awake()
    {
        CurrentHealth = MaxHealth;

        HealthChanger = new HealthChanger(this);
    }

    public void SetMaxHealth(uint health) => MaxHealth = health;

    public void SetCurrentHealth(uint health) => CurrentHealth = health;

    public void ChangeHealth(ImpactTypes impact, uint impactForce)
    {
        HealthChanger.ChangeHealth(impact,impactForce);

        Changed?.Invoke();
    }
}