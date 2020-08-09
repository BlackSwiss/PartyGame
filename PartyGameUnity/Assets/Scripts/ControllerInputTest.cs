using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInputTest : MonoBehaviour
{

    //For Joystick movement
    Vector2 i_movement;
    float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 movement = new Vector3(i_movement.x, 0, i_movement.y) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
    void OnMove(InputValue value) {
        i_movement = value.Get<Vector2>(); //Moves the character onleft joystick
    }

    void OnMoveUp()
    {
        transform.Translate(transform.up);
    }

    void OnMoveDown()
    {
        transform.Translate(-transform.up);
    }
}
