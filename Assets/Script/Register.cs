using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class Register : MonoBehaviour{
    public GameObject username;
    public GameObject password;
    public GameObject confPassword;
    private string Username;
    private string Password;
    private string ConfPassword;
    private string form;

 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RegisterButton()
    {
        bool UN = false;
        bool PW = false;
        bool CPW = false;

        if (Username != "")
        {
            if (!System.IO.File.Exists(@"C:\Users\PC\Desktop\UnityLogin\" + Username + ".txt"))
            {
                UN = true;
            }
            else
            {
                Debug.LogWarning("Username Taken");
            }
        }
        else
        {
            Debug.LogWarning("Username field Empty");
        }
        if (Password != "")
        {
            if(Password.Length > 5)
            {
                PW = true;
            }
            else
            {
                Debug.LogWarning("Password Must Be Atleast 6 Characters Long");
            }
        }
        else
        {
            Debug.LogWarning("Password Field Empty");
        }
        if(ConfPassword != "")
        {
            if (ConfPassword == Password)
            {
                CPW = true;
            }
            else
            {
                Debug.LogWarning("Passwords Dont Match");
            }
        }
        else
        {
            Debug.LogWarning("Confirm Password Field Empty");
        }
        if(UN == true&&PW == true&&CPW == true)
        {
            form = (Username + "\n" + Password);
            System.IO.File.WriteAllText(@"C:\Users\PC\Desktop\UnityLogin\" + Username + ".txt", form);
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            confPassword.GetComponent<InputField>().text = "";
            print("Registration Sucessful");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(Username != ""&&Password != ""&&ConfPassword!= "")
            {
                RegisterButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        ConfPassword = confPassword.GetComponent<InputField>().text;
    }
}
