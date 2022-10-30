using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise10 : MonoBehaviour
{
    public TextMeshProUGUI counter;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Resets the counter
        counter.text = score.ToString();
    }

    // Updates the score +1
    public void AddPoint()
    {
        score++;

        counter.text = score.ToString();
    }
}
