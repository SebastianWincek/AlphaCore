using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour
{
    public int _health = 100;
    public int currentHealth;
    
    public HealthBar healthbar;

    void Start()
    {
        currentHealth = _health;
        healthbar.SetMaxHealth(_health);
    }

    public void Hurt(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <0)
        {
            currentHealth = 0;
        }

        Debug.Log("Health: " + currentHealth);
        healthbar.SetHealth(currentHealth);
    }
    public void Healing(int Heal)
    {
        currentHealth += Heal;
        if(currentHealth > 100)
        {
            currentHealth = 100;
        }

        Debug.Log("Health" + currentHealth);
        healthbar.SetHealth(currentHealth);
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Hurt(20);
            
        }
    }
}


