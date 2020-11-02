using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float rotationSpeed = 20;
    public float speed = 20;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(new Vector3(1, 0, 0), Time.deltaTime * rotationSpeed * verticalInput);
        transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * rotationSpeed * horizontalInput);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(-1, 0, 0) * Time.deltaTime * rotationSpeed);
        }
        
    }
}