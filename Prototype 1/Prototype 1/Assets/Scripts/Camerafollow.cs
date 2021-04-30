using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,7,-11);
   
    // Update is called once per frame
    void Update()
    {
        //Camera follows player
        transform.position = player.transform.position + offset;
    }
}
