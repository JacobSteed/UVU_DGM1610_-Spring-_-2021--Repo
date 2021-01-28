using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float speed = 5f;
  
    // Update is called once per frame
    void Update()
    {
        //Propeller rotation
        transform.Rotate(speed * 0,0,5);
    }
}
