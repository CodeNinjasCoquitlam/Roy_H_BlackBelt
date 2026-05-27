using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public void ColourChange(int ChangeColour)
    {
        //Debug.Log("colof changed to " + Colour);
        if (ChangeColour == 0)
        {
            GameManager.Instance.Colour = new Color(255f / 255f, 0f, 0f);
        }
        else if (ChangeColour == 1)
        {
            GameManager.Instance.Colour = new Color(255f / 255f, 135f / 255f, 0);
        }
        else if (ChangeColour == 2)
        {
            GameManager.Instance.Colour = new Color(255, 237, 0);
        }
        else if (ChangeColour == 3)
        {
            GameManager.Instance.Colour = new Color(17f / 255f, 255f / 255f, 0);
        }
        else if (ChangeColour == 4)
        {
            GameManager.Instance.Colour = new Color(0, 0, 255);
        }
        else if (ChangeColour == 5)
        {
            GameManager.Instance.Colour = new Color(0, 220, 255);
        }
        else if (ChangeColour == 6)
        {
            GameManager.Instance.Colour = new Color(255, 0, 255);
        }
        else if (ChangeColour == 7)
        {
            GameManager.Instance.Colour = new Color(255, 255, 255);
        }
    }
}
