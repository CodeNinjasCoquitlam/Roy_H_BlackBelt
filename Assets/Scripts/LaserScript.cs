using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserScript : MonoBehaviour
{
    public float LaserHorizontalTime;
    public float LaserVerticalTime;
    public float LotsOfLaserTime;
    public float CircleLaserTime;
    public GameObject Horizontal;
    public GameObject Vertical;
    public GameObject CircleLaser;
    public float minTime = 2, maxTime = 5;
    public float LotsLaserMinTime, LotsLaserMaxTime;
    public float CircleLaserMaxTime, CircleLaserMinTime;
    public int MaxBurst = 6;
    public int MinBurst = 0;
    public bool HardPlus;
    

    // Start is called before the first frame update
    void Start()
    {
        LaserHorizontalTime = 3;
        LaserVerticalTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(LaserHorizontalTime <= 0)
        {
            LaserHorizontalTime = Random.Range(minTime, maxTime);
            SpriteRenderer l = Instantiate(Horizontal).GetComponent<SpriteRenderer>();
            l.enabled = false;
            l.enabled =true;
        }
        if(LaserVerticalTime <= 0)
        {
            LaserVerticalTime = Random.Range(minTime, maxTime);
            SpriteRenderer l = Instantiate(Vertical).GetComponent<SpriteRenderer>();
            l.enabled = false;
            l.enabled = true;
        }
        //Lots of laser thing is going to be when around 6 - 8 lasers - random(Horizontal/Vertical) - spawn at the same time every 10 - 20 secs and deltes all the other active lasers.
        
        if(LotsOfLaserTime <= 0)
        {
            GameObject[]Laser = GameObject.FindGameObjectsWithTag("Lasers");
            if (HardPlus == false)
            {
                foreach(GameObject l in Laser)
                {
                    Destroy(l);
                }
            }
            LotsOfLaserTime = Random.Range(LotsLaserMinTime, LotsLaserMaxTime);
            int RandomNumber = Random.Range(MinBurst, MaxBurst);
            for (int i = 0; i < RandomNumber; i++) 
            {
                Instantiate(Horizontal);
            }
            for (int i = 0; i < (MaxBurst - RandomNumber); i++)
            {
                Instantiate(Vertical);
            }

            LaserHorizontalTime = 4;
            LaserVerticalTime = 4;
        }
        if (HardPlus == true)
        {
            if(CircleLaserTime <= 0)
            {
                CircleLaserTime = Random.Range(CircleLaserMinTime, CircleLaserMaxTime);
                Instantiate(CircleLaser);
            }
        }
        
        LaserHorizontalTime -= Time.deltaTime;
        LaserVerticalTime -= Time.deltaTime;
        LotsOfLaserTime -= Time.deltaTime;
        CircleLaserTime -= Time.deltaTime;
    }
}
