using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui_Controller : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("MainLevel");
        Character_Movement.con = true;
    }


    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("Quit already");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
