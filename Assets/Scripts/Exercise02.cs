using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise02 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;

    public int number;

    // Update is called once per frame
    void Update()
    {
        // Pressing the spacebar, verifies whether the inserted number is odd or even.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If the remainder is 0, divides the number and his divisor
            if (number % 2 == 0)
            {
                // Displays the message (even) 
                textTMP.text = "The number " + number + " is even";
            }
            else
            {
                // Displays the message (odd)
                textTMP.text = "The number " + number + " is odd";
            }
        }
    }
}
