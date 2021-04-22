using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class RestartGame : MonoBehaviour
{
    private const string previousLevelText = "Assets/Text Files/PreviousLevel.txt";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Will Restart the level when the restart game button is clicked
    /// </summary>
    public void LoadLevel()
    {
        int level = int.Parse(File.ReadAllText(previousLevelText));
        SceneManager.LoadScene(level);
    }
}
