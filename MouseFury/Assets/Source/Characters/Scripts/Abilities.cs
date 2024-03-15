using UnityEngine;

namespace Abilities
{
    public class Ability
    {
        public readonly AbilityType Type;
        public readonly uint Damage;
        public readonly Sprite Icon;

        public Ability(AbilityConfig config)
        {
            Type = config.Type;
            Damage = config.Damage;
            Icon = config.Icon;
        }
    }

    public enum AbilityType
    {
        None,
        Punch,
        Kick,
        Uppercut
    }
}