using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinging : MonoBehaviour
{
    public GameObject SquareLeft;
    public HingeJoint2D SquareLeftH;
    void Awake()
    {
        SquareLeft = GameObject.Find("SquareLeft");
        SquareLeftH = SquareLeft.GetComponent<HingeJoint2D>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SquareLeftH.useMotor = true;
        }
        else
        {
            SquareLeftH.useMotor = false;
        }
    }
}
