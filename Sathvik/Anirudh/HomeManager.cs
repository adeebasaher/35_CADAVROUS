using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HomeManager : MonoBehaviour
{
    // [SerializeField]
    // public TMP_InputField usernameInputField;
    // [SerializeField]
    // public TMP_InputField passwordInputField;
    // // Start is called before the first frame update
    public void OnModeClick()
    {
        // string username = usernameInputField.text;
        // string password = passwordInputField.text;

        // Debug.Log("USERNAME: " + username);
        // Debug.Log("PASSWORD: " + password);


        string selectMode = SelectedMode();

        // if (string.IsNullOrEmpty(loginCheckMessage))
        // {
        //     Debug.Log("LOGIN");
        // }
        // else{
        //     Debug.LogError("ERROR: " + loginCheckMessage);
        // }
    }

    /// <summary>
    /// Checks the input login  info is acceptable or not
    /// </summary>
    /// <returns>this will return an empty or null string for correct login. Otherwise</returns>

    private string SelectedMode()
    {
        // string returnString="";
        // if(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        // {
        //     returnString = "Both username and password are empty";
        // }
        // if (string.IsNullOrEmpty(username))
        // {
        //     returnString = "Username was empty";
        // }
        // else if (string.IsNullOrEmpty(password))
        // {
        //     returnString = "Password was empty";
        // }
        // else 
        // {
        //     returnString = "";
        // }

        // Debug.Log("RETURN STRING: " + returnString);
        // return returnString;
    }
}
