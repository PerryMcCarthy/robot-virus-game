using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth 
{
    //fields 
    int _currentHealth;
    int _currentMaxHealth;

    public int health
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
        }
    }

    public int MaxHealth
    {
        get
        { 
            return _currentMaxHealth;
        }
        set
        {
            _currentMaxHealth = value;
        }
    }

    public UnitHealth(int Health, int MaxHealth)
    {
        _currentHealth = Health;
        _currentMaxHealth = MaxHealth;
    }

    public void DmgUnit(int dmgAmount)
    {
        if(_currentHealth > 0)
        {
            _currentHealth -= dmgAmount;
        }
    }
    public void HealUnit(int HealAmount)
    {
        if(_currentHealth < _currentMaxHealth)
        {
            _currentHealth += HealAmount;
        }
        if (_currentHealth > _currentMaxHealth)
        {
            _currentHealth = _currentMaxHealth; 
        }
    }
}
