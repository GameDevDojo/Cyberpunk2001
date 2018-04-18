using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    int maxHealth = 100; //ilość maksymalna życia
    int currentHealth; //życie aktualne

    void Death()
    {
        Debug.LogError("Death not implemented"); //tymczasowe
    }

    public void Damage(int amount)
    {
        currentHealth -= amount; //otrzymywanie obrażeń

        if (currentHealth <= 0)
        {
            Death();  //umieranie
        }
    }

    void Start()
    {
        int currentHealth = maxHealth;  //ilość zdrowia gdy nie ponieśliśmy żadnych obrażeń
    }

}


