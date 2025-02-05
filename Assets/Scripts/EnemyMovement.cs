using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;
    public GameObject enemy;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
        if (time >= 4) {
            time = 0;
            Instantiate(enemy, new Vector3(Random.Range(-20,20), 2, Random.Range(-20, 20)), new Quaternion(0, 0, 0, 1));
        }
    }
}
