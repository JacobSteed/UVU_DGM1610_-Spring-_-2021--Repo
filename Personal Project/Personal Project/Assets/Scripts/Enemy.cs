using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        //Gets the Enemy rigidbody
        enemyRb = GetComponent<Rigidbody>();

        //Enemies seek out the player
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Movement towards the player
        Vector3 lookDirection = (player.transform.position - transform.position);
        enemyRb.AddForce(lookDirection * speed);
    }
}
