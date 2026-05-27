using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    public GameObject LoseMenu;
    public GameObject InGameMenu;
    public GameObject EndingNightmareScene;
    public GameObject TheEndOfTheGame;
    public float Lives = 3;
    public float speed;
    public float Ending = 9;
    public Rigidbody2D rb;
    public bool Nightmare;
    public bool BossFightMovement;
    public bool JumpAllowed;


    // Start is called before the first frame update
    void Start()
    {
        Life1.SetActive(true);
        Life2.SetActive(true);
        Life3.SetActive(true);
        LoseMenu.SetActive(false);
        InGameMenu.SetActive(true);
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = GameManager.Instance.Colour;
        sr.enabled = false;
        sr.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        LivesCount();
        Movement();
    }
    
    public void Movement()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * speed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow) && BossFightMovement == false || Input.GetKey(KeyCode.W) && BossFightMovement == false)
        {
            rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow) && BossFightMovement == false || Input.GetKey(KeyCode.S) && BossFightMovement == false)
        {
            rb.AddForce(-transform.up * speed, ForceMode2D.Impulse);
        }
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space)) && BossFightMovement == true && JumpAllowed == true)
        {
            rb.AddForce(transform.up * speed * 20, ForceMode2D.Impulse);
        }
    }
    public void LivesCount()
    {
        if (Lives <= 2)
        {
            Life3.SetActive(false);
        }
        if (Lives <= 1)
        {
            Life2.SetActive(false);
        }
        if (Lives <= 0 && Nightmare == false)
        {
            Life1.SetActive(false);
            LoseMenu.SetActive(true);
            InGameMenu.SetActive(false);
        }
        if (Nightmare == true && Lives <= 0)
        {
            GameObject[] Laser = GameObject.FindGameObjectsWithTag("Lasers");
            
                foreach (GameObject l in Laser)
                {
                    Destroy(l);
                }
            EndingNightmareScene.SetActive(true);
            InGameMenu.SetActive(false);
            Ending -= Time.deltaTime;
        }
        if (Nightmare == true)
        {
            Lives = 1;
        }
        if(Ending <= 0)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            EndingNightmareScene.SetActive(false);
            TheEndOfTheGame.SetActive(true);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Lasers"))
        {
            Lives -= 1;
        }
    }
}