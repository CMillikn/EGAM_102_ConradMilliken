using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternGrounded : MonoBehaviour
{
    public PhantomFollow PhantomFollow;
    public bool IsGrounded = false;
    public bool Moved = false;
    void Awake()
    {
        
    }

    void FixedUpdate()
    {
            if (IsGrounded == true)
            {
                if (Moved == false)
                { 
                    transform.position = new Vector2(Random.Range(-8, 8), Random.Range(-4, 4));
                    IsGrounded = true;
                    Moved = true;
                }
            }
                
            if (IsGrounded == false)
            {
                transform.position = new Vector2(20, 20);
            }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == ("Player"))
        {
            IsGrounded = false;
            PhantomFollow.followPlayer = true;
            Moved = false;
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        transform.position = new Vector2(20, 20);
    }
}
