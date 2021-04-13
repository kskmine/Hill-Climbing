using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class register : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    public GameObject confpassword;
    private string Username;
    private string Password;
    private string ConfPassword;
    private string form;

    public void RegisterButton()
    {
        bool UN = false;
        bool PW = false;
        bool CPW = false;

        if (Username != "")
        {
            if (!System.IO.File.Exists(@"C:\UnıtyTest\" + Username + ".txt"))
            {
                UN = true;
            }
            else
            {
                print("Username geçersiz");
            }
        }
        else
        {
            print("Username girmediniz");
        }
        if (Password != "")
        {
            if (Password.Length > 1)
            {
                PW = true;
            }
            else
            {
                print("password en az 2 karakter olmalı");
            }

        }
        else
        {
            print("password girmediniz");
        }
        if (ConfPassword != "")
        {
            if (ConfPassword == Password)
            {
                CPW = true;
            }
            else
            {
                print("passwordlar eşleşmiyor");
            }
        }
        else
        {
            print("confirmpassword girmedinizs");
        }
        if (UN == PW == CPW == true)
        {
            form = (Username + Environment.NewLine + Password);
            System.IO.File.WriteAllText(@"C:\UnıtyTest\" + Username + ".txt", form);
            PlayerPrefs.SetString("user", Username);
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            confpassword.GetComponent<InputField>().text = "";
            print("KAYIT BAŞARILI");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
            if (password.GetComponent<InputField>().isFocused)
            {
                confpassword.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Username != "" && Password != "" && ConfPassword != "")
            {
                RegisterButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        ConfPassword = confpassword.GetComponent<InputField>().text;
    }
}