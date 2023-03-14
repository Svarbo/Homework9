using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _damage;
    [SerializeField] private Player _target;

    public void Hit()
    {
        _target.GetDamage(_damage);
    }
}
