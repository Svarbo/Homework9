using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarDrawer : MonoBehaviour
{
    private const int RateOfChange = 50;

    [SerializeField] private Slider _healthBar;
    [SerializeField] private Player _player;

    public void Draw()
    {
        StartCoroutine(ChangeHealthBarValue());

        Debug.Log(_player.Health);
    }

    private IEnumerator ChangeHealthBarValue()
    {
        while(_healthBar.value != _player.Health)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, _player.Health, RateOfChange * Time.deltaTime);

            yield return null;
        }
    }
}
