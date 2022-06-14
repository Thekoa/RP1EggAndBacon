using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MianMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

}
