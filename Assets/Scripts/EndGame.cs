using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       
    /// <summary>
    /// Will end the game when the quit game button is clicked
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }
}
