using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Chloe Culver
/*
 * This script is in charge of Moving the player in the world space
 * It's the literal game logic of moving an object
 * 
 * Attach this script to anything we want to move (I.e. the player)
 * */
public class Mover : MonoBehaviour
{
    [SerializeField]
    private int playerIndex = 0; //The controller num that is connected to this object
    [SerializeField]
    private float moveSpeed = 5.81f; //How fast the object is moving
    //Move direction
    private Vector3 moveDirection = Vector3.zero; //Where we move in the world
    private Vector2 inputVector = Vector2.zero; // Stick input of the X and Y values on a controller

    private CharacterController controller;
    private void Awake()
    {
        controller = GetComponent<CharacterController>(); //Grab character controller
    }
    public void SetInputVector(Vector2 direction)
    {
        inputVector = direction; //Setting the stick controls to the direction we want the player to move in
    }

    public int GetPlayerIndex() //return index of contrller (Player 1, Player 2)
    {
        return playerIndex;
    }
    // Update is called once per frame
    void Update()
    {
        {
            //Get info from the stick as to how to move and translate that into 3D space
            //rigidbody.AddForce(direction.forward * strength);
            Vector3 movement = new Vector3(inputVector.x, 0, inputVector.y) * moveSpeed * Time.deltaTime;
            transform.LookAt(movement + transform.position); //rotates player object in the direction it's moving to
            transform.Translate(movement, Space.World);
           // controller.Move(movement); //Moves the character from character contrller (may not be necessary)
        }
    }
}
