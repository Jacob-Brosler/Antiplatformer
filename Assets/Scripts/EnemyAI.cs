using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private float DistanceFromLedge = .2f;
    private float DistanceFromWall = .2f;

    public GameObject player;
    public GameObject Enemy;
    private GameManager manager;
    private int time;

    private Rigidbody2D Rb;
    private bool FaceRight = true;
    private int goRight = 1;
    private float speed = 1;

    private bool OnGround;
    private bool HitWall;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask whatIsGround;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        time = 5;
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Moves the enemy and flips direction when at a ledge or hitting a wall
    /// </summary>
    void Update()
    {
        OnGround = Physics2D.Raycast(groundCheck.position, Vector2.down, DistanceFromLedge, whatIsGround);
        HitWall = Physics2D.Raycast(wallCheck.position, transform.right, DistanceFromWall, whatIsGround);

        if (!OnGround || HitWall)
        {
            Flip();
        }
        else
        {
            movement.Set(speed * goRight, Rb.velocity.y);
            Rb.velocity = movement;
        }
    }

    /// <summary>
    /// Flip the enemy's direction
    /// </summary>
    private void Flip()
    {
        FaceRight = !FaceRight;

        goRight *= -1;

        // Multiply local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    /// <summary>
    /// Checks for a collision between the Rigidbodies of the player and this enemy.
    /// </summary>
    /// <param name="col"></param>
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.attachedRigidbody == player.GetComponent<Rigidbody2D>())
        {   
            //if player hit enemy update the timer time
            manager.AddToTimer(time);
            manager.IncreaseEnemiesKilled();

            //Delete this Enemy
            Destroy(this.gameObject);
        }
    }
}
