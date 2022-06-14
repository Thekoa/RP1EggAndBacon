using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timeLeft = 10.0f;
    public GameObject timer;

    void Update()
    {
        timer.GetComponent<Text>().text ="Timer: " +(Mathf.Round(timeLeft * 10.0f) * 0.1f);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene(5);
        }
    }
}