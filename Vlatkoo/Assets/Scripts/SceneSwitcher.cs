using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoTypr1Scene()
    {
        SceneManager.LoadScene("TypeWriter");
    }

    public void GotoHomeScene()
    {
        SceneManager.LoadScene("New Scene");
    }

    public void GotoTypr2Scene()
    {
        SceneManager.LoadScene("TypeWriter 1");
    }

    public void GotoOutdoorScene()
    {
        SceneManager.LoadScene("Outdoor");
    }

    public void GotoCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GotoStartMenuScene()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void GotoOptionsScene()
    {
        SceneManager.LoadScene("Options");
    }



    public void doExitGame()
    {
        Application.Quit();
    }
}


  
