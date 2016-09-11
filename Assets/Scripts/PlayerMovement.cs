using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private Animator playerAnimator;
    private float moveHorizontal;
    private float moveVertical;
    private Vector3 movement;
    private float turningSpeed = 20f;
    private Rigidbody playerRidgidbody;

    // Use this for initialization
    void Start()
    {
        // Gather the animator compoent from the player game object
        playerAnimator = GetComponent<Animator>();
        playerRidgidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Gather input from the keyboard
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    }
    void FixedUpdate()
    {
        //If the player is moving (the vector doesn't = 0)
        if(movement != Vector3.zero) {
            // a target rotation based on the movement vector
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);
            Quaternion newRootation = Quaternion.Lerp(playerRidgidbody.rotation, targetRotation, turningSpeed * Time.deltaTime);

            // change the players rotation to the new incremental rotation
            playerRidgidbody.MoveRotation(newRootation);
            //play jump animation
            playerAnimator.SetFloat("Speed", 3f);
        }
        else
        {
            //don't play it when they aren't
            playerAnimator.SetFloat("Speed", 0f);
        }
    }
}
