using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapLoader : MonoBehaviour
{
    public void LoadMap(string scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1.0f;
    }

    public void ExitMap()
    {
        Application.Quit();
    }
}
