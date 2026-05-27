using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingShpes : MonoBehaviour
{
    public GameObject FallingGameOb;
    public float spawnCountDown;
    // Start is called before the first frame update
    void Start()
    {
        spawnCountDown = 3;
        gameObject.transform.position = new Vector3(Random.Range(-10, 10), 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnCountDown <= 0)
        {
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);
            Instantiate(FallingGameOb);

            spawnCountDown = 0.1f;
        }
        spawnCountDown -= Time.deltaTime;
    }
}
