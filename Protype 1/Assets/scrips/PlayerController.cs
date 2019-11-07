using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     private float speed = 10.0f;
     private float turnspeed = 1000000000000.0f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");    
        forwardInput = Input.GetAxis("Vertical");
        //moves the car forwoard based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up * turnspeed * horizontalInput * Time.deltaTime);
    }
}
 