using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui_Controller : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("MainLevel");
    }


    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("Quit already");
    }
    
}
