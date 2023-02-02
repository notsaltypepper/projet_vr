using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] float health = 4f;


    // Update is called once per frame
    public void TakeDamage()
    {
            Destroy(gameObject);
    }
}
