using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DeleteLocalData : MonoBehaviour
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
    /// when the application quites this will make sure to delete all local data
    /// </summary>
    private void OnApplicationQuit()
    {
        File.WriteAllText("Assets/Text Files/LevelData/LevelOne/completed.txt", "-1");
        File.WriteAllText("Assets/Text Files/LevelData/LevelOne/healthLeft.txt", "");
        File.WriteAllText("Assets/Text Files/LevelData/LevelOne/enemiesKileld.txt", "");

        File.WriteAllText("Assets/Text Files/LevelData/LevelTwo/completed.txt", "-1");
        File.WriteAllText("Assets/Text Files/LevelData/LevelTwo/healthLeft.txt", "");
        File.WriteAllText("Assets/Text Files/LevelData/LevelTwo/enemiesKilled.txt", "");

        File.WriteAllText("Assets/Text Files/LevelData/LevelThree/completed.txt", "-1");
        File.WriteAllText("Assets/Text Files/LevelData/LevelThree/healthLeft.txt", "");
        File.WriteAllText("Assets/Text Files/LevelData/LevelThree/enemiesKilled.txt", "");
    }
}
