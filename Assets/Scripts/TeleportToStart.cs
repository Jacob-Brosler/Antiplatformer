using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToStart : MonoBehaviour
{
    private GameObject player;
    private Vector2 pos;

    /// <summary>
    /// instantiates the player and the beginning position
    /// </summary>
    void Start()
    {
        player = GameObject.Find("Player");
        pos = new Vector2(0, 1);
    }

    /// <summary>
    /// checks to see if the player is within a range of the out of bounds box.
    /// If so check if they are touching. If they are touching teleport the player back to the start
    /// </summary>
    void Update()
    {
        if (this.transform.position.y - player.transform.position.y <= 10)
        {
            if (this.GetComponent<BoxCollider2D>().IsTouching(player.GetComponent<BoxCollider2D>()))
            {
                player.transform.position = pos;
            }
        }
    }
}
