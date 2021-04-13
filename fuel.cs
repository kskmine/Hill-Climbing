using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuel : MonoBehaviour
{
    public Image yakıtresmi;
    public float toplamyakıt = 91;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RectTransform asd = yakıtresmi.GetComponent<RectTransform>();
        asd.sizeDelta = new Vector2(asd.sizeDelta.x - Time.deltaTime, asd.sizeDelta.y);
        
    }
    public void YakıtEkle()
    {
        
        RectTransform asd = yakıtresmi.GetComponent<RectTransform>();
        float a = 91 - asd.sizeDelta.x;
        asd.sizeDelta = new Vector2(asd.sizeDelta.x+a , asd.sizeDelta.y);
    }
}
