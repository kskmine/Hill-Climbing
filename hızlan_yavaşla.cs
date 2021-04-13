using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class hızlan_yavaşla : MonoBehaviour
{
    public Text hız_text;
    public Text yol_text;
    private int hız=0;
    private float yol;

    public void GazaBas()
    {
        hız += 1;
        yol = hız * Time.time;
        string a = Convert.ToString(hız);
        hız_text.text = a.ToString();
        string b = Convert.ToString(yol);
        yol_text.text = b.ToString();

    }
    public void Fren()
    {
        hız -= 1;
        string a = Convert.ToString(hız);
        hız_text.text = a.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
