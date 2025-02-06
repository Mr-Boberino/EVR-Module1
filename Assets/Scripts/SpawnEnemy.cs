using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private float time;
    public GameObject enemy;
    private Vector3[] spawns = { new Vector3(9, (float)0.5, 9), new Vector3(-9, (float)0.5, 9), new Vector3(9, (float)0.5, -9), new Vector3(-9, (float)0.5, -9) };
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 8)
        {
            time = 0;
            Instantiate(enemy, spawns[Random.Range(0,3)], new Quaternion(0, 0, 0, 1));
        }
    }
}
