using UnityEngine;
using UnityEngine.UI;
using System;

public abstract class HealthVisualizer : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected uint MaxHealth => _health.MaxHealth;
    protected uint CurrentHealth => _health.CurrentHealth;

    private void OnEnable() => _health.Changed += OnHealthChanged;    

    private void OnDisable() => _health.Changed -= OnHealthChanged;
    
    protected abstract void OnHealthChanged();

    protected void UpdateSliderValues(Slider slider)
    {
       if(slider == null)
            throw new ArgumentNullException(nameof(slider));

        slider.maxValue = MaxHealth;
        slider.value = CurrentHealth;
    }
}