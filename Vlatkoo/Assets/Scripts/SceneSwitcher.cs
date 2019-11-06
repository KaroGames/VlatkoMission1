using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void Goto1Scene()
    {
        SceneManager.LoadScene("1");
    }

    public void Goto2Scene()
    {
        SceneManager.LoadScene("2");
    }

    public void Goto3Scene()
    {
        SceneManager.LoadScene("3");
    }

    public void Goto3aScene()
    {
        SceneManager.LoadScene("3a");
    }

    public void Goto3bScene()
    {
        SceneManager.LoadScene("3b");
    }

    public void Goto4Scene()
    {
        SceneManager.LoadScene("4");
    }

    public void Goto4abcScene()
    {
        SceneManager.LoadScene("4abc");
    }

    public void Goto5Scene()
    {
        SceneManager.LoadScene("5");
    }

    public void Goto5aScene()
    {
        SceneManager.LoadScene("5a");
    }

    public void Goto5bScene()
    {
        SceneManager.LoadScene("5b");
    }

    public void Goto6aScene()
    {
        SceneManager.LoadScene("6a");
    }

    public void Goto6bScene()
    {
        SceneManager.LoadScene("6b");
    }

    public void Goto7aScene()
    {
        SceneManager.LoadScene("7a");
    }

    public void Goto7bScene()
    {
        SceneManager.LoadScene("7b");
    }

    public void Goto8bScene()
    {
        SceneManager.LoadScene("8b");
    }

    public void Goto9aScene()
    {
        SceneManager.LoadScene("9a");
    }

    public void Goto10aScene()
    {
        SceneManager.LoadScene("10a");
    }

    public void Goto11aScene()
    {
        SceneManager.LoadScene("11a");
    }

    public void Goto12Scene()
    {
        SceneManager.LoadScene("12");
    }

    public void Goto12aScene()
    {
        SceneManager.LoadScene("12a");
    }

    public void Goto13Scene()
    {
        SceneManager.LoadScene("13");
    }

    public void Goto14Scene()
    {
        SceneManager.LoadScene("14");
    }

    public void Goto15Scene()
    {
        SceneManager.LoadScene("15");
    }

    public void GotoIf8bNoScene()
    {
        SceneManager.LoadScene("If 8b No");
    }

    public void GotoIf8bNo9ab1Scene()
    {
        SceneManager.LoadScene("If 8b No 9ab.1");
    }

    public void GotoIf8bNo9ab2Scene()
    {
        SceneManager.LoadScene("If 8b No 9ab.2");
    }

    public void GotoIfbNo9ab3Scene()
    {
        SceneManager.LoadScene("If 8b No 9ab.3");
    }

    public void GotoIf8bYesScene()
    {
        SceneManager.LoadScene("If 8b Yes");
    }

    public void GotoIf8bYes9b1Scene()
    {
        SceneManager.LoadScene("If 8b Yes 9b.1");
    }

    public void GotoIf8bYes9b2Scene()
    {
        SceneManager.LoadScene("If 8b Yes 9b.2");
    }

    public void GotoIf15No15bScene()
    {
        SceneManager.LoadScene("If 15 No 15b");
    }

    public void GotoIf15Yes15aScene()
    {
        SceneManager.LoadScene("If 15 Yes 15a");
    }

    public void GotoIf15YesandIf15aSelect16Scene()
    {
        SceneManager.LoadScene("If 15 Yes and If 15a Select 16");
    }

    public void GotoIf16DrinkScene()
    {
        SceneManager.LoadScene("If 16 Drink");
    }

    public void GotoIf16FoodScene()
    {
        SceneManager.LoadScene("If 16 Food");
    }

    public void GotoNecandSameFinalScene()
    {
        SceneManager.LoadScene("Nec. and Same Final");
    }

    public void GotoStartScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void GotoTheEndScene()
    {
        SceneManager.LoadScene("The End");
    }

    public void doExitGame()
    {
        Application.Quit();
    }
}


  
