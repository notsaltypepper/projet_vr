using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{

    [SerializeField] float damageAmount = 30f;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider player)
    {
        if(player.CompareTag("Player"))
        {
            player.GetComponent<playerHealth>().TakeDamage(damageAmount);
        }
    }

}
