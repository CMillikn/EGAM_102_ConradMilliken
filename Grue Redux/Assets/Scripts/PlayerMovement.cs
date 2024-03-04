using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D PlayerRB2D;
    public float Move;
    public float MoveDia;
    public float SlowMove;
    public float SlowMoveDia;
    void Awake()
    {
        PlayerRB2D = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.anyKey)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (Input.GetKey(KeyCode.A))
                {
                    PlayerRB2D.velocity = new Vector2(-SlowMove, 0);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    PlayerRB2D.velocity = new Vector2(SlowMove, 0);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    PlayerRB2D.velocity = new Vector2(0, -SlowMove);
                }
                if (Input.GetKey(KeyCode.W))
                {
                    PlayerRB2D.velocity = new Vector2(0, SlowMove);
                }
                if ((Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.W))
                {
                    PlayerRB2D.velocity = new Vector2(-SlowMoveDia, SlowMoveDia);
                }
                if ((Input.GetKey(KeyCode.W)) && Input.GetKey(KeyCode.D))
                {
                    PlayerRB2D.velocity = new Vector2(SlowMoveDia, SlowMoveDia);
                }
                if ((Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.S))
                {
                    PlayerRB2D.velocity = new Vector2(SlowMoveDia, -SlowMoveDia);
                }
                if ((Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.S))
                {
                    PlayerRB2D.velocity = new Vector2(-SlowMoveDia, -SlowMoveDia);
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.A))
                {
                    PlayerRB2D.velocity = new Vector2(-Move, 0);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    PlayerRB2D.velocity = new Vector2(Move, 0);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    PlayerRB2D.velocity = new Vector2(0, -Move);
                }
                if (Input.GetKey(KeyCode.W))
                {
                    PlayerRB2D.velocity = new Vector2(0, Move);
                }
                if ((Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.W))
                {
                    PlayerRB2D.velocity = new Vector2(-MoveDia, MoveDia);
                }
                if ((Input.GetKey(KeyCode.W)) && Input.GetKey(KeyCode.D))
                {
                    PlayerRB2D.velocity = new Vector2(MoveDia, MoveDia);
                }
                if ((Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.S))
                {
                    PlayerRB2D.velocity = new Vector2(MoveDia, -MoveDia);
                }
                if ((Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.S))
                {
                    PlayerRB2D.velocity = new Vector2(-MoveDia, -MoveDia);
                }
            }
        }
        
    }
}
