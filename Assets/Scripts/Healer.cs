using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private float _healValue;
    [SerializeField] private Player _target;

    public void Heal()
    {
        _target.GetHeal(_healValue);
    }
}