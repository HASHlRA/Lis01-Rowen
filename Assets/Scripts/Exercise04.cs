using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    public GameObject sphere;

    // Change the scale of the sphere with a slider
    public void ChangeScale(float value)
    {
        sphere.transform.localScale = new Vector3(value, value, value);
    }
}
