using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

    private bool GameStarted = false;
    [SerializeField]
    private Text gameStateText;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Birdmovement birdMovement;
    [SerializeField]
    private FollowCamera followCamera;

    private float restartDelay = 3f;
    private float restarttimer;
    private PlayerMovement playermovement;
    private Playerhealth playerhealth;
    
	// Use this for initialization
	void Start () {
        Cursor.visible = false;

        playermovement = player.GetComponent<PlayerMovement>();
        playerhealth = player.GetComponent<Playerhealth>();

        //keep the player from moving at the start

        playermovement.enabled = false;
        birdMovement.enabled = false;
        followCamera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        //If the game is not started, and the player presses the spacebar. Then start the game.
        if (GameStarted == false && Input.GetKeyUp(KeyCode.Space) )
        {
            StartGame();
        }
        //If the player isn't alive, then end the game
        if (playerhealth.alive == false)
        {
            EndGame();

            //timer to count up to restart
            restarttimer = restarttimer + Time.deltaTime;

            //timer reached timer delay
            if (restarttimer >= restartDelay)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
	}
    private void StartGame()
    {
        GameStarted = true;
        gameStateText.color = Color.clear;
        playermovement.enabled = true;
        birdMovement.enabled = true;
        followCamera.enabled = true;
    }
    private void EndGame()
    {
        GameStarted = false;
        gameStateText.color = Color.white;
        gameStateText.text = "Game over";
        player.SetActive(false);
    }
}
