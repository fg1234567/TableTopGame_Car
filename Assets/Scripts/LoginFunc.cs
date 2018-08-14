using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginFunc : MonoBehaviour {

    public InputField userNameInput;
    public InputField userEmailInput;

    public void loginButtonClick()
    {
        if (userNameInput.text != null && userEmailInput.text != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Debug.Log("Either one is null");
        }
    }
}
