using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : MonoBehaviour
{
   void OnMouseDown() 
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<IntItem>().bread = true;
        Destroy(gameObject);
    }
}
