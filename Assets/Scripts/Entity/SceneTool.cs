using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTool : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("DevBastien", LoadSceneMode.Single);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
