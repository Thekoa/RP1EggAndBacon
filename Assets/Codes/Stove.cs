using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stove : MonoBehaviour
{
    public bool stoveOn = false;

    void OnMouseDown()
    {
        if (stoveOn == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
