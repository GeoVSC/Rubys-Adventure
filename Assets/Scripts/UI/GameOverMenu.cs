using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(1);

    }

    public void MainMenu ()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(0);
        }
    }
}

