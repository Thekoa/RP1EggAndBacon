using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This is the Code for interactable items for the player to collect before entering next floor
public class IntItem : MonoBehaviour
{
    public bool bread = false;
    public bool egg = false;
    public bool bacon = false;
    bool stoveOn = false;

    void update()
    {
        if (bread && egg && bacon)
        {
            stoveOn = true;
        }
    }
}
