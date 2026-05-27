using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public Text CountdownText;
    public Text TimerText;
    public GameObject CountdownTextHolderThatWillDissapear;
    public float Countdown;
    public float NinetySecondsOfTimer;
    public GameObject WinFP;
    public GameObject WinLBL;
    public GameObject MainCanvas;
    public GameObject LoseCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Countdown = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if(Countdown <= 1)
        {
            CountdownTextHolderThatWillDissapear.SetActive(false);
            NinetySecondsOfTimer -= Time.deltaTime;
            TimeSpan time = new TimeSpan(0, TimeSpan.FromSeconds(NinetySecondsOfTimer).Minutes, TimeSpan.FromSeconds(NinetySecondsOfTimer).Seconds);
            TimerText.text = time.ToString(@"m\:ss");
        }
        if (NinetySecondsOfTimer <= 0)
        {
            if(GameManager.Instance.currentGameMode == GameManager.GameMode.lbl)
            {
                WinLBL.SetActive(true);
            }else if(GameManager.Instance.currentGameMode == GameManager.GameMode.fp)
            {
                WinFP.SetActive(true);
            }
            MainCanvas.SetActive(false);
        }
        Countdown -= Time.deltaTime;
        CountdownText.text = Countdown.ToString();
    }
}
