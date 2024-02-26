using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SpinEarth : MonoBehaviour
{
    public float speedSpin = 0.1f;
    GameObject Dude;
    public Jumper JumperScript;
    public float Score;
    // Start is called before the first frame update
    void Start()
    {
        Dude = GameObject.Find("Dude");
        JumperScript = Dude.GetComponent<Jumper>();
        Score = JumperScript.Score;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(0, 0, Score);
        Dude = GameObject.Find("Dude");
        JumperScript = Dude.GetComponent<Jumper>();
        Score = JumperScript.Score;
    }
}
