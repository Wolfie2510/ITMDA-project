using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginRegister : MonoBehaviour
{
    // Login panel elements
    public GameObject loginPanel;
    public TMP_InputField loginUsernameInput;
    public TMP_InputField loginPasswordInput;
    public GameObject loginButton;
    public GameObject goToRegisterButton;

    // Register panel elements
    public GameObject registerPanel;
    public TMP_InputField registerUsernameInput;
    public TMP_InputField registerPasswordInput;
    public TMP_InputField registerConfirmPasswordInput;
    public GameObject registerButton;
    public GameObject goToLoginButton;

    // Show the login panel and hide the register panel
    public void ShowLoginPanel()
    {
        loginPanel.SetActive(true);
        registerPanel.SetActive(false);
    }

    // Show the register panel and hide the login panel
    public void ShowRegisterPanel()
    {
        loginPanel.SetActive(false);
        registerPanel.SetActive(true);
    }

    private void Start()
    {
        // Default to showing the login panel at the start
        ShowLoginPanel();

        // Assign button functionality
        loginButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(HandleLogin);
        goToRegisterButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ShowRegisterPanel);
        registerButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(HandleRegister);
        goToLoginButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ShowLoginPanel);
    }

    // Method to handle login
    private void HandleLogin()
    {
        string username = loginUsernameInput.text;
        string password = loginPasswordInput.text;
        // Add login logic here
        Debug.Log("Logging in with Username: " + username + " and Password: " + password);
    }

    // Method to handle register
    private void HandleRegister()
    {
        string username = registerUsernameInput.text;
        string password = registerPasswordInput.text;
        string confirmPassword = registerConfirmPasswordInput.text;

        if (password == confirmPassword)
        {
            // Add registration logic here
            Debug.Log("Registering with Username: " + username + " and Password: " + password);
        }
        else
        {
            Debug.Log("Passwords do not match!");
        }
    }
}