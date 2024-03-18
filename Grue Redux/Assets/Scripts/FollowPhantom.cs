using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPhantom : MonoBehaviour
{
    GameObject Phantom;
    void Start()
    {
        Phantom = GameObject.Find("Phantom");
    }

    void Update()
    {
        transform.position = Phantom.transform.position;
    }
}
