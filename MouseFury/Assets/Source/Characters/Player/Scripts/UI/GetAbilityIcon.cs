using UnityEngine;
using UnityEngine.UI;

public class GetAbilityIcon : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField, Range(0, 2)] private int _ability;
    [SerializeField] private AbilitiesContainer _abilitiesContainer;

    private void Start()
    {
        _image.sprite = _abilitiesContainer.Abilities[_ability].Icon;
    }
}
