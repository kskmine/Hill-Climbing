using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class score : MonoBehaviour
{
    //public int puan;
    public Text metin;
    public Text highscore;
    int skor = 0;
    
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        
    }
    void Update()
    {
        if (skor > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", skor);
            highscore.text = skor.ToString();
        }
    }
    public void BirEkle()
    {
        int puan = 1;
            skor = skor + puan;
            string m = Convert.ToString(skor);
            metin.text = m.ToString();
        
    }
    public void BeşEkle()
    {
        int puan = 5;
        if (puan >= 0)
        {
            skor = skor + puan;
            string m = Convert.ToString(skor);
            metin.text = m.ToString();
        }
    }
    public void YirmiBeşEkle()
    {
        int puan = 25;
        if (puan >= 0)
        {
            skor = skor + puan;
            string m = Convert.ToString(skor);
            metin.text = m.ToString();
        }
    }
}
