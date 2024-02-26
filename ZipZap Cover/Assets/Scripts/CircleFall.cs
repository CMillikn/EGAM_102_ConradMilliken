using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFall : MonoBehaviour
{
    public Rigidbody2D Ball;
    void Awake()
    {
        Ball = this.GetComponent<Rigidbody2D>();
        Ball.simulated = false;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Ball.simulated=true;
        }
    }
}
