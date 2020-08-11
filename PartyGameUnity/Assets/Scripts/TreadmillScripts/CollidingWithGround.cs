using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingWithGround : MonoBehaviour
{
    public Rigidbody rb;

    public float treadmillSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Treadmill")
        {
            rb.transform.Translate(Vector3.forward * Time.deltaTime *treadmillSpeed);
        }
    }
}
