using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise01 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;

    private int minNum = 0;
    private int maxNum = 10;

    // Generates a random number
    public void RandomNumberGenerator()
    {
        // Shows the number
        textTMP.text = Random.Range(minNum, maxNum).ToString();
    }
}
