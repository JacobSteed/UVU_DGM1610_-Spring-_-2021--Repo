using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    //Detects the collision of trigger objects
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
