using UnityEngine;
using UnityEngine.Events;

public class OldPlayerScript : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _healValue;
    [SerializeField] private UnityEvent _onHealthChanged;

    private float _health;

    public float Health => _health;

    private void Start()
    {
        _health = _maxHealth;

        _onHealthChanged.Invoke();
    }

    public void GetDamage(float damage)
    {
        if (_health != 0)
        {
            _health -= damage;

            _onHealthChanged.Invoke();
        }
    }

    public void Heal()
    {
        if (_health != _maxHealth)
        {
            _health += _healValue;

            _onHealthChanged.Invoke();
        }
    }
}
