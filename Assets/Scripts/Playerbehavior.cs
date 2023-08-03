using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbehavior : MonoBehaviour
{
    [SerializeField] Healthbar _healthbar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerTakeDmg(20);
            Debug.Log(GameManager.gameManager._playerHealth.health);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerHeal(10);
            Debug.Log(GameManager.gameManager._playerHealth.health);
        }
    }

    private void PlayerTakeDmg(int Dmg)
    {
        GameManager.gameManager._playerHealth.DmgUnit(Dmg);
        _healthbar.SetHealth(GameManager.gameManager._playerHealth.health);
    }
    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealUnit(healing);
        _healthbar.SetHealth(GameManager.gameManager._playerHealth.health);
    }
}
