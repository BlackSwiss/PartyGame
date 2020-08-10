using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    [Range(1, 10)]
    private float moveSpeed = 5.81f;
    private Vector3 moveDirection = Vector3.zero;
    private Vector2 inputVector = Vector2.zero;
    // Start is called before the first frame update
    private CharacterController controller;
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(inputVector.x, 0, inputVector.y) * moveSpeed * Time.deltaTime;
        transform.LookAt(movement + transform.position);
        transform.Translate(movement, Space.World);
        //controller.Move(movement);
    }
    public void SetInputVector(Vector2 direction)
    {
        inputVector = direction;
    }

}
