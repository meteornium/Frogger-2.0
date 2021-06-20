using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroggerMenuController : MonoBehaviour
{
    public SceneLoader loader;

    public void LoadNextLevel()
    {
        loader.LoadSceneName("FroggerGameScreen");
    }

    public void RestartGame()
    {
        loader.LoadSceneName("FroggerGameScreen");
    }

    public void MainMenu()
    {
        loader.LoadMainMenu();
    }
}
