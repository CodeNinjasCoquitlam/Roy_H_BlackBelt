using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{
    public GameObject PAUSED;
    public GameObject inGameMenu;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PAUSED.SetActive(true);
            inGameMenu.SetActive(false);
            GameObject[]Laser = GameObject.FindGameObjectsWithTag("Lasers");
            foreach(GameObject l in Laser)
            {
                l.GetComponent<Animator>().speed = 0;
            }
        }
    }
    public void ResumeButton()
    {
        PAUSED.SetActive(false);
        inGameMenu.SetActive(true);
        GameObject[] Laser = GameObject.FindGameObjectsWithTag("Lasers");
        foreach (GameObject l in Laser)
        {
            l.GetComponent<Animator>().speed = 1;
        }
    }
}
