using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhantomFollow : MonoBehaviour
{
    public GameObject Player;
    public Vector2 PlayerPos;
    public float lightSpeed;
    public float darkSpeed;
    public LightSpread LightSpread;
    public LanternGrounded LanternGrounded;
    public bool followPlayer = true;
    public Animator PhantomA;
    void Start()
    {
        Player = GameObject.Find("Player");
        PhantomA = GetComponent<Animator>();
        
    }

    void FixedUpdate()
    {
        PlayerPos = Player.transform.position;
        if (followPlayer == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                transform.position = Vector2.Lerp(transform.position, PlayerPos, lightSpeed);
                transform.rotation = Quaternion.Euler(0,0,Random.Range(10,-10));
                PhantomA.SetBool("IsChasing",true);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, PlayerPos, -darkSpeed * 0.5f);
                transform.rotation = Quaternion.Euler(0, 0, Random.Range(5, -5));
                PhantomA.SetBool("IsChasing", false);
            }
        }
        else
        {
            transform.position = Vector2.Lerp(transform.position, PlayerPos, -lightSpeed * 3);
        }
        if (LanternGrounded.IsGrounded == false)
        {
            followPlayer = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            followPlayer = false;
            LanternGrounded.IsGrounded = true;
        }
    }
}
