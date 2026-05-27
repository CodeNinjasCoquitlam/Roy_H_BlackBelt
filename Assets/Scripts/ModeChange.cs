using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeChange : MonoBehaviour
{
    public void ChangeMode(int mode)
    {
        if (mode == 0)
        {
            GameManager.Instance.currentGameMode = GameManager.GameMode.fp;
        }
        else if (mode == 1)
        {
            GameManager.Instance.currentGameMode = GameManager.GameMode.lbl;
        }
    }
}
