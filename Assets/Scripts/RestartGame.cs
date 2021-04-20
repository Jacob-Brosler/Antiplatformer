using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
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
    /// Will Restart the game when the restart game button is clicked
    /// </summary>
    public void LoadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
