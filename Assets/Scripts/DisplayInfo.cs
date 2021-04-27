using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class DisplayInfo : MonoBehaviour
{
    [Header("Level1CompletionInfo")]
    [SerializeField] TextMeshProUGUI completedOne;
    [SerializeField] TextMeshProUGUI healthLeftOne;
    [SerializeField] TextMeshProUGUI enemiesKilledOne;

    [Header("Level2CompletionInfo")]
    [SerializeField] TextMeshProUGUI completedTwo;
    [SerializeField] TextMeshProUGUI healthLeftTwo;
    [SerializeField] TextMeshProUGUI enemiesKilledTwo;

    [Header("Level3CompletionInfo")]
    [SerializeField] TextMeshProUGUI completedThree;
    [SerializeField] TextMeshProUGUI healthLeftThree;
    [SerializeField] TextMeshProUGUI enemiesKilledThree;

    // Start is called before the first frame update
    void Start()
    {
        completedOne.text = "";
        healthLeftOne.text = "";
        enemiesKilledOne.text = "";

        completedTwo.text = "";
        healthLeftTwo.text = "";
        enemiesKilledTwo.text = "";

        completedThree.text = "";
        healthLeftThree.text = "";
        enemiesKilledThree.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        int levelOneCompletetion = int.Parse(File.ReadAllText("Assets/Text Files/LevelData/LevelOne/completed.txt"));
        int levelTwoCompletetion = int.Parse(File.ReadAllText("Assets/Text Files/LevelData/LevelTwo/completed.txt"));
        int levelThreeCompletetion = int.Parse(File.ReadAllText("Assets/Text Files/LevelData/LevelThree/completed.txt"));

        if (levelOneCompletetion != -1){
            completedOne.text = "Completed!";
            healthLeftOne.text = "Health Left: " + File.ReadAllText("Assets/Text Files/LevelData/LevelOne/healthLeft.txt");
            enemiesKilledOne.text = "Heroes Killed: " + File.ReadAllText("Assets/Text Files/LevelData/LevelOne/enemiesKilled.txt");
        }

        if (levelTwoCompletetion != -1)
        {
            completedTwo.text = "Completed!";
            healthLeftTwo.text = "Health Left: " + File.ReadAllText("Assets/Text Files/LevelData/LevelTwo/healthLeft.txt");
            enemiesKilledTwo.text = "Heroes Killed: " + File.ReadAllText("Assets/Text Files/LevelData/LevelTwo/enemiesKilled.txt");
        }

        if (levelThreeCompletetion != -1)
        {
            completedThree.text = "Completed!";
            healthLeftThree.text = "Health Left: " + File.ReadAllText("Assets/Text Files/LevelData/LevelThree/healthLeft.txt");
            enemiesKilledThree.text = "Heroes Killed: " + File.ReadAllText("Assets/Text Files/LevelData/LevelThree/enemiesKilled.txt");
        }
    }
}
