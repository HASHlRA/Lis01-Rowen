using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Exercise10 manager;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the exercise 10's script
        manager = FindObjectOfType<Exercise10>();
    }

    // If the mouse is pointing to the sphere
    private void OnMouseOver()
    {
        // Clicks on it
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // +1 to the score
            manager.AddPoint();

            // Destroy the GameObject
            Destroy(gameObject);
        }
    }
}
