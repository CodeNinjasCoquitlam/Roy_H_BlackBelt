using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawnVertical : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(Random.Range(7, 870), 188, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
