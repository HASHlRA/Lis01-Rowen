using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{

    public GameObject capsulePrefab;
    public Vector3[] positions;

    // Update is called once per frame
    void Update()
    {
        // If the S key is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Gets the capsules with the tag "Capsules" in game
            GameObject[] capsulesInGame = GameObject.FindGameObjectsWithTag("Capsule");

            // Deletes the capsules
            foreach (GameObject obj in capsulesInGame)
            {
                Destroy(obj);
            }

            // Spawns a capsule in each of the named positions
            foreach (Vector3 pos in positions)
            {
                Instantiate(capsulePrefab, pos, capsulePrefab.transform.rotation);
            }
        }
    }
}
