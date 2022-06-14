using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacon : MonoBehaviour
{
    void OnMouseDown()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<IntItem>().bacon =true;
        Destroy(gameObject);
    }


}
