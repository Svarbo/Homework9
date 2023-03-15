using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _healValue;
    [SerializeField] private UnityEvent _onHealthChanged;

    private float _health;

    public float Health => _health;
    public float MaxHealth => _maxHealth;

    private void Start()
    {
        _health = Mathf.Clamp(_maxHealth, 0, _maxHealth);

        _onHealthChanged.Invoke();
    }

    public void GetDamage(float damage)
    {
        _health = Mathf.Clamp(_health - damage, 0, _maxHealth);

        _onHealthChanged.Invoke();
    }

    public void Heal()
    {
        _health = Mathf.Clamp(_health + _healValue, 0, _maxHealth);

        _onHealthChanged.Invoke();
    }
}

