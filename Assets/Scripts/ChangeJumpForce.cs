using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeJumpForce : MonoBehaviour
{
    private GameObject player;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x - player.transform.position.x <= 10)
        {
            if (this.GetComponent<BoxCollider2D>().IsTouching(player.GetComponent<BoxCollider2D>()))
            {
                player.GetComponent<CharacterController2D>().setJumpForce(jumpForce);
            }
        }
    }
}
