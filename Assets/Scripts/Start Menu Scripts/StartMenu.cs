using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Gameplay");
    }

    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
