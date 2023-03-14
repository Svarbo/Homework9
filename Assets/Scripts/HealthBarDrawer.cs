using UnityEngine;
using UnityEngine.UI;

public class HealthBarDrawer : MonoBehaviour
{
    private const int RateOfChange = 50;

    [SerializeField] private Slider _healthBar;
    [SerializeField] private Player _player;

    public void Update()
    {
        _healthBar.value = Mathf.MoveTowards(_healthBar.value, _player.Health, RateOfChange * Time.deltaTime);
    }
}
