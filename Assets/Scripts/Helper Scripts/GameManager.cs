using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
            Instance = null;
    }

    // Update is called once per frame
    public void restartgame()
    {
        Invoke("RestartAfterTime", 1f);
    }

    void RestartAfterTime()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
