using Abilities;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new Ability Config", menuName = "Ability Config")]
public class AbilityConfig : ScriptableObject
{
    [field: SerializeField] public AbilityType Type { get; private set; }
    [field: SerializeField, Range(0, 100)] public uint Damage { get; private set; }
    [field: SerializeField] public Sprite Icon { get; private set; }
}
