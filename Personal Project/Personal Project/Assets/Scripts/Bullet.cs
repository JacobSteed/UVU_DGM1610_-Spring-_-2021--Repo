using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float spawnTimer;
    public float speed = 20.0f;
    public GameObject bulletSpawn;

    void Start()
    {
        //Spawn point for the bullet is the gun, or "BulletSpawn" object
        bulletSpawn = GameObject.Find("BulletSpawn");
        
        //Follows rotation of the player, and fires in the facing direction
        this.transform.rotation = bulletSpawn.transform.rotation;
    }
   
    // Update is called once per frame
    void Update()
    {
        //Spawn timer for how long each bullet stays in game
        spawnTimer -= 1 * Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
