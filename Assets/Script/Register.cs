using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using Proyecto26;

public class Register : MonoBehaviour{
    public GameObject email;
    public GameObject username;
    public GameObject password;
    public GameObject confPassword;
    private string Email;
    private string Username;
    private string Password;
    private string ConfPassword;
    private string form;

    User user = new User();

    public static string playerName;
    private string idToken;
    public static string localId;
    private string getLocalId;

    private string databaseURL = "https://narda-8a665.firebaseio.com/users";
    private string AuthKey = "AIzaSyA4qw-_jK2rRXqNI_LO5DVP8X_Xvgagnyo";


    public void RegisterButton()
    {

        bool UN = false;
        bool PW = false;
        bool CPW = false;

        if (Username != "")
        {
            UN = true;
           /* if (!System.IO.File.Exists(@"C:\Users\PC\Desktop\UnityLogin\" + Username + ".txt"))
            {
                UN = true;
            }
            else
            {
                Debug.LogWarning("Username Taken");
            }*/
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
            /*auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
                if (task.IsCanceled)
                {
                    Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                    return;
                }
                if (task.IsFaulted)
                {
                    Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                    return;
                }

                // Firebase user has been created.
                Firebase.Auth.FirebaseUser newUser = task.Result;
                Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                    newUser.DisplayName, newUser.UserId);
            });

            //form = (Username + "\n" + Password);
            //System.IO.File.WriteAllText(@"C:\Users\PC\Desktop\UnityLogin\" + Username + ".txt", form);*/
            email.GetComponent<InputField>().text = "";
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            confPassword.GetComponent<InputField>().text = "";
            SignUpUserButton();
            print("Registration Sucessful");
        }
    }

    public void SignUpUserButton()
    {
        SignUpUser(Email, Username, Password);
    }

    private void PostToDatabase()
    {

        RestClient.Put(databaseURL + "/" + localId + ".json?auth=" + idToken, user);
    }

    private void SignUpUser(string email, string username, string password)
    {
        string userData = "(\"email\":\"" + email + "\",\"password\":\"" + password + "\",\"returnSecureToken\":true)";
        RestClient.Post<SignResponse>("https://identitytoolkit.googleapis.com/v1/accounts:signUp?key="+ AuthKey, userData).Then(
            response =>
        {
            idToken = response.idToken;
            localId = response.localId;
            PostToDatabase();
        }).Catch(error =>
        {
            Debug.Log(error);
        });
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
        Email = email.GetComponent<InputField>().text;
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        ConfPassword = confPassword.GetComponent<InputField>().text;
    }
}
