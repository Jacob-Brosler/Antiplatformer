using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelData : MonoBehaviour
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
    /// saves the level data into saved data
    /// </summary>
    public void SavaData()
    {
        File.WriteAllText("Assets/Text Files/SavedData/LevelOne/completed.txt",
            File.ReadAllText("Assets/Text Files/LevelData/LevelOne/completed.txt"));
        File.WriteAllText("Assets/Text Files/SavedData/LevelOne/healthLeft.txt",
            File.ReadAllText("Assets/Text Files/LevelData/LevelOne/healthLeft.txt"));
        File.WriteAllText("Assets/Text Files/SavedData/LevelOne/enemiesKilled.txt",
            File.ReadAllText("Assets/Text Files/LevelData/LevelOne/enemiesKilled.txt"));

        File.WriteAllText("Assets/Text Files/SavedData/LevelTwo/completed.txt",
            File.ReadAllText("Assets/Text Files/LevelData/LevelTwo/completed.txt"));
        File.WriteAllText("Assets/Text Files/SavedData/LevelTwo/healthLeft.txt",
            File.ReadAllText("Assets/Text Files/LevelData/LevelTwo/healthLeft.txt"));
        File.WriteAllText("Assets/Text Files/SavedData/LevelTwo/enemiesKilled.txt",
            File.ReadAllText("Assets/Text Files/LevelData/LevelTwo/enemiesKilled.txt"));

        File.WriteAllText("Assets/Text Files/SavedData/LevelThree/completed.txt",
            File.ReadAllText("Assets/Text Files/LevelData/LevelThree/completed.txt"));
        File.WriteAllText("Assets/Text Files/SavedData/LevelThree/healthLeft.txt",
            File.ReadAllText("Assets/Text Files/SavedData/LevelThree/healthLeft.txt"));
        File.WriteAllText("Assets/Text Files/LevelData/LevelThree/enemiesKilled.txt",
            File.ReadAllText("Assets/Text Files/LevelData/LevelThree/enemiesKilled.txt"));
    }

    /// <summary>
    /// Load data to local data from the saved data
    /// </summary>
    public void LoadData()
    {
        File.WriteAllText("Assets/Text Files/LevelData/LevelOne/completed.txt",
            File.ReadAllText("Assets/Text Files/SavedData/LevelOne/completed.txt"));
        File.WriteAllText("Assets/Text Files/LevelData/LevelOne/healthLeft.txt",
            File.ReadAllText("Assets/Text Files/SavedData/LevelOne/healthLeft.txt"));
        File.WriteAllText("Assets/Text Files/LevelData/LevelOne/enemiesKilled.txt",
            File.ReadAllText("Assets/Text Files/SavedData/LevelOne/enemiesKilled.txt"));

        File.WriteAllText("Assets/Text Files/LevelData/LevelTwo/completed.txt",
            File.ReadAllText("Assets/Text Files/SavedData/LevelTwo/completed.txt"));
        File.WriteAllText("Assets/Text Files/LevelData/LevelTwo/healthLeft.txt",
            File.ReadAllText("Assets/Text Files/SavedData/LevelTwo/healthLeft.txt"));
        File.WriteAllText("Assets/Text Files/LevelData/LevelTwo/enemiesKilled.txt",
            File.ReadAllText("Assets/Text Files/SavedData/LevelTwo/enemiesKilled.txt"));

        File.WriteAllText("Assets/Text Files/LevelData/LevelThree/completed.txt",
            File.ReadAllText("Assets/Text Files/SavedData/LevelThree/completed.txt"));
        File.WriteAllText("Assets/Text Files/LevelData/LevelThree/healthLeft.txt",
            File.ReadAllText("Assets/Text Files/SavedData/LevelThree/healthLeft.txt"));
        File.WriteAllText("Assets/Text Files/LevelData/LevelThree/enemiesKilled.txt",
            File.ReadAllText("Assets/Text Files/SavedData/LevelThree/enemiesKilled.txt"));
    }
}
