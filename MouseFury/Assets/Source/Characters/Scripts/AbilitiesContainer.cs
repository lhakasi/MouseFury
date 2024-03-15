using Abilities;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesContainer : MonoBehaviour
{
    [SerializeField] private List<AbilityConfig> _abilityConfigs;

    public readonly List<Ability> Abilities = new List<Ability>();

    private void OnValidate()
    {
        for (int i = 0; i < _abilityConfigs.Count; i++)
        {
            Abilities.Add(new Ability(_abilityConfigs[i]));
        }

        for (int i = 0; i < Abilities.Count; i++)
        {
            Debug.Log(_abilityConfigs[i].Type + " " + _abilityConfigs[i].Damage);
        }
    }
}