using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ChooseMode()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeColour()
    {
        SceneManager.LoadScene(2);
    }
    public void ModeEasy()
    {
        SceneManager.LoadScene(3);
    }
    public void ModeMedium()
    {
        SceneManager.LoadScene(4);
    }
    public void ModeHard()
    {
        SceneManager.LoadScene(5);
    }
    public void ModeNightmare()
    {
        SceneManager.LoadScene(6);
    }
}
