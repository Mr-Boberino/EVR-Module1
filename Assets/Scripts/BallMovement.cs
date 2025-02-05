using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BallMovement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private GameObject[] pickups;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        pickups = GameObject.FindGameObjectsWithTag("PickUp");
        target = pickups[Random.Range(0, pickups.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        if (!target.activeSelf && pickups.Length != 0)
        {
            print(pickups.Length);
            pickups = GameObject.FindGameObjectsWithTag("PickUp");
            target = pickups[Random.Range(0, pickups.Length)];
            navMeshAgent.SetDestination(target.transform.position);
        }
        else if (target != null) {
            navMeshAgent.SetDestination(target.transform.position);
        }
    }
}
