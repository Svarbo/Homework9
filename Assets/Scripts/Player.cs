using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private float _health;

    public float Health => _health;

    private void Start()
    {
        _health = _maxHealth;
    }

    public void GetDamage(float damage)
    {
        if(_health != 0)
        {
            _health -= damage;
        }
    }

    public void GetHeal(float healValue)
    {
        if(_health != _maxHealth)
        {
            _health += healValue;
        }
    }
}
