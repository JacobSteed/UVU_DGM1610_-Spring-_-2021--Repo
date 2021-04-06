using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Left and right movement setup
    public float speed = 20.0f;
    public float turnSpeed = 30.0f;
    public float hInput;
    public float fInput;
    
    private Rigidbody playerRb;
   
    // Start is called before the first frame update
    void Start()
    {
        //Gravity mod and jump force
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement for left and right
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime);
    }
}

