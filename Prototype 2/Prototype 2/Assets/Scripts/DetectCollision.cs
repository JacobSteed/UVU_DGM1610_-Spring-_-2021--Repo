using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Destroy this object that is script is atteched to
        Destroy(gameObject);
        //Destroy other object that hits a trigger
        Destroy(other.gameObject);
    }
}
