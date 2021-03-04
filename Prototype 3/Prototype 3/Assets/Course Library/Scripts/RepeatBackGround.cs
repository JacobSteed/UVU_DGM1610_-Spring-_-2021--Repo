using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    
    // Start is called before the first frame update
    void Start()
    {
        // Get start position on background
        startPos = transform.position;
        // Finding half of the background size on the x-axis
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
