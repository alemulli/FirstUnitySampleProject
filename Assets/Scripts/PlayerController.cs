using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Fetching the user input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        //transform.Translate(0, 0, 1); does the same as Vector3.forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Turning the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
