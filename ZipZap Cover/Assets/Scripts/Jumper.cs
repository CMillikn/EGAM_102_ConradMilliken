using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jumper : MonoBehaviour
{
    Rigidbody2D JumperRigidbody;
    Animator JumperAnimator;
    AudioSource JumperJump;
    AudioSource JumperDeath;
    AudioSource JumperScream;
    AudioSource PlaneWhirr;
    GameObject Puncher;
    GameObject Screamer;
    GameObject PlaneAudio;
    
    public float PlaneReal;
    public float Score = 1f;
    public bool isDead = false;
    public bool isJumping = false;
    public Vector2 Jump = new Vector2(0, 800);
    public float actualScore;
    void Start()
    {
        //Fetches important components
        JumperRigidbody = GetComponent<Rigidbody2D>();
        Debug.Log("Got Rigidbody");
        JumperAnimator = GetComponent<Animator>();
        JumperJump = GetComponent<AudioSource>();
        Puncher = GameObject.Find("Punch");
        JumperDeath = Puncher.GetComponent<AudioSource>();
        Screamer = GameObject.Find("Screamer");
        JumperScream = Screamer.GetComponent<AudioSource>();
        PlaneAudio = GameObject.Find("PlaneSound");
        PlaneWhirr = PlaneAudio.GetComponent<AudioSource>();
        
    }

    void FixedUpdate()
    {
        
        if ((Input.GetKey(KeyCode.UpArrow)) && (isJumping == false) && (isDead == false))
        {
            //Checks for player input
            //Debug.Log("Got input");
            //Checks for if you are already jumping
            //if (isJumping == false)
            //{
                //Debug.Log("You're on the ground");
                //Checks for if you're dead
                //if (isDead == false)
                //{
                    //Jumps and calls jump animation
                    
                    JumperJump.Play();
                    JumperRigidbody.AddForce(Jump);
                    isJumping = true;
                    Debug.Log("Yahoo!");
                    JumperAnimator.SetBool("Jumping", true);
                //}
        }

            if (isDead == false && isJumping == false)
            {
                JumperAnimator.SetBool("Walking", true);
            }
        //}
        if (isDead == true)
        {
            JumperRigidbody.AddTorque(100);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks to see if you're grounded
        if (collision.gameObject.name == "Floor")
        {
            //Resets jumping state to false if grounded
            isJumping = false;
            Debug.Log("On floor");
            JumperAnimator.SetBool("Jumping", false);
        }
        //Checks to see if you got hit by the car
        if (collision.gameObject.name == "Car")
        {
            //Kills player and calls death animation
            isDead = true;
            Vector2 death = new Vector2(-400, 600);
            JumperRigidbody.AddForce(death);
            Debug.Log("Ownalized!");
            JumperAnimator.SetBool("Dead", true);
            JumperScream.pitch = Random.Range(0.8f, 1.2f);
            JumperScream.Play();
        }
        if (collision.gameObject.name == "Plane")
        {
            //Kills player and calls death animation
            isDead = true;
            Vector2 death = new Vector2(-400, 600);
            JumperRigidbody.AddForce(death);
            Debug.Log("Ownalized!");
            JumperAnimator.SetBool("Dead", true);
            JumperScream.pitch = Random.Range(0.8f, 1.2f);
            JumperScream.Play();
        }

        if (isDead == true)
        {
            JumperDeath.Play();
            JumperDeath.pitch = Random.Range(0.8f, 1.2f);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreSquare")
        {
            Debug.Log("Bababooey");
            if (isDead == false)
            {
                actualScore++;
                if (Score >= 4f)
                {
                    Score = Score + Random.Range(-4f, -1f);
                    Debug.Log("Hooey");
                    if(Score <= 2f)
                    {
                        Score = 2f;
                    }
                }
                if (Score <= 2f)
                {
                    Score = Score + Random.Range(4f, 1f);
                    Debug.Log("Booey");
                    
                    if (Score >= 4f)
                    {
                        Score = 3f;
                    }
                }
                if ((Score >= 2f) && (Score <= 5f))
                {
                    Debug.Log("Ebebrbrbrbr");
                    Score = Score + Random.Range(4f, -4f);
                    if (Score <= 1f)
                    {
                        Score = 2f;
                    }
                    if (Score >= 4f)
                    {
                        Score = 3f;
                    }
                }
                if (isDead == true)
                {
                    JumperScream.pitch = Random.Range(0.8f, 1.2f);
                    JumperScream.Play();
                    Debug.Log("Stewie?");
                }
            }
        }
        if (collision.gameObject.name == "PlaneSquare")
        {
            PlaneReal = Random.Range(-0.35f,1);
            if (PlaneReal < 0)
            {
                PlaneWhirr.Play();
            }
        }
    }
}
