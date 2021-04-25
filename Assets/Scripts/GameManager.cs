using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour
{
    public Text timerText;
    private bool updateTimer;
    public GameObject player;
    private GameObject[] platforms;
    public int currentLevel;
    private const string previousLevelText = "Assets/Text Files/PreviousLevel.txt";
    private int endGameScene;

    float timer = 30;

    // Start is called before the first frame update
    void Start()
    {   
        //grabs all the platforms in the game with the tag platform
        platforms = GameObject.FindGameObjectsWithTag("Platform");
        updateTimer = true;
        endGameScene = 5;
    }

    /// <summary>
    /// Updates the timer with the new game time
    /// </summary>
    void Update()
    {   
        //sees how many platforms the player is touching
        int touchingAnyPlatform = 0;

        /*checks if the player is close to a platform.
        if they are then touching update the timer based on whether
        that platform is removing from that platform*/
        for(int i = 0; i < platforms.Length; i++)
        {
            if (Math.Abs(platforms[i].transform.position.x - player.transform.position.x) < 10)
            {
                if (platforms[i].GetComponent<BoxCollider2D>().IsTouching(player.GetComponent<BoxCollider2D>()))
                {
                    touchingAnyPlatform++;
                    updateTimer = platforms[i].GetComponent<Platform>().GetTakeAway();
                }
            }
        }

        //if not touching any platform
        //stop the timing
        if(touchingAnyPlatform == 0)
        {
            updateTimer = false;
        }

        if (updateTimer)
        {
            timer -= Time.deltaTime;
        }

        if(timer <= 0)
        {
            SceneManager.LoadScene(endGameScene);
            File.WriteAllText(previousLevelText, currentLevel.ToString());
        }

        timerText.text = "Time Remaining: " + Math.Round(timer, 2);
    }

    public void AddToTimer(int vTimer)
    {
        timer += vTimer;
    }
}
