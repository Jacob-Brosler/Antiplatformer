using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class EndLevel : MonoBehaviour
{
    private GameObject player;
    private int winSreen;
    private GameManager manager;
    private float previousHealthLeft;
    public string level;

    /// <summary>
    /// grabs the player and sets teh win screen scene number
    /// </summary>
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        player = GameObject.Find("Player");
        winSreen = 6;
        previousHealthLeft = 0;

        string healthString = File.ReadAllText("Assets/Text Files/LevelData/" + level + "/healthLeft.txt");
        float.TryParse(healthString, out previousHealthLeft);
    }

    /// <summary>
    /// Checks to see if the player is within the end blocks location
    /// </summary>
    void Update()
    {
        if (this.transform.position.x - player.transform.position.x <= 10)
        {
            if (this.GetComponent<BoxCollider2D>().IsTouching(player.GetComponent<BoxCollider2D>()))
            {
                File.WriteAllText("Assets/Text Files/LevelData/" + level + "/completed.txt", "0");

                if (manager.GetTimerRemaining() > previousHealthLeft)
                {
                    File.WriteAllText("Assets/Text Files/LevelData/" + level + "/healthLeft.txt", manager.GetTimerRemaining().ToString());
                    File.WriteAllText("Assets/Text Files/LevelData/" + level + "/enemiesKilled.txt", manager.GetEnemiesKilled().ToString());
                }
                SceneManager.LoadScene(winSreen);
            }
        }
    }
}
