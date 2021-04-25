using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    private GameObject player;
    private int winSreen;

    /// <summary>
    /// grabs the player and sets teh win screen scene number
    /// </summary>
    void Start()
    {
        player = GameObject.Find("Player");
        winSreen = 6;
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
                SceneManager.LoadScene(winSreen);
            }
        }
    }
}
