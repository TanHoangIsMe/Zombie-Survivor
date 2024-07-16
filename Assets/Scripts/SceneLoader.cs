using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
