using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    Slider _healthSlider;

    private void Start()
    {
        _healthSlider = GetComponent<Slider>();
    }

    public void SetMaxHealth(int MaxHealth)
    {
        _healthSlider.maxValue = MaxHealth;
        _healthSlider.value = MaxHealth;
    }

        public void SetHealth(int Health)
    {

        _healthSlider.value = Health;
    }

}
