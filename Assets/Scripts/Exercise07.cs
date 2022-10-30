using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise07 : MonoBehaviour
{

    public GameObject sphere;

    private Material sphereMat;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the sphere's material
        sphereMat = sphere.GetComponent<Renderer>().material;
    }

    // Controls the alpha transparency of the sphere
    public void ChangeSphereAlpha(float value)
    {
        sphereMat.color = new Vector4(sphereMat.color.r, sphereMat.color.g, sphereMat.color.b, value);
    }
}
