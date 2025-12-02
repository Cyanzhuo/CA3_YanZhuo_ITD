using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class SceneLoader : MonoBehaviour
{
    public PasswordCheck passwordCheck; 

    public void LoadIfPasswordCorrect()
    {
        Debug.Log("Password");

        if (passwordCheck.passwordChecker = true)
        {
            Debug.Log("Button Pressed");
            SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("Button Not Pressed");
        
        }
    }
}
