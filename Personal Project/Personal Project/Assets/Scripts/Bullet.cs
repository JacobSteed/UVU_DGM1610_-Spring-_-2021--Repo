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
        bulletSpawn = GameObject.Find("BulletSpawn");
        this.transform.rotation = bulletSpawn.transform.rotation;
    }
   
    // Update is called once per frame
    void Update()
    {
        spawnTimer -= 1 * Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
