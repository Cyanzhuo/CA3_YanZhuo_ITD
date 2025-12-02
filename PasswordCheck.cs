using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PasswordCheck : MonoBehaviour
{
    public TMP_InputField passwordField;
    public TextMeshProUGUI errorText;

    public string correctPassword = "1234";  
    public bool passwordChecker = false;

    public void Update()
    {
        if (passwordField.text == correctPassword)
        {
        Debug.Log("Correct");
        passwordChecker = true;
        }
        else;
        {
            passwordChecker = false;
        }
    }

   
}