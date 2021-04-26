using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIType2 : MonoBehaviour
{
    private float DistanceFromWall = .2f;

    public GameObject player;
    public GameObject Enemy;
    private GameManager manager;
    private int time;

    private Rigidbody2D Rb;
    private bool FaceRight = true;
    private int goRight = 1;
    private float speed = 1;
    private bool HitWall;

    //Flight Based
    private Vector2 origin;
    private int travdist = 0;
    public int distMax = 400;
    public int circSize = 5;
    private float angle = 0;



    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask whatIsGround;

    Vector2 movement;

    public enum FlightPattern
    {
        FlyStraight,
        FlyCircle,
    }

    public FlightPattern flyType;

    // Start is called before the first frame update
    void Start()
    {
        time = 5;
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Rb = GetComponent<Rigidbody2D>();

        origin = transform.position;
    }

    /// <summary>
    /// Moves the flying enemy and flips direction when hitting a wall
    /// </summary>
    void Update()
    {
        travdist++;
        HitWall = Physics2D.Raycast(wallCheck.position, transform.right, DistanceFromWall, whatIsGround);

        if (HitWall || travdist >= distMax)
        {
            Flip();
            travdist = 0;
        }
        else
        {
            if (flyType == FlightPattern.FlyStraight)
            {
                movement.Set(speed * goRight, Rb.velocity.y);

                Rb.velocity = movement;
            }

            else if (flyType == FlightPattern.FlyCircle)
            {
                angle += Time.deltaTime * speed;

                float x = Mathf.Cos(angle) * circSize;
                float y = Mathf.Sin(angle) * circSize;

                transform.position = origin + new Vector2(x,y);
            }
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

            //Delete this Enemy
            Destroy(this.gameObject);
        }
    }
}
