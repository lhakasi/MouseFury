using Abilities;
using HealthImpact;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Character : MonoBehaviour, IAttacker
{
    private AbilitiesContainer _abilitiesContainer;

    private Health _health;

    public bool IsAlive
    {
        get => _health.CurrentHealth > 0;
        private set { }
    }

    private List<Ability> Abilities => _abilitiesContainer.Abilities;

    public event Action Died;

    private void Awake()
    {
        _health = GetComponent<Health>();
        _abilitiesContainer = GetComponent<AbilitiesContainer>();
    }

    private void Update()
    {
        if (IsAlive != true)
            Die();
    }

    public void Attack(Character character, Ability combatAbility)
    {
        if (character == null)
            throw new ArgumentNullException(nameof(character));

        
        Ability ability = Abilities.FirstOrDefault(ability => ability == combatAbility);
        
        if (ability != null)
        {
            character.ChangeHealth(ImpactTypes.Damage, ability.Damage);
        }
        else
        {
            throw new InvalidOperationException($"Ability '{combatAbility}' not found in the list.");
        }
    }

    private void ChangeHealth(ImpactTypes impact, uint impactForce) => _health.ChangeHealth(impact, impactForce);

    private void Die() => Died?.Invoke();
}