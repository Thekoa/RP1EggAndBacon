using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This is the Code for interactable items for the player to collect before entering next floor
public class IntItem : MonoBehaviour
{
    public bool bread = false;
    public bool egg = false;
    public bool bacon = false;

    void Update()
    {
        if ((bread == true && egg == true) && bacon == true)
        {
            GameObject.FindGameObjectWithTag("Finish").GetComponent<Stove>().stoveOn = true;
        }
    }
}
