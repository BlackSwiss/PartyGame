using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Chloe Culver
//This script 
public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    [Range(1, 20)]
    private float speed = 1;

    private Vector3 LookAt;
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    public void ActionButtons(string PartyName)
    {

    }
    public void Move()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 newPosition = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.LookAt(newPosition + transform.position);
        transform.Translate(newPosition * speed * Time.deltaTime, Space.World);


    }

}
