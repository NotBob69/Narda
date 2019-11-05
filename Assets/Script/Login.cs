using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Text.RegularExpressions;

public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    private String[] Lines;

    public void LoginButton()
    {/*
        bool UN = false;
        bool PW = false;
        if (Username != "")
        {
            if(System.IO.File.Exists(@"C:\Users\PC\Desktop\UnityLogin\" + Username + ".txt"))
            {
                UN = true;
                Lines = System.IO.File.ReadAllLines(@"C:\Users\PC\Desktop\UnityLogin\" + Username + ".txt");
            }
            else
            {
                Debug.LogWarning("Username Invalid");
            }
        }
        else
        {
            Debug.LogWarning("Username Field Empty");
        }
        if(Password != "")
        {
            if(System.IO.File.Exists(@"C:\Users\PC\Desktop\UnityLogin\" + Username + ".txt"))
            {
                String pass = Lines[1];
                if (Password == pass)
                {
                    PW = true;
                }
                else
                {
                    Debug.LogWarning("Password Incorrect");
                }
            }
            else
            {
                Debug.LogWarning("Password Invalid");
            }
        }
        else
        {
            Debug.LogWarning("Password Field Empty");
        }
        if(UN == true&&PW == true)
        {
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            print("Login Sucessful");
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
            //SceneManager.LoadLevel("MainScene");
        }*/
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Username != "" && Password != "")
            {
                LoginButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }
}
