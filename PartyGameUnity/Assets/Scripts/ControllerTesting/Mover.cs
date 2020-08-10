using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private int playerIndex = 0;
    [SerializeField]
    private float moveSpeed = 5.81f;
    //Move direction
    private Vector3 moveDirection = Vector3.zero;
    private Vector2 inputVector = Vector2.zero;

    private CharacterController controller;
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    public void SetInputVector(Vector2 direction)
    {
        inputVector = direction;
    }

    public int GetPlayerIndex()
    {
        return playerIndex;
    }
    // Update is called once per frame
    void Update()
    {
        {
            Vector3 movement = new Vector3(inputVector.x, 0, inputVector.y) * moveSpeed * Time.deltaTime;
            transform.LookAt(movement + transform.position);
            transform.Translate(movement, Space.World);
            controller.Move(movement);
        }
    }
}
