using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGrue : MonoBehaviour
{
    GameObject Grue;
    void Start()
    {
        Grue = GameObject.Find("Grue");
    }

    void Update()
    {
        transform.position = Grue.transform.position;
    }
}
