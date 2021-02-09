using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrestroyPrefabItem : MonoBehaviour
{
    private float topBound = 35;

    private float lowerBound = -15;
   
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
