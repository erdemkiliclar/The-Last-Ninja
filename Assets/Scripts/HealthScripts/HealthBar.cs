using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   [SerializeField] Slider _slider;
    [SerializeField] Gradient _gradient;
    [SerializeField] Image fill;

 

    public void PlayerMaxHealth(int health)
    {
        _slider.maxValue = health;
        _slider.value = health;
        fill.color = _gradient.Evaluate(1f);
    }
    public void PlayerHealth(int health)
    {
        _slider.value = health;

        fill.color = _gradient.Evaluate(_slider.normalizedValue);

    }
    public void EnemyMaxHealth(int health)
    {
        _slider.maxValue = health;
        _slider.value = health;
        fill.color = _gradient.Evaluate(1f);
    }
    public void EnemyHealth(int health)
    {
        _slider.value = health;

        fill.color = _gradient.Evaluate(_slider.normalizedValue);

    }
}
