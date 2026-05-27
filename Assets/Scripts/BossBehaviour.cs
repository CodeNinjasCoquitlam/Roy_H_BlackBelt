using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBehaviour : MonoBehaviour
{
    public int Effects;
    public float EffectTime = 3;
    public float BossTime = 300;
    public float InvertTime = 3;
    public float PopUpMessage = 2;
    public Player player;
    public bool Phase1;
    public bool Phase2;
    public bool Phase3;
    public Text EffectName;

    // Start is called before the first frame update
    void Start()
    {
        Phase1 = true;
        Phase2 = false;
        Phase3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(EffectTime <= 0)
        {
            if (Phase1 == true)
            {
                EffectTime = 3;
                Effects = Random.Range(1, 6);
                if (Effects == 1) //Confusion (inverts movement controls, 3 seconds)
                {
                    StartCoroutine(Invert());
                    EffectName.text = "Inverted Controls";
                }
                if (Effects == 2) //Slowness (Self-Explanitory, Slows Player Down, permanant)
                {
                    if(player.speed > 2)
                    {
                     player.speed -= 1;
                     EffectName.text = "-1 speed, speed = " + player.speed;
                    }
                    else
                    {
                        EffectName.text = "Speed too low, cannot lower";
                    }
                   
                }
                if (Effects == 3) // Speed (Also Self-Explanitory, Speeds player up, permanant)
                {
                    if (player.speed > 2)
                    {
                        player.speed += 1;
                        EffectName.text = "+1 speed, speed = " + player.speed;
                    }
                    else
                    {
                        EffectName.text = "Speed too high, cannot lower";
                    }
                }
                if (Effects == 4) // Speed Change (Changes speed, 3 - 10 (not the worst, worse in farther phases))
                {
                    player.speed = Random.Range(3, 10);
                    EffectName.text = "Random Speed, Speed = " + player.speed;
                }
                if (Effects == 5)
                {
                    player.transform.localPosition = new Vector3(Random.Range(-413, 415), -99.8f, 0);
                    EffectName.text = "Random Position!";
                }
                if (Effects == 6) //Jump Cancel
                {

                }
                if (Effects == 7)
                {

                }
                if (Effects == 8)
                {

                }
                if (Effects == 9)
                {

                }
                if (Effects == 10)
                {

                }
            }
            if(Phase2 == true)
            {

            }
            if (Phase3 == true)
            {

            }
        }
        EffectTime -= Time.deltaTime;
        BossTime -= Time.deltaTime;

        if(BossTime <= 200)
        {
            Phase1 = false;
            Phase2 = true;
            Phase3 = false;
        }
        if(BossTime <= 100)
        {
            Phase1 = false;
            Phase2 = false;
            Phase3 = true;
        }
    }
    IEnumerator Invert()
    {
        player.speed = player.speed * -1;
        yield return new WaitForSeconds(2.9f);
        player.speed = player.speed * -1;
    }
}
