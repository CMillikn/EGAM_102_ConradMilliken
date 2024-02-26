using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAndCar : MonoBehaviour
{
    public GameObject Plane;
    public GameObject Car;
    public GameObject Dude;
    public Jumper JumperScript;
    public float PlaneReal;
    public BoxCollider2D PlaneCollider;
    public BoxCollider2D CarCollider;
    public SpriteRenderer PlaneView;
    public SpriteRenderer CarView;
    void Start()
    {
        Plane = GameObject.Find("Plane");
        Car = GameObject.Find("Car");
        Dude = GameObject.Find("Dude");
        JumperScript = Dude.GetComponent<Jumper>();
        PlaneCollider = Plane.GetComponent<BoxCollider2D>();
        CarCollider = Car.GetComponent<BoxCollider2D>();
        PlaneView = Plane.GetComponent<SpriteRenderer>();
        CarView = Car.GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        PlaneReal = JumperScript.PlaneReal;
        if (PlaneReal >= 0)
        {
            PlaneCollider.enabled = false;
            CarCollider.enabled = true;
            PlaneView.enabled = false;
            CarView.enabled = true;
        }
        if (PlaneReal < 0)
        {
            PlaneCollider.enabled = true;
            CarCollider.enabled = false;
            PlaneView.enabled = true;
            CarView.enabled = false;
        }
    }
}
