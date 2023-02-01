using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    [SerializeField] float health = 4f;


    // Update is called once per frame
    public void TakeDamage()
    {
        health -= 1;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
