using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheAbsoluteRadience : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(Random.Range(-100, 110), Random.Range(-40, 40), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
