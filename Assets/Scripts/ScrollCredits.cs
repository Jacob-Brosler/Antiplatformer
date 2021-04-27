using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollCredits : MonoBehaviour
{
    public float restartPoint;
    public Vector2 startPoint;
    private RectTransform rect;

    // Start is called before the first frame update
    void Start()
    {
        rect = this.GetComponent<RectTransform>();
    }

    /// <summary>
    /// scrolls the credits upwards
    /// once it reaches a certain point it will go back to its original postion
    /// </summary>
    void Update()
    {
        Vector2 pos = rect.transform.position;
        pos.y += .5f;
        rect.transform.position = pos;


        if (rect.transform.position.y >= restartPoint)
        {
            rect.transform.position = startPoint;
        }
    }
}
