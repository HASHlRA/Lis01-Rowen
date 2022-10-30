using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    // Stores the position values
    private float xPosition;
    private float yPosition;
    private float zPosition;


    // Limit range
    private float xRange = 8f;
    private float yRange = 6f;
    private float zRange = 8f;


    // Update is called once per frame
    void Update()
    {
        // If the enter key is pressed
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Random values within the limits are set
            xPosition = Random.Range(-xRange, xRange);
            yPosition = Random.Range(-yRange, yRange);
            zPosition = Random.Range(-zRange, zRange);

            // Moves the cube to his new position
            transform.position = new Vector3(xPosition, yPosition, zPosition);
        }
    }
}
