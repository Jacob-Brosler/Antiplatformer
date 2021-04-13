using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timerText;

    float timer = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>
    /// Updates the timer with the new game time
    /// </summary>
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = "Time Remaining: " + Math.Round(timer, 2);
    }
}
