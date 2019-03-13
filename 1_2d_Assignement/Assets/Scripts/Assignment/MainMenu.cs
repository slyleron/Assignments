using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
   
    //Which level to load
    public int levelToLoad;
    //function to call loading level
    public void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    public void RunForestRun()
    {
        SceneManager.LoadScene("RunForestRun");
    }
    public void Tank()
    {
        SceneManager.LoadScene("Tank");
    }
    public void Painter()
    {
        SceneManager.LoadScene("Painter");
    }
    public void Skiier()
    {
        SceneManager.LoadScene("Skiier");
    }
    public void ArrowShooter()
    {
        SceneManager.LoadScene("ArrowShooter");
    }
    


    //exit will not work at this time due to it not being an actual game
    public void LevelExit()
    {
        Application.Quit();
    }
}
