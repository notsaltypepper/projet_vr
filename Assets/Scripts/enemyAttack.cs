using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    [SerializeField] float damageAmount = 30f;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider player)
    {
        if(player.CompareTag("Player"))
        {
            player.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
        }
    }

}
