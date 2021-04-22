using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Loads the scene number based on the integer value
    /// that is given to this script.
    /// </summary>
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
