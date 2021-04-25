using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCredits : MonoBehaviour
{
    public int restartPoint;
    public Vector2 startPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>
    /// scrolls the credits upwards
    /// once it reaches a certain point it will go back to its original postion
    /// </summary>
    void Update()
    {
        Vector2 pos = this.transform.position;
        pos.y += .25f;
        this.transform.position = pos;

        if (this.transform.position.y >= restartPoint)
        {
            this.transform.position = startPoint;
        }
    }
}
