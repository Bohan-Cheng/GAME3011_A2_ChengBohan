using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMana : MonoBehaviour
{
    public void ChangeMap(string mapName)
    {
        SceneManager.LoadScene(mapName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
