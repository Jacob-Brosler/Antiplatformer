using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    bool paused = false;

    /// <summary>
    /// Pauses or unpauses the level when escape is pressed
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
                Unpause();
            else
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
                paused = true;
            }
        }
    }

    /// <summary>
    /// Restarts the current level
    /// </summary>
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Unpause();
    }

    /// <summary>
    /// Unpauses the level
    /// </summary>
    public void Unpause()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }
}
