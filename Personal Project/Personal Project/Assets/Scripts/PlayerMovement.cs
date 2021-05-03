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
    
    //Access to Game Manager
    private GameManager gameManager;

    public bool isGameOver = false;
    public bool isGameActive = true;
    
    private Rigidbody playerRb;
   
    // Start is called before the first frame update
    void Start()
    {
        //Gravity mod and jump force
        playerRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement for left and right, forward and back
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime);
    }

    //Collision to signal to Manager that game is over
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isGameOver = true;
            Debug.Log("Game Over");
            gameManager.GameOver();
        }
    }
}

