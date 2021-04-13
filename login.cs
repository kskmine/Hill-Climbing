using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class login : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    private String[] Lines;

    public void LoginButton()
    {
        bool UN = false;
        bool PW = false;
        if (Username != "" && Password != "")
        {
            if (System.IO.File.Exists(@"C:/UnıtyTest/" + Username + ".txt"))
            {
                UN = true;
                Lines = System.IO.File.ReadAllLines(@"C:/UnıtyTest/" + Username + ".txt");
                if (Password == Lines[1])
                {
                    PW = true;
                }
                else
                {
                    print("Password geçersiz");
                }
            }
            else
            {
                print("Username geçersiz");
            }
        }
        else
        {
            print("Eksik Bilgi Girdiniz");
        }

        if (UN == true && PW == true)
        {
            PlayerPrefs.SetString("user", Username);
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            print("GİRİŞ BAŞARILI");
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
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Password != "" && Password != "")
            {
                LoginButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }
}
