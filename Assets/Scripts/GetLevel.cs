using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GetLevel : MonoBehaviour
{
    private const string previousLevelText = "Assets/Text Files/PreviousLevel.txt";

    /// <summary>
    /// Gets the previous level to display which level was completed
    /// </summary>
    void Start()
    {
        int level = int.Parse(File.ReadAllText(previousLevelText));

        level -= 1;

        this.GetComponent<Text>().text = "Level " + level + " Completed!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
