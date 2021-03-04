using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Type: Spawn
    public GameObject obstaclePrefab;
    
    //Spawn position
    private Vector3 spawnPos = new Vector3(25,0,0);
    
    //Star Delay interval for invoking
    public float startDelay = 2.0f;
    
    //Repeat Rate interval for invoking
    public float repeatRate = 2.0f;

    private PlayerController playerControllerScript;
    private float leftBound = -15;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
         }

    void SpawnObstacle()
    {
        if (playerControllerScript.isGameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
