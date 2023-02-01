using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{

    [SerializeField] float maxHealth = 100;
    [SerializeField] float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;

        Debug.Log(currentHealth);

        if(currentHealth <= 0)
        {
            Debug.Log("Dead");
        }
    }
}
