using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TreadmillPlayerController : MonoBehaviour
{
    Vector2 movement;
    float moveSpeed = 10f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    private void Move()
    {
        Vector3 movePlayer = new Vector3(movement.x, 0, movement.y) * moveSpeed * Time.deltaTime;
        transform.Translate(movePlayer);
    }

    private void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
        Debug.Log("Moving");
    }
    private void OnA()
    {
        rb.AddForce(Vector3.up * 250);
        Debug.Log("Pressed A");
    }
    void OnX()
    {
        Debug.Log("Pressed X");
    }
}
