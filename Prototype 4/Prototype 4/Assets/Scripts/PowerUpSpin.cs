using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpin : MonoBehaviour
{
    public float speed = 5.0f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * 0,2,0);
    }
}
