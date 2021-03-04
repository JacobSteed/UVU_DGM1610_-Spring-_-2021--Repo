using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 15.0f;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        // Find and stores PlayerController Script for later access
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move to the left until Game Over
        if(playerControllerScript.isGameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
