using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Left and right movement setup
    public float speed = 20.0f;
    public float hInput;
    
    private Rigidbody playerRb;
    public float gravityMod;
    public float jumpForce;
   
    // Start is called before the first frame update
    void Start()
    {
        //Gravity mod and jump force
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement for left and right
        hInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed);

        //Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

