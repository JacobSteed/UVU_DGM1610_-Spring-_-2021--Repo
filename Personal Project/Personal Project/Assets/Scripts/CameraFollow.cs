using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //First person camera rotates with player movement
    public GameObject player;
    private Vector3 offset = new Vector3(0, 1, -9);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
