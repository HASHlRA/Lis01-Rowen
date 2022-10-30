using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using TMPro;

public class Exercise08 : MonoBehaviour
{
    public TMP_InputField username;
    public TextMeshProUGUI message;

    // Avoids blank spaces
    private string regexPattern = "^[A-Za-z0-9_.]+$";

    public void ConfirmUsername()
    {
        // Checks if the username meets the conditions
        if (Regex.IsMatch(username.text, regexPattern))
        {
            // Displays the welcome message
            message.text = "Hello " + username.text + ", and welcome to this amazing adventure!";
        }
    }
}
