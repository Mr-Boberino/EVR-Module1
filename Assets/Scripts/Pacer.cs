using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float speed = 5.0f;
    private float zMax = 3.75f;
    private float zMin =  -3.75f;
    private int direction = 1;
    
    // Update is called once per frame
    void Update()
    {
        float zNew = transform.position.z + direction * speed * Time.deltaTime;
        if (zNew >= zMax)
        {
            zNew = zMax;
            direction *= -1;
        }
        else if (zNew<=zMin)
        {
            zNew = zMin;
            direction *= -1;
        }
        transform.position = new Vector3(3.75f, 0.75f, zNew);
    }
}
