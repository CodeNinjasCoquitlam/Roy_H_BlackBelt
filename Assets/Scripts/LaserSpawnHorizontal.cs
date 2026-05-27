using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawnHorizontal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0, Random.Range(7, 380), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
