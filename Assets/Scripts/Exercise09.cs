using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise09 : MonoBehaviour
{
    public Toggle lightSwitch;

    public GameObject pointLight;

    // Start is called before the first frame update
    void Start()
    {
        // Default state of the light
        SwitchLight(lightSwitch.isOn);
    }

    // Turn the lights on/off
    public void SwitchLight(bool isOn)
    {
        // If is ON
        if (isOn)
        {
            // Turn the lights on
            pointLight.GetComponent<Light>().enabled = true;
        }
        else
        {
            // Turn the lights off
            pointLight.GetComponent<Light>().enabled = false;
        }
    }
}
