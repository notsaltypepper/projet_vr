using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private NavMeshAgent nma;

    // Start is called before the first frame update
    void Start()
    {
        nma = GetComponent<NavMeshAgent>();
        nma.isStopped = false;
    }

    // Update is called once per frame
    void Update() 
    {
        // Set destination
        nma.SetDestination(player.transform.position);
        if(true)
        {

        }
    }
}
