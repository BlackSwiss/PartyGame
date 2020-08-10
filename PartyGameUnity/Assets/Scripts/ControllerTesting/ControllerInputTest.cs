using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInputTest : MonoBehaviour
{
    private PlayerInput playerInput;
    private ControllerInputTest Mover;
    //For Joystick movement
    Vector2 i_movement;
    float moveSpeed = 5f; //MoveSpeed
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectOfType<ControllerInputTest>();
        var index = playerInput.playerIndex;
        Mover = GetComponent<ControllerInputTest>();
        
    }

    // Update is called once per frame
    void Update()  {
        Move();
    }
    void Move() {
        Vector3 movement = new Vector3(i_movement.x, 0, i_movement.y) * moveSpeed * Time.deltaTime;
        transform.LookAt(movement + transform.position);
        transform.Translate(movement, Space.World);
    }
    void OnMove(InputValue value) {
        i_movement = value.Get<Vector2>(); //Moves the character on left joystick
    }
    public void SetInputVector(Vector2 direction){


    }
}
