using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GoToGameScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Restart()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("MainScene");
        Debug.Log("Restarting");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Going to MainMenu");
    }

    public void GoToGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
