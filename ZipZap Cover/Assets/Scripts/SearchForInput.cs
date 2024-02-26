using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchForInput : MonoBehaviour
{
    public float winLevel = 0;
    public bool gameStarted;
    public bool violenceGo;
    public float reactTime = 1;
    public bool playerAlive;
    public bool playerReacted = false;
    public bool playerCheater = false;
    public bool waiting = false;
    public GameObject titleScreen;
    public GameObject gameScreen;
    public GameObject goScreen;
    public GameObject goodSlice;
    public GameObject badSlice;
    public GameObject playerWin;
    public GameObject playerDie;

    // Start is called before the first frame update
    void Start()
    {
        //Fetches all game objects
        titleScreen = GameObject.FindGameObjectWithTag("Intro");
        titleScreen.GetComponent<SpriteRenderer>().enabled = true;
        Debug.Log("Fetched title");
        gameScreen = GameObject.FindGameObjectWithTag("Game");
        gameScreen.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("Fetched game");
        goScreen = GameObject.FindGameObjectWithTag("Jumpscare");
        goScreen.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("Fetched go");
        goodSlice = GameObject.FindGameObjectWithTag("SamuraiCut");
        goodSlice.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("Fetched good");
        badSlice = GameObject.FindGameObjectWithTag("OniCut");
        badSlice.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("Fetched bad");
        playerWin = GameObject.FindGameObjectWithTag("Victory");
        playerWin.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("Fetched win");
        playerDie = GameObject.FindGameObjectWithTag("Hesitation");
        playerDie.GetComponent<SpriteRenderer>().enabled= false;
        Debug.Log("Fetched die");
        playerAlive = true;
        gameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        //this code removes the title screen after getting space
        if ((Input.GetKeyDown (KeyCode.Space)) && gameStarted == false)
        {
            titleScreen.GetComponent<SpriteRenderer>().enabled = false;
            gameScreen.GetComponent<SpriteRenderer>().enabled = true;
            playerWin.GetComponent<SpriteRenderer>().enabled = false;
            playerDie.GetComponent<SpriteRenderer>().enabled = false;
            gameStarted = true;
            waiting = false;

            Debug.Log("The game begins!");
        }
        if ((violenceGo == true) && (Input.GetKey(KeyCode.Space)) && playerCheater == false && waiting == true)
        {
            playerReacted = true;
            Debug.Log("Nice!");
        }
        //this code initiates a random countdown
        if ((gameStarted == true))
        {
            if (waiting == false)
            {
            StartCoroutine(WaitForAttack());
            IEnumerator WaitForAttack()
            {
                Debug.Log("Begin the waiting!");
                waiting = true;
                yield return new WaitForSeconds(.5f);
                if (violenceGo == false && (Input.GetKey(KeyCode.Space)) && waiting == true)
                    {
                        playerCheater = true;
                        Debug.Log("Idiot!");
                    }
                yield return new WaitForSeconds(Random.Range(3f,7f));
                Debug.Log("Waiting...");
                //after the countdown is complete, it shows the reflex screen and starts a shorter countdown, duration of which is based on a variable-- if the countdown ends without player input, show the loss screen. if the countdown ends and player input has been recieved, show the win screen.
                goScreen.GetComponent<SpriteRenderer>().enabled = true;
                gameScreen.GetComponent<SpriteRenderer>().enabled = false;
                violenceGo = true;
                Debug.Log("Go, go, go!");
                    StartCoroutine(DidPlayerAttack());
                    IEnumerator DidPlayerAttack()
                    {
                        yield return new WaitForSeconds(reactTime - (winLevel));
                        violenceGo = false;
                        waiting = false;
                        Debug.Log("How didja do?");
                        //this code waits for further player input, then resets the loss/win state and puts everything back to normal. it also increments the score if it's a win, or resets it to zero if it's a loss.
                        if (playerReacted == true)
                        {
                            Debug.Log("Winner!");
                            winLevel = winLevel++;
                            goodSlice.GetComponent<SpriteRenderer>().enabled = true;
                            yield return new WaitForSeconds(0.1f);
                            playerWin.GetComponent<SpriteRenderer>().enabled = true;
                            gameStarted = false;
                            goScreen.GetComponent<SpriteRenderer>().enabled = false;
                            goodSlice.GetComponent<SpriteRenderer>().enabled = false;
                            badSlice.GetComponent<SpriteRenderer>().enabled = false;
                            Debug.Log("Play again, winner?");
                            if (Input.GetKey(KeyCode.Space))
                            {
                                gameStarted = true;
                            }
                        }
                        if (playerReacted == false || playerCheater == true) 
                        {
                            Debug.Log("Lllloserrrrr!");
                            playerAlive = false;
                            winLevel = 0;
                            badSlice.GetComponent<SpriteRenderer>().enabled = true;
                            yield return new WaitForSeconds(0.1f);
                            playerDie.GetComponent<SpriteRenderer>().enabled = true;
                            gameStarted = false;
                            goScreen.GetComponent<SpriteRenderer>().enabled = false;
                            goodSlice.GetComponent<SpriteRenderer>().enabled = false;
                            badSlice.GetComponent<SpriteRenderer>().enabled = false;
                            Debug.Log("Play again, loser?");
                            if (Input.GetKey(KeyCode.Space)) 
                            { 
                            gameStarted = true;
                            }
                        }
                    }
                

            }
            }
            
        }
        

    }
}
