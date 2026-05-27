using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAnimationOfFakeEnding : MonoBehaviour
{
    public float Ending;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ending -= Time.deltaTime;
        if(Ending <= 0)
        {
            SceneManager.LoadScene(7);
        }
    }
}
