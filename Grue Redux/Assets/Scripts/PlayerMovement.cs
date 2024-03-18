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
    public LanternGrounded LanternGrounded;
    public Animator Farmer;
    void Awake()
    {
        PlayerRB2D = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        transform.rotation = Quaternion.identity;
        if (LanternGrounded.IsGrounded == false)
        {
            Farmer.SetBool("Darkened", false);
            if (Input.anyKey)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    Farmer.SetBool("LanternUp", true);
                    if (Input.GetKey(KeyCode.A))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(-SlowMove, 0);
                        transform.localScale = new Vector2(-0.25f, 0.25f);
                    }
                    if (Input.GetKey(KeyCode.D))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(SlowMove, 0);
                        transform.localScale = new Vector2(0.25f, 0.25f);
                    }
                    if (Input.GetKey(KeyCode.S))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(0, -SlowMove);
                    }
                    if (Input.GetKey(KeyCode.W))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(0, SlowMove);
                    }
                    if ((Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.W))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(-SlowMoveDia, SlowMoveDia);
                        transform.localScale = new Vector2(-0.25f, 0.25f);
                    }
                    if ((Input.GetKey(KeyCode.W)) && Input.GetKey(KeyCode.D))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(SlowMoveDia, SlowMoveDia);
                        transform.localScale = new Vector2(0.25f, 0.25f);
                    }
                    if ((Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.S))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(SlowMoveDia, -SlowMoveDia);
                        transform.localScale = new Vector2(0.25f, 0.25f);
                    }
                    if ((Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.S))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(-SlowMoveDia, -SlowMoveDia);
                        transform.localScale = new Vector2(-0.25f, 0.25f);
                    }
                }
                else
                {
                    Farmer.SetBool("LanternUp", false);
                    if (Input.GetKey(KeyCode.A))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(-Move, 0);
                        transform.localScale = new Vector2(-0.25f, 0.25f);
                    }
                    if (Input.GetKey(KeyCode.D))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(Move, 0);
                        transform.localScale = new Vector2(0.25f, 0.25f);
                    }
                    if (Input.GetKey(KeyCode.S))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(0, -Move);
                    }
                    if (Input.GetKey(KeyCode.W))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(0, Move);
                    }
                    if ((Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.W))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(-MoveDia, MoveDia);
                        transform.localScale = new Vector2(-0.25f, 0.25f);
                    }
                    if ((Input.GetKey(KeyCode.W)) && Input.GetKey(KeyCode.D))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(MoveDia, MoveDia);
                        transform.localScale = new Vector2(0.25f, 0.25f);
                    }
                    if ((Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.S))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(MoveDia, -MoveDia);
                        transform.localScale = new Vector2(0.25f, 0.25f);
                    }
                    if ((Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.S))
                    {
                        Farmer.SetBool("Running", true);
                        PlayerRB2D.velocity = new Vector2(-MoveDia, -MoveDia);
                        transform.localScale = new Vector2(-0.25f, 0.25f);
                    }
                }
            }
            else
            {
                Farmer.SetBool("Running", false);
            }
        }
        if (LanternGrounded.IsGrounded == true)
        {
            Farmer.SetBool("Darkened", true);
            if (Input.GetKey(KeyCode.A))
            {
                PlayerRB2D.velocity = new Vector2(-Move, 0);
                transform.localScale = new Vector2(-0.25f, 0.25f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                PlayerRB2D.velocity = new Vector2(Move, 0);
                transform.localScale = new Vector2(0.25f, 0.25f);
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
                transform.localScale = new Vector2(-0.25f, 0.25f);
            }
            if ((Input.GetKey(KeyCode.W)) && Input.GetKey(KeyCode.D))
            {
                PlayerRB2D.velocity = new Vector2(MoveDia, MoveDia);
                transform.localScale = new Vector2(0.25f, 0.25f);
            }
            if ((Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.S))
            {
                PlayerRB2D.velocity = new Vector2(MoveDia, -MoveDia);
                transform.localScale = new Vector2(0.25f, 0.25f);
            }
            if ((Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.S))
            {
                PlayerRB2D.velocity = new Vector2(-MoveDia, -MoveDia);
                transform.localScale = new Vector2(-0.25f, 0.25f);
            }
        }
    }
}
