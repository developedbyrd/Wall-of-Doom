using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject Timer;

    public void GameOver()
    {
        Timer.SetActive(false);
        GameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void Quit()
    {
        Debug.Log("!QUIT");
        Application.Quit();
    }
}