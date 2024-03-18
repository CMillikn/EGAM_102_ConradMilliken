using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSelection : MonoBehaviour
{
    public int layoutChange;
    public GameObject Walls1;
    public GameObject Walls2;
    public GameObject Walls3;
    public GameObject Walls4;
    void Awake()
    {
        Walls1 = GameObject.Find("Walls1");
        Walls2 = GameObject.Find("Walls2");
        Walls3 = GameObject.Find("Walls3");
        Walls4 = GameObject.Find("Walls4");
        layoutChange = (Random.Range(1, 5));
        if (layoutChange == 1)
        {
            Walls2.transform.position = new Vector3(999, 999);
            Walls3.transform.position = new Vector3(999, 999);
            Walls4.transform.position = new Vector3(999, 999);
        }
        if (layoutChange == 2)
        {
            Walls1.transform.position = new Vector3(999, 999);
            Walls3.transform.position = new Vector3(999, 999);
            Walls4.transform.position = new Vector3(999, 999);
        }
        if (layoutChange == 3)
        {
            Walls1.transform.position = new Vector3(999, 999);
            Walls2.transform.position = new Vector3(999, 999);
            Walls4.transform.position = new Vector3(999, 999);
        }
        if (layoutChange == 4)
        {
            Walls1.transform.position = new Vector3(999, 999);
            Walls2.transform.position = new Vector3(999, 999);
            Walls3.transform.position = new Vector3(999, 999);
        }
    }
}
