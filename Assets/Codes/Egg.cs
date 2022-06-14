using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    void OnMouseDown()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<IntItem>().egg = true;
        Destroy(gameObject);
    }
}
