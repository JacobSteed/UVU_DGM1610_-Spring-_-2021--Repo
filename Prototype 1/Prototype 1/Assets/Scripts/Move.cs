using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Access Modyfier, Data Type, 
    public float speed = 30.0f;
    public float turnSpeed = 20.0f;

    public float hInput;
    float fInput;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gathers the inputs for controls
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        //Makes vehicle go forward and back
        transform.Translate(Vector3.forward * Time.deltaTime *speed * fInput);
        //Makes vehicle go left and right
        transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime);
    }
}
