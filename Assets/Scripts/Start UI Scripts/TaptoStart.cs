using UnityEngine;
using UnityEngine.UI;

public class TaptoStart : MonoBehaviour
{
    public GameObject TaptoStartGame;

    private void Start()
    {
        PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            TaptoStartGame.SetActive(false);
            StartGame();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            TaptoStartGame.SetActive(false);
            StartGame();
        }
    }
}
