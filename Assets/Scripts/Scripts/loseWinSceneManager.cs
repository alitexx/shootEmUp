using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseWinSceneManager : MonoBehaviour
{
    public static void loadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public static void restartLevel (string sceneName)
    {
        playerController.resetValues();
        SceneManager.LoadScene(sceneName);
    }
}
