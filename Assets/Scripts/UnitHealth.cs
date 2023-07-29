using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth 
{
    //fields 

    public int health
    {
        get
        {
            return _currentHelth;
        }
        set
        {
            _currentHelth = value;
        }
    }

    public int MaxHealth
    {
        get
        { 
            return _currentHelth;
        }
        set
        [
            _currentHelth = value;
        ]
    }
}
